namespace User_Interface.forms
{
    partial class frm_main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tab_control = new MaterialSkin.Controls.MaterialTabControl();
            this.tp_home = new System.Windows.Forms.TabPage();
            this.tp_list_stock = new System.Windows.Forms.TabPage();
            this.dgv_stocklist = new System.Windows.Forms.DataGridView();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.BTN_rechercher = new MaterialSkin.Controls.MaterialButton();
            this.tp_transaction = new System.Windows.Forms.TabPage();
            this.dgb_soldMed = new System.Windows.Forms.DataGridView();
            this.tp_admin = new System.Windows.Forms.TabPage();
            this.menuStrip_pageAdmin = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesDeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterMedicinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterGeniriqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJouterThérapeutiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tp_alert = new System.Windows.Forms.TabPage();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.lowSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outdatedMedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tab_control.SuspendLayout();
            this.tp_list_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stocklist)).BeginInit();
            this.tp_transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_soldMed)).BeginInit();
            this.tp_admin.SuspendLayout();
            this.menuStrip_pageAdmin.SuspendLayout();
            this.tp_alert.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.Controls.Add(this.tp_home);
            this.tab_control.Controls.Add(this.tp_list_stock);
            this.tab_control.Controls.Add(this.tp_transaction);
            this.tab_control.Controls.Add(this.tp_admin);
            this.tab_control.Controls.Add(this.tp_alert);
            this.tab_control.Depth = 0;
            this.tab_control.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tab_control.ImageList = this.imageList1;
            this.tab_control.Location = new System.Drawing.Point(3, 81);
            this.tab_control.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tab_control.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_control.Multiline = true;
            this.tab_control.Name = "tab_control";
            this.tab_control.Padding = new System.Drawing.Point(4, 5);
            this.tab_control.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1685, 977);
            this.tab_control.TabIndex = 0;
            this.tab_control.SelectedIndexChanged += new System.EventHandler(this.tab_control_SelectedIndexChanged);
            // 
            // tp_home
            // 
            this.tp_home.BackColor = System.Drawing.Color.White;
            this.tp_home.ImageKey = "home.png";
            this.tp_home.Location = new System.Drawing.Point(4, 43);
            this.tp_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_home.Name = "tp_home";
            this.tp_home.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.tp_home.Size = new System.Drawing.Size(1677, 930);
            this.tp_home.TabIndex = 0;
            this.tp_home.Text = "Accueil ";
            // 
            // tp_list_stock
            // 
            this.tp_list_stock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_list_stock.Controls.Add(this.dgv_stocklist);
            this.tp_list_stock.Controls.Add(this.materialTextBox1);
            this.tp_list_stock.Controls.Add(this.BTN_rechercher);
            this.tp_list_stock.ImageKey = "list.png";
            this.tp_list_stock.Location = new System.Drawing.Point(4, 43);
            this.tp_list_stock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_list_stock.Name = "tp_list_stock";
            this.tp_list_stock.Size = new System.Drawing.Size(1655, 930);
            this.tp_list_stock.TabIndex = 5;
            this.tp_list_stock.Text = "List de stock";
            // 
            // dgv_stocklist
            // 
            this.dgv_stocklist.AllowUserToAddRows = false;
            this.dgv_stocklist.AllowUserToDeleteRows = false;
            this.dgv_stocklist.AllowUserToOrderColumns = true;
            this.dgv_stocklist.AllowUserToResizeColumns = false;
            this.dgv_stocklist.AllowUserToResizeRows = false;
            this.dgv_stocklist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_stocklist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_stocklist.BackgroundColor = System.Drawing.Color.White;
            this.dgv_stocklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stocklist.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_stocklist.Location = new System.Drawing.Point(0, 268);
            this.dgv_stocklist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_stocklist.Name = "dgv_stocklist";
            this.dgv_stocklist.RowHeadersWidth = 51;
            this.dgv_stocklist.RowTemplate.Height = 24;
            this.dgv_stocklist.Size = new System.Drawing.Size(1603, 660);
            this.dgv_stocklist.TabIndex = 4;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BackColor = System.Drawing.Color.White;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(111, 28);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(332, 50);
            this.materialTextBox1.TabIndex = 3;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // BTN_rechercher
            // 
            this.BTN_rechercher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_rechercher.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_rechercher.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_rechercher.Depth = 0;
            this.BTN_rechercher.HighEmphasis = true;
            this.BTN_rechercher.Icon = null;
            this.BTN_rechercher.Location = new System.Drawing.Point(503, 36);
            this.BTN_rechercher.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_rechercher.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_rechercher.Name = "BTN_rechercher";
            this.BTN_rechercher.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_rechercher.Size = new System.Drawing.Size(115, 36);
            this.BTN_rechercher.TabIndex = 2;
            this.BTN_rechercher.Text = "rechercher";
            this.BTN_rechercher.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_rechercher.UseAccentColor = false;
            this.BTN_rechercher.UseVisualStyleBackColor = true;
            // 
            // tp_transaction
            // 
            this.tp_transaction.Controls.Add(this.dgb_soldMed);
            this.tp_transaction.ImageKey = "transaction.png";
            this.tp_transaction.Location = new System.Drawing.Point(4, 43);
            this.tp_transaction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_transaction.Name = "tp_transaction";
            this.tp_transaction.Size = new System.Drawing.Size(1655, 930);
            this.tp_transaction.TabIndex = 2;
            this.tp_transaction.Text = "Transaction";
            this.tp_transaction.UseVisualStyleBackColor = true;
            // 
            // dgb_soldMed
            // 
            this.dgb_soldMed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgb_soldMed.BackgroundColor = System.Drawing.Color.White;
            this.dgb_soldMed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgb_soldMed.Location = new System.Drawing.Point(3, 37);
            this.dgb_soldMed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgb_soldMed.Name = "dgb_soldMed";
            this.dgb_soldMed.RowHeadersWidth = 51;
            this.dgb_soldMed.RowTemplate.Height = 24;
            this.dgb_soldMed.Size = new System.Drawing.Size(1630, 897);
            this.dgb_soldMed.TabIndex = 0;
            // 
            // tp_admin
            // 
            this.tp_admin.BackColor = System.Drawing.Color.White;
            this.tp_admin.Controls.Add(this.menuStrip_pageAdmin);
            this.tp_admin.ImageKey = "admin.png";
            this.tp_admin.Location = new System.Drawing.Point(4, 43);
            this.tp_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_admin.Name = "tp_admin";
            this.tp_admin.Size = new System.Drawing.Size(1677, 930);
            this.tp_admin.TabIndex = 3;
            this.tp_admin.Text = "Page administration";
            // 
            // menuStrip_pageAdmin
            // 
            this.menuStrip_pageAdmin.AutoSize = false;
            this.menuStrip_pageAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip_pageAdmin.Font = new System.Drawing.Font("Poppins", 8F);
            this.menuStrip_pageAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_pageAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.eMPToolStripMenuItem});
            this.menuStrip_pageAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_pageAdmin.Name = "menuStrip_pageAdmin";
            this.menuStrip_pageAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip_pageAdmin.Size = new System.Drawing.Size(1677, 40);
            this.menuStrip_pageAdmin.TabIndex = 0;
            this.menuStrip_pageAdmin.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.listesDeEmployeeToolStripMenuItem});
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.aDMINToolStripMenuItem.Text = "Admin Tab";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter employee";
            // 
            // listesDeEmployeeToolStripMenuItem
            // 
            this.listesDeEmployeeToolStripMenuItem.Name = "listesDeEmployeeToolStripMenuItem";
            this.listesDeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.listesDeEmployeeToolStripMenuItem.Text = "Listes de employee";
            // 
            // eMPToolStripMenuItem
            // 
            this.eMPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterMedicinToolStripMenuItem,
            this.ajouterLabToolStripMenuItem,
            this.ajouterGeniriqueToolStripMenuItem,
            this.aJouterThérapeutiqueToolStripMenuItem});
            this.eMPToolStripMenuItem.Name = "eMPToolStripMenuItem";
            this.eMPToolStripMenuItem.Size = new System.Drawing.Size(118, 36);
            this.eMPToolStripMenuItem.Text = "EmployeTab";
            this.eMPToolStripMenuItem.Click += new System.EventHandler(this.eMPToolStripMenuItem_Click);
            // 
            // ajouterMedicinToolStripMenuItem
            // 
            this.ajouterMedicinToolStripMenuItem.Name = "ajouterMedicinToolStripMenuItem";
            this.ajouterMedicinToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.ajouterMedicinToolStripMenuItem.Text = "Ajouter Medicin";
            this.ajouterMedicinToolStripMenuItem.Click += new System.EventHandler(this.ajouterMedicinToolStripMenuItem_Click);
            // 
            // ajouterLabToolStripMenuItem
            // 
            this.ajouterLabToolStripMenuItem.Name = "ajouterLabToolStripMenuItem";
            this.ajouterLabToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.ajouterLabToolStripMenuItem.Text = "Ajouter Lab";
            // 
            // ajouterGeniriqueToolStripMenuItem
            // 
            this.ajouterGeniriqueToolStripMenuItem.Name = "ajouterGeniriqueToolStripMenuItem";
            this.ajouterGeniriqueToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.ajouterGeniriqueToolStripMenuItem.Text = "Ajouter Genirique";
            // 
            // aJouterThérapeutiqueToolStripMenuItem
            // 
            this.aJouterThérapeutiqueToolStripMenuItem.Name = "aJouterThérapeutiqueToolStripMenuItem";
            this.aJouterThérapeutiqueToolStripMenuItem.Size = new System.Drawing.Size(264, 30);
            this.aJouterThérapeutiqueToolStripMenuItem.Text = "AJouter thérapeutique";
            // 
            // tp_alert
            // 
            this.tp_alert.Controls.Add(this.menuStrip3);
            this.tp_alert.ImageKey = "danger.png";
            this.tp_alert.Location = new System.Drawing.Point(4, 43);
            this.tp_alert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_alert.Name = "tp_alert";
            this.tp_alert.Size = new System.Drawing.Size(1655, 930);
            this.tp_alert.TabIndex = 4;
            this.tp_alert.Text = "Alerts";
            this.tp_alert.UseVisualStyleBackColor = true;
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowSupplyToolStripMenuItem,
            this.outdatedMedToolStripMenuItem,
            this.autresToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip3.Size = new System.Drawing.Size(1655, 26);
            this.menuStrip3.TabIndex = 1;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // lowSupplyToolStripMenuItem
            // 
            this.lowSupplyToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lowSupplyToolStripMenuItem.Name = "lowSupplyToolStripMenuItem";
            this.lowSupplyToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lowSupplyToolStripMenuItem.Text = "low supply";
            // 
            // outdatedMedToolStripMenuItem
            // 
            this.outdatedMedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.outdatedMedToolStripMenuItem.Name = "outdatedMedToolStripMenuItem";
            this.outdatedMedToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.outdatedMedToolStripMenuItem.Text = "outdated med";
            // 
            // autresToolStripMenuItem
            // 
            this.autresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.autresToolStripMenuItem.Name = "autresToolStripMenuItem";
            this.autresToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.autresToolStripMenuItem.Text = "autres";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.White;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "admin.png");
            this.imageList1.Images.SetKeyName(2, "danger.png");
            this.imageList1.Images.SetKeyName(3, "list.png");
            this.imageList1.Images.SetKeyName(4, "management.png");
            this.imageList1.Images.SetKeyName(5, "transaction.png");
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1709, 1102);
            this.Controls.Add(this.tab_control);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tab_control;
            this.DrawerWidth = 400;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_main";
            this.Padding = new System.Windows.Forms.Padding(0, 79, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.tab_control.ResumeLayout(false);
            this.tp_list_stock.ResumeLayout(false);
            this.tp_list_stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stocklist)).EndInit();
            this.tp_transaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgb_soldMed)).EndInit();
            this.tp_admin.ResumeLayout(false);
            this.menuStrip_pageAdmin.ResumeLayout(false);
            this.menuStrip_pageAdmin.PerformLayout();
            this.tp_alert.ResumeLayout(false);
            this.tp_alert.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tab_control;
        private System.Windows.Forms.TabPage tp_home;
        private System.Windows.Forms.TabPage tp_transaction;
        private System.Windows.Forms.TabPage tp_admin;
        private System.Windows.Forms.TabPage tp_alert;
        private System.Windows.Forms.TabPage tp_list_stock;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialButton BTN_rechercher;
        private System.Windows.Forms.DataGridView dgv_stocklist;
        private System.Windows.Forms.DataGridView dgb_soldMed;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem lowSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outdatedMedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autresToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip_pageAdmin;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesDeEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterMedicinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterGeniriqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJouterThérapeutiqueToolStripMenuItem;
       
    }
}