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
using System.Threading;

namespace SwissPublicTransport
{
    public partial class Verbindungen : UserControl
    {
        private Transport _transportAPI = new Transport();
        private Panel mainPanel;


        public Verbindungen()
        {
            InitializeComponent();
            verbindungenSuchresultatDG.Visible = false;
            autoCompleteVerbindungenVonLV.Visible = false;
            autoCompleteVerbindungenBisLV.Visible = false;
            autoCompleteVerbindungenVonLV.View = View.SmallIcon;
            autoCompleteVerbindungenBisLV.View = View.SmallIcon;

            //Datums -und Zeitformat für das UI definieren
            zeitPickerDTP.Format = DateTimePickerFormat.Time;
            zeitPickerDTP.ShowUpDown = true;
            verbindungenDTP.MinDate = DateTime.Today;
            verbindungenDTP.Format = DateTimePickerFormat.Custom;
            verbindungenDTP.CustomFormat = "dd.MM.yyyy";
        }

        public Verbindungen(Panel mainPanel)
        {
            InitializeComponent();
            this.mainPanel = mainPanel;
            verbindungenSuchresultatDG.Visible = false;
            autoCompleteVerbindungenVonLV.Visible = false;
            autoCompleteVerbindungenBisLV.Visible = false;
            autoCompleteVerbindungenVonLV.View = View.SmallIcon;
            autoCompleteVerbindungenBisLV.View = View.SmallIcon;

            //Datums -und Zeitformat für das UI definieren
            zeitPickerDTP.Format = DateTimePickerFormat.Time;
            zeitPickerDTP.ShowUpDown = true;
            verbindungenDTP.MinDate = DateTime.Today;
            verbindungenDTP.Format = DateTimePickerFormat.Custom;
            verbindungenDTP.CustomFormat = "dd.MM.yyyy";
        }

        public IButtonControl getAcceptButton()
        {
            return this.verbindungSuchenBtn;
        }

        private void verbindungSuchenBtn_Click(object sender, EventArgs e)
        {
            //Für die Optik das leere DataGridView verstecken im Falle, dass mehere Suchabfragen aufeinander erfolgen
            verbindungenSuchresultatDG.Visible = false;

            //Benutzereingaben überprüfen um die Parameter für die API-Anfrage sicher zu stellen
            if (verbindungenVonTB.Text.Length > 0 && verbindungenBisTB.Text.Length > 0)
            {
                verbindungenSuchresultatDG.Rows.Clear();
                DateTime zeit = Convert.ToDateTime(zeitPickerDTP.Value.ToString());
                String datum = verbindungenDTP.Value.ToShortDateString();
                Connections suchResultat = _transportAPI.GetConnectionsWithDate(verbindungenVonTB.Text, verbindungenBisTB.Text, datum, zeit.ToString("HH:mm"));

                foreach (Connection connection in suchResultat.ConnectionList)
                {
                    String duration = connection.Duration;
                    int startIndex = 0;
                    int anzahlZeichen = 3;
                    duration = duration.Remove(startIndex, anzahlZeichen);
                    DateTime start = Convert.ToDateTime(connection.From.Departure);
                    DateTime ziel = Convert.ToDateTime(connection.To.Arrival);
                    DataGridViewRow row = new DataGridViewRow();

                    row.CreateCells(verbindungenSuchresultatDG);
                    row.Cells[0].Value = connection.From.Station.Name;
                    row.Cells[1].Value = connection.To.Station.Name;
                    row.Cells[2].Value = duration;
                    row.Cells[3].Value = start.ToString("dd.MM -- HH:mm");
                    row.Cells[4].Value = ziel.ToString("dd.MM -- HH:mm");
                    if(connection.From.Platform == "")
                    {
                        row.Cells[5].Value = "-";
                    }
                    else
                    {
                        row.Cells[5].Value = connection.From.Platform;
                    }
                    if(connection.To.Platform == "")
                    {
                        row.Cells[6].Value = "-";
                    }
                    else
                    {
                        row.Cells[6].Value = connection.To.Platform;
                    }
                    verbindungenSuchresultatDG.Rows.Add(row);
                }
                if(suchResultat == null)
                {
                    MessageBox.Show("Es wurden keine Ergebnisse gefunden, versuchen sie es nochmals");
                }
                else
                {
                    verbindungenSuchresultatDG.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst die Start und Zielstation");
            }
        }

        private void verbindungenVonTB_TextChanged_1(object sender, EventArgs e)
        {
            updateSuchergebnisse(sender, autoCompleteVerbindungenVonLV);     
        }

        private void verbindungenBisTB_TextChanged(object sender, EventArgs e)
        {
            updateSuchergebnisse(sender, autoCompleteVerbindungenBisLV);
        }

        private void updateSuchergebnisse(object sender, ListView lv)
        {
            try
            {
                TextBox senderTB = sender as TextBox;
                ListView listView = lv as ListView;
                listView.Items.Clear();

                if (senderTB.Text.Length > 1)
                {
                    Stations stations = _transportAPI.GetStations(senderTB.Text.ToString());

                    foreach (Station station in stations.StationList)
                    {
                        listView.Items.Add(station.Name);
                    }
                    if (listView.Items.Count > 0)
                    {
                        listView.Visible = true;
                    }
                }
                else
                {
                    listView.Visible = false;
                }
            }
            catch (System.Net.WebException)
            {
               //WebExpection wird nicht ausgegeben, da es für den Arbeitsfluss störender wäre.
               //Es müsste mit einem asynchronen Task gelöst werden, da ich damit aber noch zu wenig vertraut bin. Löse ich es vorerst auf diese Weise.
            }
            
        }

        private void autoCompleteVerbindungenMouseClick(object sender, MouseEventArgs e)
        {
            verbindungenVonTB.Text = autoCompleteVerbindungenVonLV.FocusedItem.Text.ToString();
            autoCompleteVerbindungenVonLV.Visible = false;
            verbindungenBisTB.Focus();
        }

        private void autoCompleteVerbindungenBisMouseClick(object sender, MouseEventArgs e)
        {
            verbindungenBisTB.Text = autoCompleteVerbindungenBisLV.FocusedItem.Text.ToString();
            autoCompleteVerbindungenBisLV.Visible = false;
            verbindungSuchenBtn.Focus();
        }

        private void benutzerSteuerungEnter(object sender, EventArgs e)
        {
            autoCompleteVerbindungenVonLV.Visible = false;
        }

        private void verbindungenVonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && autoCompleteVerbindungenVonLV.Items.Count > 0)
            {
                autoCompleteVerbindungenVonLV.Select();
                autoCompleteVerbindungenVonLV.Items[0].Selected = true;
            }
            if (e.KeyCode == Keys.Tab)
            {
                autoCompleteVerbindungenVonLV.Visible = false;
                verbindungenBisTB.Focus();
            }
            if (e.KeyCode == Keys.Enter && autoCompleteVerbindungenVonLV.Items.Count > 0 && autoCompleteVerbindungenVonLV.SelectedItems.Count > 0)
            {
                verbindungenVonTB.Text = autoCompleteVerbindungenVonLV.FocusedItem.Text.ToString();
                autoCompleteVerbindungenVonLV.Visible = false;
                verbindungenBisTB.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                autoCompleteVerbindungenVonLV.Visible = false;
                verbindungenBisTB.Focus();
            }
        }

        private void verbindungenBisTBKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && autoCompleteVerbindungenBisLV.Items[0].Text.Length > 0)
            {
                autoCompleteVerbindungenBisLV.Select();
                autoCompleteVerbindungenBisLV.Items[0].Selected = true;
            }
            if(e.KeyCode == Keys.Tab)
            {
                autoCompleteVerbindungenBisLV.Visible = false;
                verbindungenDTP.Focus();
            }
            if (e.KeyCode == Keys.Enter && autoCompleteVerbindungenBisLV.Items.Count > 0 && autoCompleteVerbindungenBisLV.SelectedItems.Count > 0)
            {
                verbindungenBisTB.Text = autoCompleteVerbindungenBisLV.FocusedItem.Text.ToString();
                autoCompleteVerbindungenBisLV.Visible = false;
                verbindungenDTP.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                autoCompleteVerbindungenBisLV.Visible = false;
                verbindungenDTP.Focus();
            }
        }

        private void verbindungSuchenBTNEnter(object sender, EventArgs e)
        {
            autoCompleteVerbindungenVonLV.Visible = false;
            autoCompleteVerbindungenBisLV.Visible = false;
        }

        private void stationenWechselnClick(object sender, EventArgs e)
        {
            if(verbindungenVonTB.Text.Length > 0 && verbindungenBisTB.Text.Length > 0)
            {
                String vonTB = verbindungenVonTB.Text;
                verbindungenVonTB.Text = verbindungenBisTB.Text;
                verbindungenBisTB.Text = vonTB;
                verbindungSuchenBTNEnter("object", e);
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie zuerst die Felder \"Von:\" und \"Bis:\" aus.");
            }
        }

        private void mainPanelMouseClick(object sender, MouseEventArgs e)
        {
            autoCompleteVerbindungenVonLV.Visible = false;
            autoCompleteVerbindungenBisLV.Visible = false;
        }

        private void verbindungSuchenBtnKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{ENTER}");
            }
        }

        private void verbindungenDTPEnter(object sender, EventArgs e)
        {
            autoCompleteVerbindungenBisLV.Visible = false;
        }

        private void backBTNClick(object sender, EventArgs e)
        {
            Helper helper = Helper.Instance;
            List<Control> controls = helper.getControls();
            Panel mainPanel = helper.getPanel();
            mainPanel.Controls.Clear();
            foreach(Control control in controls)
            {
                mainPanel.Controls.Add(control);
            }
        }
    } 
}
