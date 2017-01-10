namespace WsLinkPC
{
    partial class FrmLeft
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLeft));
            this.dSkinUserControl1 = new DSkin.Controls.DSkinUserControl();
            this.btn_Query = new DSkin.Controls.DSkinButton();
            this.txt_Query = new DSkin.Controls.DSkinTextBox();
            this.list_Devices = new DSkin.Controls.DSkinListBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_Devices)).BeginInit();
            this.SuspendLayout();
            // 
            // dSkinUserControl1
            // 
            this.dSkinUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinUserControl1.BitmapCache = false;
            this.dSkinUserControl1.Location = new System.Drawing.Point(770, 446);
            this.dSkinUserControl1.Name = "dSkinUserControl1";
            this.dSkinUserControl1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinUserControl1.RightBottom")));
            this.dSkinUserControl1.Size = new System.Drawing.Size(150, 150);
            this.dSkinUserControl1.TabIndex = 0;
            // 
            // btn_Query
            // 
            this.btn_Query.AdaptImage = true;
            this.btn_Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Query.BaseColor = System.Drawing.Color.DimGray;
            this.btn_Query.ButtonBorderColor = System.Drawing.Color.Gray;
            this.btn_Query.ButtonBorderWidth = 1;
            this.btn_Query.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Query.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Query.HoverColor = System.Drawing.Color.Gray;
            this.btn_Query.HoverImage = null;
            this.btn_Query.IsPureColor = true;
            this.btn_Query.Location = new System.Drawing.Point(597, 46);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.NormalImage = null;
            this.btn_Query.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Query.PressedImage = null;
            this.btn_Query.Radius = 10;
            this.btn_Query.RoundStyle = DSkin.Common.RoundStyle.None;
            this.btn_Query.ShowButtonBorder = true;
            this.btn_Query.Size = new System.Drawing.Size(78, 26);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "搜索";
            this.btn_Query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Query.TextPadding = 0;
            this.btn_Query.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // txt_Query
            // 
            this.txt_Query.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Query.BackColor = System.Drawing.Color.Silver;
            this.txt_Query.BitmapCache = false;
            this.txt_Query.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Query.Location = new System.Drawing.Point(96, 46);
            this.txt_Query.Name = "txt_Query";
            this.txt_Query.Size = new System.Drawing.Size(495, 26);
            this.txt_Query.TabIndex = 3;
            this.txt_Query.TransparencyKey = System.Drawing.Color.Empty;
            this.txt_Query.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_Query.WaterText = "设备名称 / 设备编号";
            this.txt_Query.WaterTextOffset = new System.Drawing.Point(2, 4);
            // 
            // list_Devices
            // 
            this.list_Devices.BackColor = System.Drawing.Color.Transparent;
            this.list_Devices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_Devices.ItemSize = new System.Drawing.Size(265, 185);
            this.list_Devices.Location = new System.Drawing.Point(4, 90);
            this.list_Devices.Margin = new System.Windows.Forms.Padding(0);
            this.list_Devices.Name = "list_Devices";
            this.list_Devices.ScrollBarWidth = 12;
            this.list_Devices.Size = new System.Drawing.Size(816, 566);
            this.list_Devices.SmoothScroll = true;
            this.list_Devices.SudokuPartitionWidth = new System.Windows.Forms.Padding(2);
            this.list_Devices.TabIndex = 5;
            this.list_Devices.Text = "dSkinListBox1";
            this.list_Devices.Ulmul = true;
            this.list_Devices.Value = 0D;
            // 
            // FrmLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(824, 660);
            this.CloseBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseBox.NormalColor = System.Drawing.Color.White;
            this.CloseBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Controls.Add(this.list_Devices);
            this.Controls.Add(this.btn_Query);
            this.Controls.Add(this.txt_Query);
            this.Controls.Add(this.dSkinUserControl1);
            this.DoubleClickMaximized = false;
            this.DrawIcon = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaxBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MaxBox.NormalColor = System.Drawing.Color.White;
            this.MaxBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MaximizeBox = false;
            this.MinBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinBox.NormalColor = System.Drawing.Color.White;
            this.MinBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MinimizeBox = false;
            this.Name = "FrmLeft";
            this.NormalBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.NormalBox.NormalColor = System.Drawing.Color.White;
            this.NormalBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowInTaskbar = false;
            this.ShowShadow = false;
            this.Text = "常用设备";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLeft_FormClosed);
            this.Load += new System.EventHandler(this.FrmLeft_Load);
            this.LocationChanged += new System.EventHandler(this.FrmLeft_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.list_Devices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinUserControl dSkinUserControl1;
        private DSkin.Controls.DSkinButton btn_Query;
        private DSkin.Controls.DSkinTextBox txt_Query;
        private DSkin.Controls.DSkinListBox list_Devices;
    }
}