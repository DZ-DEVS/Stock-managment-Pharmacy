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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINFrame));
            this.UsernameTB = new MaterialSkin.Controls.MaterialTextBox();
            this.PassTB = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.connectionBtn = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameTB
            // 
            this.UsernameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UsernameTB.AnimateReadOnly = false;
            this.UsernameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTB.Depth = 0;
            this.UsernameTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UsernameTB.LeadingIcon = null;
            this.UsernameTB.Location = new System.Drawing.Point(403, 271);
            this.UsernameTB.MaxLength = 50;
            this.UsernameTB.MouseState = MaterialSkin.MouseState.OUT;
            this.UsernameTB.Multiline = false;
            this.UsernameTB.Name = "UsernameTB";
            this.UsernameTB.Size = new System.Drawing.Size(290, 50);
            this.UsernameTB.TabIndex = 0;
            this.UsernameTB.Text = "";
            this.UsernameTB.TrailingIcon = null;
            // 
            // PassTB
            // 
            this.PassTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PassTB.AnimateReadOnly = false;
            this.PassTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTB.Depth = 0;
            this.PassTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PassTB.LeadingIcon = null;
            this.PassTB.Location = new System.Drawing.Point(403, 380);
            this.PassTB.MaxLength = 50;
            this.PassTB.MouseState = MaterialSkin.MouseState.OUT;
            this.PassTB.Multiline = false;
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(290, 50);
            this.PassTB.TabIndex = 1;
            this.PassTB.Text = "";
            this.PassTB.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(208, 283);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(127, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "nom d\'ustilisateur";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(247, 397);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "mot de pass";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(461, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 175);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // connectionBtn
            // 
            this.connectionBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connectionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectionBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.connectionBtn.Depth = 0;
            this.connectionBtn.HighEmphasis = true;
            this.connectionBtn.Icon = null;
            this.connectionBtn.Location = new System.Drawing.Point(478, 494);
            this.connectionBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
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
            // LOGINFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.connectionBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UsernameTB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LOGINFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox UsernameTB;
        private MaterialSkin.Controls.MaterialTextBox PassTB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton connectionBtn;
    }
}

