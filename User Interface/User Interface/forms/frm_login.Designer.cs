namespace User_Interface
{
    partial class frm_login
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_userName = new MaterialSkin.Controls.MaterialTextBox();
            this.BTN_Annuler = new MaterialSkin.Controls.MaterialButton();
            this.BTN_Connecter = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(498, 105);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(150, 150);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mot de Passe     :";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome Utilisateur :";
            this.label1.UseWaitCursor = true;
            // 
            // tb_password
            // 
            this.tb_password.AnimateReadOnly = false;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_password.Hint = "Password";
            this.tb_password.LeadingIcon = null;
            this.tb_password.Location = new System.Drawing.Point(538, 410);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(272, 50);
            this.tb_password.TabIndex = 13;
            this.tb_password.Text = "";
            this.tb_password.TrailingIcon = null;
            // 
            // tb_userName
            // 
            this.tb_userName.AnimateReadOnly = false;
            this.tb_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_userName.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tb_userName.Depth = 0;
            this.tb_userName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_userName.Hint = "Tapez ici";
            this.tb_userName.LeadingIcon = null;
            this.tb_userName.Location = new System.Drawing.Point(538, 332);
            this.tb_userName.Margin = new System.Windows.Forms.Padding(4);
            this.tb_userName.MaxLength = 50;
            this.tb_userName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_userName.Multiline = false;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(272, 50);
            this.tb_userName.TabIndex = 12;
            this.tb_userName.Text = "";
            this.tb_userName.TrailingIcon = null;
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.AutoSize = false;
            this.BTN_Annuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Annuler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Annuler.Depth = 0;
            this.BTN_Annuler.HighEmphasis = false;
            this.BTN_Annuler.Icon = null;
            this.BTN_Annuler.Location = new System.Drawing.Point(591, 528);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BTN_Annuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Annuler.Size = new System.Drawing.Size(135, 45);
            this.BTN_Annuler.TabIndex = 17;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Annuler.UseAccentColor = false;
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // BTN_Connecter
            // 
            this.BTN_Connecter.AutoSize = false;
            this.BTN_Connecter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Connecter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Connecter.Depth = 0;
            this.BTN_Connecter.HighEmphasis = true;
            this.BTN_Connecter.Icon = null;
            this.BTN_Connecter.Location = new System.Drawing.Point(347, 528);
            this.BTN_Connecter.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.BTN_Connecter.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Connecter.Name = "BTN_Connecter";
            this.BTN_Connecter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Connecter.Size = new System.Drawing.Size(210, 45);
            this.BTN_Connecter.TabIndex = 18;
            this.BTN_Connecter.Text = "Connecter";
            this.BTN_Connecter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Connecter.UseAccentColor = false;
            this.BTN_Connecter.UseVisualStyleBackColor = true;
            this.BTN_Connecter.Click += new System.EventHandler(this.BTN_Connecter_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1132, 623);
            this.Controls.Add(this.BTN_Connecter);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.Text = "frm_login";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private MaterialSkin.Controls.MaterialTextBox tb_userName;
        private MaterialSkin.Controls.MaterialButton BTN_Annuler;
        private MaterialSkin.Controls.MaterialButton BTN_Connecter;
    }
}