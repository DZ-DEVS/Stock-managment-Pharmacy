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
            this.materialButton21 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(316, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(103, 108);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mot de Passe     :";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
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
            this.tb_password.Location = new System.Drawing.Point(354, 222);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(218, 50);
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
            this.tb_userName.Location = new System.Drawing.Point(354, 160);
            this.tb_userName.MaxLength = 50;
            this.tb_userName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_userName.Multiline = false;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(218, 50);
            this.tb_userName.TabIndex = 12;
            this.tb_userName.Text = "";
            this.tb_userName.TrailingIcon = null;
            // 
            // materialButton21
            // 
            this.materialButton21.AutoSize = false;
            this.materialButton21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton21.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton21.Depth = 0;
            this.materialButton21.HighEmphasis = false;
            this.materialButton21.Icon = null;
            this.materialButton21.Location = new System.Drawing.Point(418, 327);
            this.materialButton21.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton21.Name = "materialButton21";
            this.materialButton21.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton21.Size = new System.Drawing.Size(108, 36);
            this.materialButton21.TabIndex = 17;
            this.materialButton21.Text = "Annuler";
            this.materialButton21.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton21.UseAccentColor = false;
            this.materialButton21.UseVisualStyleBackColor = true;
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSize = false;
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(222, 327);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(168, 36);
            this.materialButton9.TabIndex = 18;
            this.materialButton9.Text = "Connecter";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(768, 387);
            this.Controls.Add(this.materialButton9);
            this.Controls.Add(this.materialButton21);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private MaterialSkin.Controls.MaterialButton materialButton21;
        private MaterialSkin.Controls.MaterialButton materialButton9;
    }
}