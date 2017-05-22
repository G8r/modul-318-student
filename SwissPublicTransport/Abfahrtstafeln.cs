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

        /// <summary>
        /// Konstruktor der Abfahrstafeln Klasse
        /// </summary>
        /// <param name="mainPanel"></param>
        public Abfahrtstafeln(Panel mainPanel)
        {
            InitializeComponent();
            autoCompleteAbfahrtstafelnTB.Visible = false;
            abfahrtstafelnSuchresultatDG.Visible = false;
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
                autoCompleteAbfahrtstafelnTB.Items.Clear();

                if (senderTB.Text.Length > 1)
                {
                    Stations stationRes = _transportAPI.GetStations(senderTB.Text.ToString());

                    foreach (Station station in stationRes.StationList)
                    {
                        autoCompleteAbfahrtstafelnTB.Items.Add(station.Name);
                    }
                    if (autoCompleteAbfahrtstafelnTB.Items.Count > 0)
                    {
                        autoCompleteAbfahrtstafelnTB.Visible = true;
                    }
                }
                else
                {
                    autoCompleteAbfahrtstafelnTB.Visible = false;
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
            autoCompleteAbfahrtstafelnTB.Visible = false;
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
                abfahrtstafelnSuchresultatDG.Visible = true;
            }
        }

        private void autoCompleteAnsichtAbfahrtstafelnMouseClick(object sender, MouseEventArgs e)
        {
            abfahrtstafelVonTB.Text = autoCompleteAbfahrtstafelnTB.SelectedItems[0].ToString();
        }

        private void abfahrtstafelVonTBKeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Down && autoCompleteAbfahrtstafelnTB.Items.Count > 0)
            {
                autoCompleteAbfahrtstafelnTB.Select();
                autoCompleteAbfahrtstafelnTB.Items[0].Selected = true;
            }
            if (e.KeyCode == Keys.Enter && autoCompleteAbfahrtstafelnTB.Items.Count > 0)
            {
                abfahrtstafelVonTB.Text = autoCompleteAbfahrtstafelnTB.FocusedItem.Text.ToString();
            }
        }
    }
}
