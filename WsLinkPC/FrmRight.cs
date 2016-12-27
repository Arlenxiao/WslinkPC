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

        #region 属性
        /// <summary>
        /// 左边窗体
        /// </summary>
        private FrmLeft _main = null;
        /// <summary>
        /// 左边窗体
        /// </summary>
        public FrmLeft Main
        {
            get
            {
                if (_main == null) _main = new FrmLeft(this);
                return _main;
            }
            set
            {
                _main = value;
            }
        }
        #endregion

        #region 窗体加载
        public FrmRight()
        {
            InitializeComponent();
        }

        private void FrmRight_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void FrmRight_Load(object sender, EventArgs e)
        {
            Left += Width;
            Init();
        }

        private void Init()
        {
            var rs = IResult.GetDevices();
            if (rs.result)
            {
                Account.Devices = rs.data;

                var online = Account.Devices.Count(m => m.Status);
                var offline = Account.Devices.Count(m => !m.Status);

                lbl_online.Text = online.ToString();
                lbl_offline.Text = offline.ToString();
            }

            lbl_username.Text = string.Format("{0} {1}", Account.User.Name, Account.User.DisplayName);

            Main.Owner = this;
            Main.Show();
        }
        #endregion

        #region 左窗体跟随事件
        private void FrmRight_LocationChanged(object sender, EventArgs e)
        {
            if (_main != null) _main.MoveForm();
        }

        #endregion

        private void lblMenu_Click(object sender, EventArgs e)
        {
            Main.Owner = this;
            Main.Show();
        }
    }
}
