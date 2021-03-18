using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTools_GDI.control
{
    public partial class CutPicPanelTools : UserControl
    {
        public CutPicPanelTools()
        {
            InitializeComponent();
        }

        public delegate void MsgDelegate(object sender, EventArgs e);
        public event MsgDelegate ToolsClickEvent;

        private void btnCenter_Click(Object sender, EventArgs e)
        {
            if (ToolsClickEvent!=null)
            {
                ToolsClickEvent(0, e);
            }
        }

        private void btnOk_Click(Object sender, EventArgs e)
        {
            if (ToolsClickEvent != null)
            {
                ToolsClickEvent(1, e);
            }
        }
    }
}
