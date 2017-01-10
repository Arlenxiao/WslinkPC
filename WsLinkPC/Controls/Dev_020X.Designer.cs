namespace WsLinkPC
{
    partial class Dev_020X
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dev_020X));
            this.lblTitle = new DSkin.DirectUI.DuiLabel();
            this.dev_on_off = new DSkin.DirectUI.DuiIcon();
            this.lblUser = new DSkin.DirectUI.DuiLabel();
            this.sw_0 = new DSkin.DirectUI.DuiBaseControl();
            this.sw_1 = new DSkin.DirectUI.DuiBaseControl();
            this.sw_2 = new DSkin.DirectUI.DuiBaseControl();
            this.duiBaseControl1 = new DSkin.DirectUI.DuiBaseControl();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(175)))), ((int)(((byte)(174)))));
            this.lblTitle.Location = new System.Drawing.Point(5, 130);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(240, 17);
            this.lblTitle.Text = "三位触摸开关";
            // 
            // dev_on_off
            // 
            this.dev_on_off.DesignModeCanResize = false;
            this.dev_on_off.ForeColor = System.Drawing.Color.Green;
            this.dev_on_off.Icon = DSkin.Common.FontAwesomeChars.icon_user;
            this.dev_on_off.IconSize = 10F;
            this.dev_on_off.Location = new System.Drawing.Point(7, 158);
            this.dev_on_off.Name = "dev_on_off";
            this.dev_on_off.Size = new System.Drawing.Size(16, 15);
            // 
            // lblUser
            // 
            this.lblUser.AutoEllipsis = true;
            this.lblUser.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblUser.Location = new System.Drawing.Point(27, 155);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(220, 18);
            this.lblUser.Text = "抽风机：开、灯：开、灯：开";
            // 
            // sw_0
            // 
            this.sw_0.AutoSize = false;
            this.sw_0.BackgroundImage = global::WsLinkPC.Properties.Resources.device_0203_64;
            this.sw_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sw_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_0.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sw_0.Location = new System.Drawing.Point(0, 20);
            this.sw_0.Name = "sw_0";
            this.sw_0.Size = new System.Drawing.Size(80, 80);
            // 
            // sw_1
            // 
            this.sw_1.AutoSize = false;
            this.sw_1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sw_1.BackgroundImage")));
            this.sw_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sw_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sw_1.Location = new System.Drawing.Point(84, 20);
            this.sw_1.Name = "sw_1";
            this.sw_1.Size = new System.Drawing.Size(80, 80);
            // 
            // sw_2
            // 
            this.sw_2.AutoSize = false;
            this.sw_2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sw_2.BackgroundImage")));
            this.sw_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sw_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sw_2.Location = new System.Drawing.Point(166, 20);
            this.sw_2.Name = "sw_2";
            this.sw_2.Size = new System.Drawing.Size(80, 80);
            // 
            // duiBaseControl1
            // 
            this.duiBaseControl1.AutoSize = false;
            this.duiBaseControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.duiBaseControl1.CanFocus = true;
            this.duiBaseControl1.DesignModeCanMove = false;
            this.duiBaseControl1.DesignModeCanResize = false;
            this.duiBaseControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.duiBaseControl1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.duiBaseControl1.Location = new System.Drawing.Point(0, 0);
            this.duiBaseControl1.Name = "duiBaseControl1";
            this.duiBaseControl1.Size = new System.Drawing.Size(250, 120);
            // 
            // Dev_020X
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dev_on_off);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.sw_0);
            this.Controls.Add(this.sw_1);
            this.Controls.Add(this.sw_2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowBorder = false;
            this.Size = new System.Drawing.Size(250, 180);
            this.ResumeLayout();

        }

        #endregion
        public DSkin.DirectUI.DuiBaseControl sw_2;
        public DSkin.DirectUI.DuiBaseControl sw_1;
        public DSkin.DirectUI.DuiBaseControl sw_0;
        public DSkin.DirectUI.DuiLabel lblUser;
        public DSkin.DirectUI.DuiLabel lblTitle;
        public DSkin.DirectUI.DuiIcon dev_on_off;
        private DSkin.DirectUI.DuiBaseControl duiBaseControl1;
    }
}
