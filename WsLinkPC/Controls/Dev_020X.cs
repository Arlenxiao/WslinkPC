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
            //MessageBox.Show(Dev.Data.Substring(0,2))
            var state = Dev.Data.Substring(0, 2);
            var data = state == "00" ? "01" : "00";

            var rs = IResult.Write(Dev.ID, 1, data);

            if (rs.result)
            {
                var m = rs as WriteResult;
                Dev.Data = m.data;
                var s = m.data.Substring(0, 2);

                sw_0.BackgroundImage = s != "00" ? Properties.Resources.device_0203_64 : Properties.Resources.device_0203_64_off;

                UpdateDeviceItem();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }

        private void UpdateDeviceItem()
        {
            var dev = Account.Devices.FirstOrDefault(m => m.ID == Dev.ID);
            if (dev != null) Account.Devices.Remove(dev);
            Account.Devices.Add(Dev);

        }

    }
}
