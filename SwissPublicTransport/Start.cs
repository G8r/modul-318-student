using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissPublicTransport
{
    public partial class  Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void verbindungBtn_Click(object sender, EventArgs e)
        {
            UserControl verbindungen = new Verbindungen(mainPanel);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(verbindungen);
        }

        private void abfahrtstafelBtn_Click(object sender, EventArgs e)
        {
            UserControl abfahrtstafeln = new Abfahrtstafeln(mainPanel);
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(abfahrtstafeln);
        }
    }
}
