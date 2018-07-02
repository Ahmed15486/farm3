using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.PL.Tools
{
    public partial class btn : UserControl
    {
        public btn()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Popup;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
        }
    }
}
