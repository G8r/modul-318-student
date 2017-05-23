using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace SwissPublicTransport
{
    public partial class Abfahrtstafeln : UserControl
    {
        private Transport _transportAPI = new Transport();

        public Abfahrtstafeln()
        {
            InitializeComponent();
            autoCompleteAbfahrtstafelnLV.View = View.SmallIcon;
            autoCompleteAbfahrtstafelnLV.Visible = false;
            abfahrtstafelnSuchresultatDG.Visible = false;
        }

        public Abfahrtstafeln(Panel mainPanel)
        {
            InitializeComponent();
            autoCompleteAbfahrtstafelnLV.View = View.SmallIcon;
            autoCompleteAbfahrtstafelnLV.Visible = false;
            abfahrtstafelnSuchresultatDG.Visible = false;
        }

        public IButtonControl getAcceptButton()
        {
            return this.abfahrtstafelSuchenBtn;
        }

        private void abfahrtstafelVonTBTextChanged(object sender, EventArgs e)
        {
            updateSuchergebnisse(sender);
        }

        private void updateSuchergebnisse(object sender)
        {
            try
            {
                TextBox senderTB = sender as TextBox;
                autoCompleteAbfahrtstafelnLV.Items.Clear();

                if (senderTB.Text.Length > 1)
                {
                    Stations stationRes = _transportAPI.GetStations(senderTB.Text.ToString());

                    foreach (Station station in stationRes.StationList)
                    {
                        autoCompleteAbfahrtstafelnLV.Items.Add(station.Name);
                    }
                    if (autoCompleteAbfahrtstafelnLV.Items.Count > 0)
                    {
                        autoCompleteAbfahrtstafelnLV.Visible = true;
                    }
                }
                else
                {
                    autoCompleteAbfahrtstafelnLV.Visible = false;
                }
            }
            catch (System.Net.WebException)
            {
                //WebExpection wird nicht ausgegeben, da es für den Arbeitsfluss störender wäre.
                //Es müsste mit einem asynchronen Task gelöst werden, da ich damit aber noch zu wenig vertraut bin. Löse ich es vorerst auf diese Weise.
            }
        }

        private void abfahrtstafelSuchenBTNClick(object sender, EventArgs e)
        {
            //Für die Optik das leere DataGridView verstecken im Falle, dass mehere Suchabfragen aufeinander erfolgen
            autoCompleteAbfahrtstafelnLV.Visible = false;

            try
            {
                abfahrtstafelnSuchresultatDG.Rows.Clear();

                if (abfahrtstafelVonTB.Text.Length > 0)
                {
                    var stationen = _transportAPI.GetStations(abfahrtstafelVonTB.Text);
                    string stationenId = stationen.StationList[0].Id;

                    var suchResultat = _transportAPI.GetStationBoard(abfahrtstafelVonTB.Text, stationenId).Entries;

                    foreach (var station in suchResultat)
                    {
                        DateTime abfahrtZeitDT = Convert.ToDateTime(station.Stop.Departure);
                        String abfahrtsZeitST = abfahrtZeitDT.ToString("HH:mm");

                        DataGridViewRow rowDGR = new DataGridViewRow();

                        rowDGR.CreateCells(abfahrtstafelnSuchresultatDG);
                        rowDGR.Cells[0].Value = station.Category;
                        rowDGR.Cells[1].Value = abfahrtsZeitST;
                        rowDGR.Cells[2].Value = station.To;

                        abfahrtstafelnSuchresultatDG.Rows.Add(rowDGR);
                    }
                    if (suchResultat == null)
                    {
                        MessageBox.Show("Es wurden keine Ergebnisse gefunden, versuchen sie es nochmals");
                    }
                    else
                    {
                        abfahrtstafelnSuchresultatDG.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Bitte geben Sie die Station ein nach welcher Sie suchen wollen");
                }
            }
            catch (System.Net.WebException)
            {

            }
        }

        private void autoCompleteAnsichtAbfahrtstafelnMouseClick(object sender, MouseEventArgs e)
        {
            abfahrtstafelVonTB.Text = autoCompleteAbfahrtstafelnLV.FocusedItem.Text.ToString();
            autoCompleteAbfahrtstafelnLV.Visible = false;
        }

        private void abfahrtstafelVonTBKeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Down && autoCompleteAbfahrtstafelnLV.Items.Count > 0)
            {
                autoCompleteAbfahrtstafelnLV.Select();
                autoCompleteAbfahrtstafelnLV.Items[0].Selected = true;
            }
            if (e.KeyCode == Keys.Tab)
            {
                autoCompleteAbfahrtstafelnLV.Visible = false;
                abfahrtstafelSuchenBtn.Focus();
            }
            if (e.KeyCode == Keys.Enter && autoCompleteAbfahrtstafelnLV.Items.Count > 0 && autoCompleteAbfahrtstafelnLV.SelectedItems.Count > 0)
            {
                abfahrtstafelVonTB.Text = autoCompleteAbfahrtstafelnLV.FocusedItem.Text.ToString();
                autoCompleteAbfahrtstafelnLV.Visible = false;
                verbindungenDTP.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                autoCompleteAbfahrtstafelnLV.Visible = false;
                abfahrtstafelSuchenBtn.Focus();
                SendKeys.Send("{ENTER}");
            }
        }

        private void mainPanelMouseClick(object sender, MouseEventArgs e)
        {
            autoCompleteAbfahrtstafelnLV.Visible = false;
        }

        private void abfahrtstafelSuchenBtnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{ENTER}");
            }
        }

        private void backBTNMouseClick(object sender, MouseEventArgs e)
        {
            Helper helper = Helper.Instance;
            List<Control> controls = helper.getControls();
            Panel mainPanel = helper.getPanel();
            mainPanel.Controls.Clear();
            foreach (Control control in controls)
            {
                mainPanel.Controls.Add(control);
            }
        }

        private void verbindungenDTPKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                abfahrtstafelSuchenBtn.Focus();
                SendKeys.Send("{ENTER}");
            }
        }
    }
}
