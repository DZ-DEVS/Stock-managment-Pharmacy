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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tab_control = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tp_lowSupply = new System.Windows.Forms.TabPage();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel44 = new MaterialSkin.Controls.MaterialLabel();
            this.tp_expired_med = new System.Windows.Forms.TabPage();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tp_other = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tp_logout = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tab_control.SuspendLayout();
            this.tp_list_stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stocklist)).BeginInit();
            this.tp_transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgb_soldMed)).BeginInit();
            this.tp_admin.SuspendLayout();
            this.menuStrip_pageAdmin.SuspendLayout();
            this.tp_alert.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tp_lowSupply.SuspendLayout();
            this.tp_expired_med.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.Controls.Add(this.tabPage2);
            this.tab_control.Controls.Add(this.tabPage3);
            this.tab_control.Controls.Add(this.tp_home);
            this.tab_control.Controls.Add(this.tp_list_stock);
            this.tab_control.Controls.Add(this.tp_transaction);
            this.tab_control.Controls.Add(this.tp_admin);
            this.tab_control.Controls.Add(this.tp_alert);
            this.tab_control.Controls.Add(this.tabPage5);
            this.tab_control.Controls.Add(this.tp_logout);
            this.tab_control.Controls.Add(this.tabPage6);
            this.tab_control.Depth = 0;
            this.tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tab_control.ImageList = this.imageList1;
            this.tab_control.Location = new System.Drawing.Point(-2, 64);
            this.tab_control.Margin = new System.Windows.Forms.Padding(2);
            this.tab_control.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_control.Multiline = true;
            this.tab_control.Name = "tab_control";
            this.tab_control.Padding = new System.Drawing.Point(4, 5);
            this.tab_control.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1267, 784);
            this.tab_control.TabIndex = 0;
            this.tab_control.SelectedIndexChanged += new System.EventHandler(this.tab_control_SelectedIndexChanged);
            this.tab_control.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tab_control_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1259, 737);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1136, 694);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1136, 694);
            this.tabPage3.TabIndex = 8;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tp_home
            // 
            this.tp_home.BackColor = System.Drawing.Color.White;
            this.tp_home.ImageKey = "home.png";
            this.tp_home.Location = new System.Drawing.Point(4, 43);
            this.tp_home.Margin = new System.Windows.Forms.Padding(2);
            this.tp_home.Name = "tp_home";
            this.tp_home.Padding = new System.Windows.Forms.Padding(20);
            this.tp_home.Size = new System.Drawing.Size(1136, 694);
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
            this.tp_list_stock.Margin = new System.Windows.Forms.Padding(2);
            this.tp_list_stock.Name = "tp_list_stock";
            this.tp_list_stock.Size = new System.Drawing.Size(1136, 694);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_stocklist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_stocklist.Location = new System.Drawing.Point(0, 218);
            this.dgv_stocklist.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_stocklist.Name = "dgv_stocklist";
            this.dgv_stocklist.RowHeadersWidth = 51;
            this.dgv_stocklist.RowTemplate.Height = 24;
            this.dgv_stocklist.Size = new System.Drawing.Size(1242, 400);
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
            this.materialTextBox1.Location = new System.Drawing.Point(83, 23);
            this.materialTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(249, 50);
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
            this.BTN_rechercher.Location = new System.Drawing.Point(377, 29);
            this.BTN_rechercher.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.tp_transaction.Margin = new System.Windows.Forms.Padding(2);
            this.tp_transaction.Name = "tp_transaction";
            this.tp_transaction.Size = new System.Drawing.Size(1136, 694);
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
            this.dgb_soldMed.Location = new System.Drawing.Point(2, 30);
            this.dgb_soldMed.Margin = new System.Windows.Forms.Padding(2);
            this.dgb_soldMed.Name = "dgb_soldMed";
            this.dgb_soldMed.RowHeadersWidth = 51;
            this.dgb_soldMed.RowTemplate.Height = 24;
            this.dgb_soldMed.Size = new System.Drawing.Size(1282, 636);
            this.dgb_soldMed.TabIndex = 0;
            // 
            // tp_admin
            // 
            this.tp_admin.BackColor = System.Drawing.Color.White;
            this.tp_admin.Controls.Add(this.menuStrip_pageAdmin);
            this.tp_admin.ImageKey = "admin.png";
            this.tp_admin.Location = new System.Drawing.Point(4, 43);
            this.tp_admin.Margin = new System.Windows.Forms.Padding(2);
            this.tp_admin.Name = "tp_admin";
            this.tp_admin.Size = new System.Drawing.Size(1136, 694);
            this.tp_admin.TabIndex = 3;
            this.tp_admin.Text = "Page administration";
            // 
            // menuStrip_pageAdmin
            // 
            this.menuStrip_pageAdmin.AutoSize = false;
            this.menuStrip_pageAdmin.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip_pageAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.menuStrip_pageAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_pageAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.eMPToolStripMenuItem});
            this.menuStrip_pageAdmin.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_pageAdmin.Name = "menuStrip_pageAdmin";
            this.menuStrip_pageAdmin.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_pageAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip_pageAdmin.Size = new System.Drawing.Size(1136, 28);
            this.menuStrip_pageAdmin.TabIndex = 0;
            this.menuStrip_pageAdmin.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.listesDeEmployeeToolStripMenuItem});
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.aDMINToolStripMenuItem.Text = "Admin Tab";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter employee";
            // 
            // listesDeEmployeeToolStripMenuItem
            // 
            this.listesDeEmployeeToolStripMenuItem.Name = "listesDeEmployeeToolStripMenuItem";
            this.listesDeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
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
            this.eMPToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.eMPToolStripMenuItem.Text = "EmployeTab";
            this.eMPToolStripMenuItem.Click += new System.EventHandler(this.eMPToolStripMenuItem_Click);
            // 
            // ajouterMedicinToolStripMenuItem
            // 
            this.ajouterMedicinToolStripMenuItem.Name = "ajouterMedicinToolStripMenuItem";
            this.ajouterMedicinToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ajouterMedicinToolStripMenuItem.Text = "Ajouter Medicin";
            this.ajouterMedicinToolStripMenuItem.Click += new System.EventHandler(this.ajouterMedicinToolStripMenuItem_Click);
            // 
            // ajouterLabToolStripMenuItem
            // 
            this.ajouterLabToolStripMenuItem.Name = "ajouterLabToolStripMenuItem";
            this.ajouterLabToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ajouterLabToolStripMenuItem.Text = "Ajouter Lab";
            // 
            // ajouterGeniriqueToolStripMenuItem
            // 
            this.ajouterGeniriqueToolStripMenuItem.Name = "ajouterGeniriqueToolStripMenuItem";
            this.ajouterGeniriqueToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ajouterGeniriqueToolStripMenuItem.Text = "Ajouter Genirique";
            // 
            // aJouterThérapeutiqueToolStripMenuItem
            // 
            this.aJouterThérapeutiqueToolStripMenuItem.Name = "aJouterThérapeutiqueToolStripMenuItem";
            this.aJouterThérapeutiqueToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.aJouterThérapeutiqueToolStripMenuItem.Text = "AJouter thérapeutique";
            // 
            // tp_alert
            // 
            this.tp_alert.Controls.Add(this.materialTabControl2);
            this.tp_alert.Controls.Add(this.materialTabSelector1);
            this.tp_alert.ImageKey = "danger.png";
            this.tp_alert.Location = new System.Drawing.Point(4, 43);
            this.tp_alert.Margin = new System.Windows.Forms.Padding(2);
            this.tp_alert.Name = "tp_alert";
            this.tp_alert.Size = new System.Drawing.Size(1136, 694);
            this.tp_alert.TabIndex = 4;
            this.tp_alert.Text = "Alerts";
            this.tp_alert.UseVisualStyleBackColor = true;
            // 
            // materialTabControl2
            // 
            this.materialTabControl2.Controls.Add(this.tp_lowSupply);
            this.materialTabControl2.Controls.Add(this.tp_expired_med);
            this.materialTabControl2.Controls.Add(this.tp_other);
            this.materialTabControl2.Depth = 0;
            this.materialTabControl2.ImageList = this.imageList1;
            this.materialTabControl2.Location = new System.Drawing.Point(0, 62);
            this.materialTabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(877, 333);
            this.materialTabControl2.TabIndex = 25;
            // 
            // tp_lowSupply
            // 
            this.tp_lowSupply.BackColor = System.Drawing.Color.White;
            this.tp_lowSupply.Controls.Add(this.materialLabel45);
            this.tp_lowSupply.Controls.Add(this.materialLabel44);
            this.tp_lowSupply.ImageKey = "product.png";
            this.tp_lowSupply.Location = new System.Drawing.Point(4, 39);
            this.tp_lowSupply.Name = "tp_lowSupply";
            this.tp_lowSupply.Padding = new System.Windows.Forms.Padding(3);
            this.tp_lowSupply.Size = new System.Drawing.Size(869, 290);
            this.tp_lowSupply.TabIndex = 0;
            this.tp_lowSupply.Text = "approv Insuffisant";
            // 
            // materialLabel45
            // 
            this.materialLabel45.AutoSize = true;
            this.materialLabel45.Depth = 0;
            this.materialLabel45.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel45.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel45.HighEmphasis = true;
            this.materialLabel45.Location = new System.Drawing.Point(15, 14);
            this.materialLabel45.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel45.Name = "materialLabel45";
            this.materialLabel45.Size = new System.Drawing.Size(174, 24);
            this.materialLabel45.TabIndex = 4;
            this.materialLabel45.Text = "Tabs are supported";
            // 
            // materialLabel44
            // 
            this.materialLabel44.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel44.Depth = 0;
            this.materialLabel44.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel44.Location = new System.Drawing.Point(15, 55);
            this.materialLabel44.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel44.Name = "materialLabel44";
            this.materialLabel44.Size = new System.Drawing.Size(832, 217);
            this.materialLabel44.TabIndex = 3;
            this.materialLabel44.Text = "However, in accordance with the Material Design principles, tabs should NOT be us" +
    "ed together with the Drawer menu, chose one or the other :)\r\n\r\nTry \'em!";
            // 
            // tp_expired_med
            // 
            this.tp_expired_med.BackColor = System.Drawing.Color.White;
            this.tp_expired_med.Controls.Add(this.materialLabel10);
            this.tp_expired_med.Location = new System.Drawing.Point(4, 39);
            this.tp_expired_med.Name = "tp_expired_med";
            this.tp_expired_med.Padding = new System.Windows.Forms.Padding(3);
            this.tp_expired_med.Size = new System.Drawing.Size(869, 290);
            this.tp_expired_med.TabIndex = 1;
            this.tp_expired_med.Text = "médicaments expirés";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.HighEmphasis = true;
            this.materialLabel10.Location = new System.Drawing.Point(6, 7);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(475, 58);
            this.materialLabel10.TabIndex = 1;
            this.materialLabel10.Text = "Everything is possible!";
            this.materialLabel10.UseAccent = true;
            // 
            // tp_other
            // 
            this.tp_other.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_other.Location = new System.Drawing.Point(4, 39);
            this.tp_other.Name = "tp_other";
            this.tp_other.Size = new System.Drawing.Size(869, 290);
            this.tp_other.TabIndex = 2;
            this.tp_other.Text = "Autre";
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
            this.imageList1.Images.SetKeyName(6, "product.png");
            this.imageList1.Images.SetKeyName(7, "exit.png");
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.White;
            this.materialTabSelector1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialTabSelector1.BackgroundImage")));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl2;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(4, 0);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1092, 38);
            this.materialTabSelector1.TabIndex = 26;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 43);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1136, 694);
            this.tabPage5.TabIndex = 10;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tp_logout
            // 
            this.tp_logout.BackColor = System.Drawing.Color.White;
            this.tp_logout.ImageKey = "exit.png";
            this.tp_logout.Location = new System.Drawing.Point(4, 43);
            this.tp_logout.Name = "tp_logout";
            this.tp_logout.Size = new System.Drawing.Size(1136, 694);
            this.tp_logout.TabIndex = 12;
            this.tp_logout.Text = "Se déconnecter";
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 43);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1136, 694);
            this.tabPage6.TabIndex = 13;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1269, 615);
            this.Controls.Add(this.tab_control);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tab_control;
            this.DrawerWidth = 400;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_main";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 2, 2);
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
            this.materialTabControl2.ResumeLayout(false);
            this.tp_lowSupply.ResumeLayout(false);
            this.tp_lowSupply.PerformLayout();
            this.tp_expired_med.ResumeLayout(false);
            this.tp_expired_med.PerformLayout();
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
        private MaterialSkin.Controls.MaterialTabControl materialTabControl2;
        private System.Windows.Forms.TabPage tp_lowSupply;
        private MaterialSkin.Controls.MaterialLabel materialLabel45;
        private MaterialSkin.Controls.MaterialLabel materialLabel44;
        private System.Windows.Forms.TabPage tp_expired_med;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.TabPage tp_other;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tp_logout;
        private System.Windows.Forms.TabPage tabPage6;
    }
}