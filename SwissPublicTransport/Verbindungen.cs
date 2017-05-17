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
    public partial class Verbindungen : UserControl
    {
        Transport _transportAPI = new Transport();

        public Verbindungen(Panel mainPanel)
        {
            InitializeComponent();

            verbindungenSuchresultatDg.Visible = false;

            //Eigenes Datumsformat definieren
            verbindungenDtp.MinDate = DateTime.Today;
            verbindungenDtp.Format = DateTimePickerFormat.Custom;
            verbindungenDtp.CustomFormat = "dd-MM-yyyy";
        }

        private void verbindungSuchenBtn_Click(object sender, EventArgs e)
        {
            verbindungenSuchresultatDg.Visible = true;
            Connections suchResultat = _transportAPI.GetConnections(verbindungenVonTb.Text, verbindungenBisTb.Text, verbindungenDtp.Text);
            
            foreach(Connection connection in suchResultat.ConnectionList)
            {

                String duration = connection.Duration;
                int startIndex = 0;
                int anzahlZeichen = 3;
                duration = duration.Remove(startIndex, anzahlZeichen);

                DataGridViewRow row = new DataGridViewRow();

                
                row.CreateCells(verbindungenSuchresultatDg);
                row.Cells[0].Value = connection.From.Station.Name;
                row.Cells[1].Value = connection.To.Station.Name;
                row.Cells[2].Value = duration;
                row.Cells[3].Value = connection.From.Departure;
                row.Cells[4].Value = connection.To.Arrival;
                row.Cells[5].Value = connection.From.Platform;
                row.Cells[6].Value = connection.To.Platform;
                
                verbindungenSuchresultatDg.Rows.Add(row);
            }

        }
    }
}
