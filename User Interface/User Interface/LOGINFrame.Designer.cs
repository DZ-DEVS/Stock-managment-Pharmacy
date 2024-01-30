namespace User_Interface
{
    partial class LOGINFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINFrame));
            this.connectionBtn = new MaterialSkin.Controls.MaterialButton();
            this.tb_userName = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionBtn
            // 
            this.connectionBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectionBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.connectionBtn.Depth = 0;
            this.connectionBtn.HighEmphasis = true;
            this.connectionBtn.Icon = null;
            this.connectionBtn.Location = new System.Drawing.Point(358, 373);
            this.connectionBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.connectionBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectionBtn.Name = "connectionBtn";
            this.connectionBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.connectionBtn.Size = new System.Drawing.Size(107, 36);
            this.connectionBtn.TabIndex = 5;
            this.connectionBtn.Text = "connecter";
            this.connectionBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.connectionBtn.UseAccentColor = false;
            this.connectionBtn.UseVisualStyleBackColor = true;
            this.connectionBtn.Click += new System.EventHandler(this.connectionBtn_Click_1);
            // 
            // tb_userName
            // 
            this.tb_userName.AnimateReadOnly = false;
            this.tb_userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_userName.Depth = 0;
            this.tb_userName.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_userName.Hint = "Type here";
            this.tb_userName.LeadingIcon = null;
            this.tb_userName.Location = new System.Drawing.Point(302, 220);
            this.tb_userName.MaxLength = 50;
            this.tb_userName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_userName.Multiline = false;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(218, 50);
            this.tb_userName.TabIndex = 6;
            this.tb_userName.Text = "";
            this.tb_userName.TrailingIcon = null;
            // 
            // tb_password
            // 
            this.tb_password.AnimateReadOnly = false;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 12F);
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_password.Hint = "Password";
            this.tb_password.LeadingIcon = null;
            this.tb_password.Location = new System.Drawing.Point(302, 282);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(218, 50);
            this.tb_password.TabIndex = 7;
            this.tb_password.Text = "";
            this.tb_password.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome Utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mot de Passe :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(349, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(103, 108);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // LOGINFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.connectionBtn);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MinimizeBox = false;
            this.Name = "LOGINFrame";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SE CONNECTER";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton connectionBtn;
        private MaterialSkin.Controls.MaterialTextBox tb_userName;
        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

