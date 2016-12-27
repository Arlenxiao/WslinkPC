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
            // FrmLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(824, 660);
            this.CloseBox.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseBox.NormalColor = System.Drawing.Color.White;
            this.CloseBox.PressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
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
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinUserControl dSkinUserControl1;
    }
}