using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissPublicTransport
{
    using System;
    using System.Windows.Forms;

    public class Helper
    {
        private static Helper instance;
        private Panel mainPanel;
        private List<Control> controls = new List<Control>();

        private Helper() { }

        public static Helper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Helper();
                }
                return instance;
            }
        }

        public void setMainPanel(Panel panel)
        {
            this.mainPanel = panel;
        }

        public Panel getPanel()
        {
            return this.mainPanel;
        }

        public void setControls(Control control)
        {
            this.controls.Add(control);
        }

        public List<Control> getControls()
        {
            return this.controls;
        }

    }
}
