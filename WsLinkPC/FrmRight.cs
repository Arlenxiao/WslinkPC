using DSkin.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WsLinkPC
{
    public partial class FrmRight : Skin_VS_Dark
    {
        public FrmRight()
        {
            InitializeComponent();
        }

        private void FrmRight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
