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
            Helper helper = Helper.Instance;
            helper.setMainPanel(this.mainPanel);
            helper.setControls(this.verbindungBtn);
            helper.setControls(this.abfahrtstafelBtn);
        }

        private void verbindungBtn_Click(object sender, EventArgs e)
        {
            UserControl verbindungen = new Verbindungen(Helper.Instance.getPanel());
            Verbindungen verb = new Verbindungen();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(verbindungen);
            this.AcceptButton = verb.getAcceptButton();
        }

        private void abfahrtstafelBtn_Click(object sender, EventArgs e)
        {
            UserControl abfahrtstafeln = new Abfahrtstafeln(Helper.Instance.getPanel());
            Abfahrtstafeln abf = new Abfahrtstafeln();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(abfahrtstafeln);
            this.AcceptButton = abf.getAcceptButton();
        }

        private void button1Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Wollen Sie das Program schliessen?", "Schliessen", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
