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

        /// <summary>
        /// Konstruktor für die Klasse Verbindungen
        /// </summary>
        /// <param name="mainPanel"></param>
        public Verbindungen(Panel mainPanel)
        {
            InitializeComponent();
            verbindungenSuchresultatDG.Visible = false;
            autoCompleteVerbindungenLV.Visible = false;
            autoCompleteVerbindungenBis.Visible = false;
            autoCompleteVerbindungenLV.View = View.SmallIcon;
            autoCompleteVerbindungenBis.View = View.SmallIcon;

            //Datums -und Zeitformat für die Verbindungssuche definieren
            zeitPicker.Format = DateTimePickerFormat.Time;
            zeitPicker.ShowUpDown = true;
            verbindungenDtp.MinDate = DateTime.Today;
            verbindungenDtp.Format = DateTimePickerFormat.Custom;
            verbindungenDtp.CustomFormat = "dd-MM-yyyy";
        }

        private void verbindungSuchenBtn_Click(object sender, EventArgs e)
        {
            //Benutzereingaben überprüfen um die Parameter für die API-Anfrage sicher zu stellen
            if(verbindungenVonTB.Text.Length > 0 && verbindungenBisTB.Text.Length > 0)
            {
                verbindungenSuchresultatDG.Rows.Clear();
                DateTime zeit = Convert.ToDateTime(zeitPicker.Value.ToString());
                String datum = verbindungenDtp.Value.ToShortDateString();
                Connections suchResultat = _transportAPI.GetConnections(verbindungenVonTB.Text, verbindungenBisTB.Text, datum, zeit.ToString("HH:mm"));

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
                    row.Cells[3].Value = start.ToString("MM.dd -- HH:mm");
                    row.Cells[4].Value = ziel.ToString("MM.dd -- HH:mm");
                    row.Cells[5].Value = connection.From.Platform;
                    row.Cells[6].Value = connection.To.Platform;

                    verbindungenSuchresultatDG.Rows.Add(row);
                }
                verbindungenSuchresultatDG.Visible = true;
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie zuerst die Start und Zielstation");
            }
        }

        private void verbindungenVonTB_TextChanged_1(object sender, EventArgs e)
        {
            updateSuchergebnisse(sender, autoCompleteVerbindungenLV);     
        }

        private void verbindungenBisTB_TextChanged(object sender, EventArgs e)
        {
            updateSuchergebnisse(sender, autoCompleteVerbindungenBis);
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
            verbindungenVonTB.Text = autoCompleteVerbindungenLV.FocusedItem.Text.ToString();
            autoCompleteVerbindungenLV.Visible = false;
        }

        private void autoCompleteVerbindungenBisMouseClick(object sender, MouseEventArgs e)
        {
            verbindungenBisTB.Text = autoCompleteVerbindungenBis.FocusedItem.Text.ToString();
            autoCompleteVerbindungenBis.Visible = false;
        }

        private void benutzerSteuerungEnter(object sender, EventArgs e)
        {
            autoCompleteVerbindungenLV.Visible = false;
        }

        private void verbindungenVonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && autoCompleteVerbindungenLV.Items.Count > 0)
            {
                autoCompleteVerbindungenLV.Select();
                autoCompleteVerbindungenLV.Items[0].Selected = true;
            }

            if (e.KeyCode == Keys.Enter && autoCompleteVerbindungenLV.Items.Count > 0 && autoCompleteVerbindungenLV.SelectedItems.Count > 0)
            {
                verbindungenVonTB.Text = autoCompleteVerbindungenLV.FocusedItem.Text.ToString();
                autoCompleteVerbindungenLV.Visible = false;
            }
            else
            {
                autoCompleteVerbindungenLV.Visible = false;
            }
        }

        private void verbindungenBisTBKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && autoCompleteVerbindungenBis.Items[0].Text.Length > 0)
            {
                autoCompleteVerbindungenBis.Select();
                autoCompleteVerbindungenBis.Items[0].Selected = true;
            }
            if (e.KeyCode == Keys.Enter && autoCompleteVerbindungenBis.Items.Count > 0 && autoCompleteVerbindungenBis.SelectedItems.Count > 0)
            {
                verbindungenBisTB.Text = autoCompleteVerbindungenBis.FocusedItem.Text.ToString();
                autoCompleteVerbindungenBis.Visible = false;
            }
            else
            {
                autoCompleteVerbindungenBis.Visible = false;
            }
        }

        private void verbindungSuchenBTNEnter(object sender, EventArgs e)
        {
            autoCompleteVerbindungenLV.Visible = false;
            autoCompleteVerbindungenBis.Visible = false;
        }

        private void stationenWechselnClick(object sender, EventArgs e)
        {
            if(verbindungenVonTB.Text.Length > 0 && verbindungenBisTB.Text.Length > 0)
            {
                String vonTB = verbindungenVonTB.Text;
                verbindungenVonTB.Text = verbindungenBisTB.Text;
                verbindungenBisTB.Text = vonTB;
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie zuerst die Felder \"Von:\" und \"Bis:\" aus.");
            }
        }
    } 
}
