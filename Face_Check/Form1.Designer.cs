namespace Face_Check
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_link = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Check = new Guna.UI2.WinForms.Guna2Button();
            this.lb_SL = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.txt_chuyen = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Stop = new Guna.UI2.WinForms.Guna2Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LB_NOFACE = new System.Windows.Forms.Label();
            this.imgg_Success = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_Xoa = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txt_link
            // 
            this.txt_link.BorderRadius = 10;
            this.txt_link.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_link.DefaultText = "";
            this.txt_link.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_link.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_link.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_link.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_link.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_link.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_link.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_link.Location = new System.Drawing.Point(127, 103);
            this.txt_link.Name = "txt_link";
            this.txt_link.PasswordChar = '\0';
            this.txt_link.PlaceholderText = "Đường dẫn tới thư mục ảnh";
            this.txt_link.SelectedText = "";
            this.txt_link.Size = new System.Drawing.Size(200, 45);
            this.txt_link.TabIndex = 0;
            // 
            // btn_Check
            // 
            this.btn_Check.BorderRadius = 10;
            this.btn_Check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Check.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Check.ForeColor = System.Drawing.Color.White;
            this.btn_Check.Location = new System.Drawing.Point(121, 29);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(109, 45);
            this.btn_Check.TabIndex = 1;
            this.btn_Check.Text = "Check";
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // lb_SL
            // 
            this.lb_SL.AutoSize = true;
            this.lb_SL.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_SL.Location = new System.Drawing.Point(561, 118);
            this.lb_SL.Name = "lb_SL";
            this.lb_SL.Size = new System.Drawing.Size(34, 30);
            this.lb_SL.TabIndex = 3;
            this.lb_SL.Text = "SL";
            // 
            // progressBar
            // 
            this.progressBar.BorderRadius = 10;
            this.progressBar.Location = new System.Drawing.Point(249, 36);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.progressBar.ShadowDecoration.BorderRadius = 10;
            this.progressBar.ShowText = true;
            this.progressBar.Size = new System.Drawing.Size(300, 30);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 4;
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.progressBar.Value = 50;
            // 
            // txt_chuyen
            // 
            this.txt_chuyen.BorderRadius = 10;
            this.txt_chuyen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_chuyen.DefaultText = "";
            this.txt_chuyen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_chuyen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_chuyen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_chuyen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_chuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_chuyen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_chuyen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_chuyen.Location = new System.Drawing.Point(333, 103);
            this.txt_chuyen.Name = "txt_chuyen";
            this.txt_chuyen.PasswordChar = '\0';
            this.txt_chuyen.PlaceholderText = "Đường dẫn tới thư mục ảnh";
            this.txt_chuyen.SelectedText = "";
            this.txt_chuyen.Size = new System.Drawing.Size(200, 45);
            this.txt_chuyen.TabIndex = 5;
            // 
            // btn_Stop
            // 
            this.btn_Stop.BorderRadius = 10;
            this.btn_Stop.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Stop.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Stop.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Stop.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Stop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Stop.ForeColor = System.Drawing.Color.White;
            this.btn_Stop.Location = new System.Drawing.Point(566, 29);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(109, 45);
            this.btn_Stop.TabIndex = 6;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            // 
            // LB_NOFACE
            // 
            this.LB_NOFACE.AutoSize = true;
            this.LB_NOFACE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_NOFACE.ForeColor = System.Drawing.Color.Red;
            this.LB_NOFACE.Location = new System.Drawing.Point(644, 122);
            this.LB_NOFACE.Name = "LB_NOFACE";
            this.LB_NOFACE.Size = new System.Drawing.Size(31, 25);
            this.LB_NOFACE.TabIndex = 7;
            this.LB_NOFACE.Text = "SL";
            // 
            // imgg_Success
            // 
            this.imgg_Success.AnimatedGIF = true;
            this.imgg_Success.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgg_Success.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgg_Success.Image = global::Face_Check.Properties.Resources.check_5610944;
            this.imgg_Success.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgg_Success.ImageRotate = 0F;
            this.imgg_Success.Location = new System.Drawing.Point(579, 15);
            this.imgg_Success.Name = "imgg_Success";
            this.imgg_Success.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imgg_Success.Size = new System.Drawing.Size(80, 67);
            this.imgg_Success.TabIndex = 8;
            this.imgg_Success.Visible = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::Face_Check.Properties.Resources.face_scanner_7974361;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(12, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(92, 72);
            this.guna2ImageButton1.TabIndex = 2;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BorderRadius = 10;
            this.btn_Xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(12, 104);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(109, 45);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 169);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.imgg_Success);
            this.Controls.Add(this.LB_NOFACE);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.txt_chuyen);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lb_SL);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.txt_link);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.Name = "Form1";
            this.Text = "Face Check V1.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_link;
        private Guna.UI2.WinForms.Guna2Button btn_Check;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label lb_SL;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2TextBox txt_chuyen;
        private Guna.UI2.WinForms.Guna2Button btn_Stop;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label LB_NOFACE;
        private Guna.UI2.WinForms.Guna2ImageButton imgg_Success;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa;
    }
}

