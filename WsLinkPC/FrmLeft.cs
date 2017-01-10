using DSkin.DirectUI;
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
    public partial class FrmLeft : Skin_VS_Dark
    {
        #region 属性
        /// <summary>
        /// 右边窗体
        /// </summary>
        private FrmRight RMain;

        public DuiBaseControl OpenItem { get; set; }
        #endregion

        #region 加载
        public FrmLeft(FrmRight frm)
        {
            RMain = frm;
            InitializeComponent();
        }

        private void FrmLeft_Load(object sender, EventArgs e)
        {
            LoadDevices();

            MoveForm();
        }

        /// <summary>
        /// 跟随移动
        /// </summary>
        public void MoveForm()
        {
            this.Top = RMain.Top;
            this.Left = RMain.Left - this.Width + 1;
        }



        private void FrmLeft_LocationChanged(object sender, EventArgs e)
        {
            if (RMain != null)
            {
                RMain.Top = this.Top;
                RMain.Left = this.Left + this.Width - 1;
            }
        }

        private void FrmLeft_FormClosed(object sender, FormClosedEventArgs e)
        {
            RMain.Main = null;
        }
        #endregion

        #region
        private void LoadDevices()
        {
            var img_0 = Properties.Resources.device_0203_64;
            var img_1 = Properties.Resources.device_0203_64_off;
            foreach (var item in Account.Devices)
            {
                var v = new Dev_020X(item);
                v.lblTitle.Text = item.Name;
                v.lblUser.Text = item.Labels;
                v.dev_on_off.ForeColor = item.Status ? Color.Green : Color.Gray;
                //v.sw_0.BackgroundImageLayout = ImageLayout.Stretch;
                //v.sw_1.BackgroundImageLayout = ImageLayout.Stretch;
                //v.sw_2.BackgroundImageLayout = ImageLayout.Stretch;
                v.sw_0.BackgroundImage = img_0;
                v.sw_1.BackgroundImage = img_1;
                v.sw_2.BackgroundImage = img_0;


                this.Invoke(new MethodInvoker(delegate
                {
                    list_Devices.Items.Add(v);
                }));
            }
        }
        #endregion
    }
}
