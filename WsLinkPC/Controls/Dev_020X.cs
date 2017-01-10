using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSkin.DirectUI;

namespace WsLinkPC
{
    public partial class Dev_020X : DuiBaseControl
    {
        public Dev_020X()
        {
            InitializeComponent();
        }

        private DeviceItem Dev = new DeviceItem();



        public Dev_020X(DeviceItem dev)
        {
            InitializeComponent();

            Dev = dev;
            Init();

        }

        private void Init()
        {
            sw_0.MouseClick += Sw_0_MouseClick;
            sw_1.MouseClick += Sw_1_MouseClick;
            sw_2.MouseClick += Sw_2_MouseClick;
        }

        private void Sw_2_MouseClick(object sender, DuiMouseEventArgs e)
        {
            MessageBox.Show(Dev.Data.Substring(4, 2));
        }

        private void Sw_1_MouseClick(object sender, DuiMouseEventArgs e)
        {
            MessageBox.Show(Dev.Data.Substring(2, 2));
        }

        private void Sw_0_MouseClick(object sender, DuiMouseEventArgs e)
        {
            MessageBox.Show(Dev.Data.Substring(0,2));
        }

    }
}
