﻿using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.tab_control = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tp_home = new System.Windows.Forms.TabPage();
            this.tp_list_stock = new System.Windows.Forms.TabPage();
            this.btn_deleteText = new System.Windows.Forms.Button();
            this.btn_stocklist = new System.Windows.Forms.Button();
            this.lb_pageIndex = new System.Windows.Forms.Label();
            this.btn_previou_s = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lv_listStock = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_search = new MaterialSkin.Controls.MaterialTextBox();
            this.BTN_rechercher = new MaterialSkin.Controls.MaterialButton();
            this.tp_StockQts = new System.Windows.Forms.TabPage();
            this.tp_admin = new System.Windows.Forms.TabPage();
            this.materialTabSelector2 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tp_admin_second = new MaterialSkin.Controls.MaterialTabControl();
            this.tp_employee = new System.Windows.Forms.TabPage();
            this.card_employee = new MaterialSkin.Controls.MaterialCard();
            this.btn_Useranuller = new MaterialSkin.Controls.MaterialButton();
            this.BTN_ajouterPerso = new MaterialSkin.Controls.MaterialButton();
            this.panel_add_employee = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox_role = new System.Windows.Forms.GroupBox();
            this.rb_remb_emp = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_rembo_admin = new MaterialSkin.Controls.MaterialRadioButton();
            this.tb_conPass = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_motpass = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_username = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_prenom = new MaterialSkin.Controls.MaterialTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_Nom = new MaterialSkin.Controls.MaterialTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tp_lab = new System.Windows.Forms.TabPage();
            this.card_lab = new MaterialSkin.Controls.MaterialCard();
            this.panel_lab = new System.Windows.Forms.Panel();
            this.cb_pay = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_webAdress = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_phone = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_adress = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_codeLab = new MaterialSkin.Controls.MaterialTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tb_nomLab = new MaterialSkin.Controls.MaterialTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_addLab = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.tp_produit = new System.Windows.Forms.TabPage();
            this.card_produit = new MaterialSkin.Controls.MaterialCard();
            this.panel_add_med = new System.Windows.Forms.Panel();
            this.tb_conditionemnt = new MaterialSkin.Controls.MaterialTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_Dci = new MaterialSkin.Controls.MaterialComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_classThera = new MaterialSkin.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_classPharma = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_lab = new System.Windows.Forms.Label();
            this.cb_lab = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_ppa = new MaterialSkin.Controls.MaterialTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_tarif = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gb_rembo = new System.Windows.Forms.GroupBox();
            this.rb_non_remborsable = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_remborsable = new MaterialSkin.Controls.MaterialRadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gb_comm = new System.Windows.Forms.GroupBox();
            this.rb_comme_No = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_comme_Oui = new MaterialSkin.Controls.MaterialRadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.gb_list = new System.Windows.Forms.GroupBox();
            this.rb_list3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_list2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_list1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.type_non_generique = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_type_generique = new MaterialSkin.Controls.MaterialRadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.cb_pays = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_dossage = new MaterialSkin.Controls.MaterialTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_form = new MaterialSkin.Controls.MaterialTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_NomMed = new MaterialSkin.Controls.MaterialTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_refMed = new MaterialSkin.Controls.MaterialTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton5 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.panel_listkhdamin = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tp_alert = new System.Windows.Forms.TabPage();
            this.materialTabControl2 = new MaterialSkin.Controls.MaterialTabControl();
            this.tp_lowSupply = new System.Windows.Forms.TabPage();
            this.materialLabel45 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel44 = new MaterialSkin.Controls.MaterialLabel();
            this.tp_expired_med = new System.Windows.Forms.TabPage();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tp_other = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.tp_settings = new System.Windows.Forms.TabPage();
            this.materialTabSelector3 = new MaterialSkin.Controls.MaterialTabSelector();
            this.settins_tabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.card_settings = new MaterialSkin.Controls.MaterialCard();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_darkTheme = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton5 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tp_logout = new System.Windows.Forms.TabPage();
            this.btn_clear_tbStock = new System.Windows.Forms.Button();
            this.btn_updateListStocksQts = new System.Windows.Forms.Button();
            this.lb_nbrPagesStockQts = new System.Windows.Forms.Label();
            this.btn_previusStock = new System.Windows.Forms.Button();
            this.btn_next_Stock = new System.Windows.Forms.Button();
            this.ListV_StockQts = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_searchStock = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_searchStock = new MaterialSkin.Controls.MaterialButton();
            this.tab_control.SuspendLayout();
            this.tp_list_stock.SuspendLayout();
            this.tp_StockQts.SuspendLayout();
            this.tp_admin.SuspendLayout();
            this.tp_admin_second.SuspendLayout();
            this.tp_employee.SuspendLayout();
            this.card_employee.SuspendLayout();
            this.panel_add_employee.SuspendLayout();
            this.groupBox_role.SuspendLayout();
            this.tp_lab.SuspendLayout();
            this.card_lab.SuspendLayout();
            this.panel_lab.SuspendLayout();
            this.tp_produit.SuspendLayout();
            this.card_produit.SuspendLayout();
            this.panel_add_med.SuspendLayout();
            this.gb_rembo.SuspendLayout();
            this.gb_comm.SuspendLayout();
            this.gb_list.SuspendLayout();
            this.gb_type.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tp_alert.SuspendLayout();
            this.materialTabControl2.SuspendLayout();
            this.tp_lowSupply.SuspendLayout();
            this.tp_expired_med.SuspendLayout();
            this.tp_settings.SuspendLayout();
            this.settins_tabcontrol.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.card_settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage8.SuspendLayout();
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
            this.tab_control.Controls.Add(this.tp_StockQts);
            this.tab_control.Controls.Add(this.tp_admin);
            this.tab_control.Controls.Add(this.tp_alert);
            this.tab_control.Controls.Add(this.tp_settings);
            this.tab_control.Controls.Add(this.tabPage6);
            this.tab_control.Controls.Add(this.tabPage4);
            this.tab_control.Controls.Add(this.tabPage7);
            this.tab_control.Controls.Add(this.tp_logout);
            this.tab_control.Depth = 0;
            this.tab_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tab_control.ImageList = this.imageList1;
            this.tab_control.Location = new System.Drawing.Point(2, 66);
            this.tab_control.Margin = new System.Windows.Forms.Padding(2);
            this.tab_control.MouseState = MaterialSkin.MouseState.HOVER;
            this.tab_control.Multiline = true;
            this.tab_control.Name = "tab_control";
            this.tab_control.Padding = new System.Drawing.Point(4, 5);
            this.tab_control.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1359, 1000);
            this.tab_control.TabIndex = 0;
            this.tab_control.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tab_control_Selecting);
            this.tab_control.Click += new System.EventHandler(this.Rb_darkTheme_CheckedChanged);
            this.tab_control.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tab_control_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 43);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1351, 953);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 43);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1351, 953);
            this.tabPage2.TabIndex = 7;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 43);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1351, 953);
            this.tabPage3.TabIndex = 8;
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
            this.tp_home.Size = new System.Drawing.Size(1351, 953);
            this.tp_home.TabIndex = 0;
            this.tp_home.Text = "Accueil ";
            // 
            // tp_list_stock
            // 
            this.tp_list_stock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tp_list_stock.Controls.Add(this.btn_deleteText);
            this.tp_list_stock.Controls.Add(this.btn_stocklist);
            this.tp_list_stock.Controls.Add(this.lb_pageIndex);
            this.tp_list_stock.Controls.Add(this.btn_previou_s);
            this.tp_list_stock.Controls.Add(this.btn_next);
            this.tp_list_stock.Controls.Add(this.lv_listStock);
            this.tp_list_stock.Controls.Add(this.tb_search);
            this.tp_list_stock.Controls.Add(this.BTN_rechercher);
            this.tp_list_stock.ImageKey = "list.png";
            this.tp_list_stock.Location = new System.Drawing.Point(4, 43);
            this.tp_list_stock.Margin = new System.Windows.Forms.Padding(2);
            this.tp_list_stock.Name = "tp_list_stock";
            this.tp_list_stock.Size = new System.Drawing.Size(1351, 953);
            this.tp_list_stock.TabIndex = 5;
            this.tp_list_stock.Text = "List de Produit";
            // 
            // btn_deleteText
            // 
            this.btn_deleteText.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteText.FlatAppearance.BorderSize = 0;
            this.btn_deleteText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteText.Image = global::User_Interface.Properties.Resources.remove;
            this.btn_deleteText.Location = new System.Drawing.Point(322, 28);
            this.btn_deleteText.Name = "btn_deleteText";
            this.btn_deleteText.Size = new System.Drawing.Size(33, 33);
            this.btn_deleteText.TabIndex = 112;
            this.btn_deleteText.UseVisualStyleBackColor = false;
            this.btn_deleteText.Visible = false;
            this.btn_deleteText.Click += new System.EventHandler(this.btn_deleteText_Click);
            // 
            // btn_stocklist
            // 
            this.btn_stocklist.BackColor = System.Drawing.Color.Transparent;
            this.btn_stocklist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stocklist.Image = global::User_Interface.Properties.Resources.refresh;
            this.btn_stocklist.Location = new System.Drawing.Point(700, 74);
            this.btn_stocklist.Name = "btn_stocklist";
            this.btn_stocklist.Size = new System.Drawing.Size(33, 33);
            this.btn_stocklist.TabIndex = 111;
            this.btn_stocklist.UseVisualStyleBackColor = false;
            this.btn_stocklist.Click += new System.EventHandler(this.btn_stocklist_Click);
            // 
            // lb_pageIndex
            // 
            this.lb_pageIndex.AutoSize = true;
            this.lb_pageIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pageIndex.ForeColor = System.Drawing.Color.DimGray;
            this.lb_pageIndex.Location = new System.Drawing.Point(505, 80);
            this.lb_pageIndex.Name = "lb_pageIndex";
            this.lb_pageIndex.Size = new System.Drawing.Size(35, 21);
            this.lb_pageIndex.TabIndex = 110;
            this.lb_pageIndex.Text = "2/3";
            // 
            // btn_previou_s
            // 
            this.btn_previou_s.FlatAppearance.BorderSize = 0;
            this.btn_previou_s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previou_s.Image = global::User_Interface.Properties.Resources.back;
            this.btn_previou_s.Location = new System.Drawing.Point(450, 73);
            this.btn_previou_s.Name = "btn_previou_s";
            this.btn_previou_s.Size = new System.Drawing.Size(34, 34);
            this.btn_previou_s.TabIndex = 109;
            this.btn_previou_s.UseVisualStyleBackColor = true;
            this.btn_previou_s.Click += new System.EventHandler(this.btn_previou_s_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Image = global::User_Interface.Properties.Resources.next__1_;
            this.btn_next.Location = new System.Drawing.Point(556, 72);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(39, 34);
            this.btn_next.TabIndex = 108;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lv_listStock
            // 
            this.lv_listStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_listStock.AutoSizeTable = false;
            this.lv_listStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_listStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_listStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lv_listStock.Depth = 0;
            this.lv_listStock.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_listStock.ForeColor = System.Drawing.SystemColors.Info;
            this.lv_listStock.FullRowSelect = true;
            this.lv_listStock.HideSelection = false;
            this.lv_listStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lv_listStock.Location = new System.Drawing.Point(16, 115);
            this.lv_listStock.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_listStock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_listStock.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_listStock.Name = "lv_listStock";
            this.lv_listStock.OwnerDraw = true;
            this.lv_listStock.Scrollable = false;
            this.lv_listStock.Size = new System.Drawing.Size(1314, 482);
            this.lv_listStock.TabIndex = 107;
            this.lv_listStock.UseCompatibleStateImageBehavior = false;
            this.lv_listStock.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Designation:";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Laboratoire";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "C.Thérapeutique";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "C.Pharmacologique";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Locale";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Remboursable";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tarif";
            this.columnHeader9.Width = 90;
            // 
            // tb_search
            // 
            this.tb_search.AnimateReadOnly = false;
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_search.Depth = 0;
            this.tb_search.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_search.Hint = "tapez ici...";
            this.tb_search.LeadingIcon = null;
            this.tb_search.Location = new System.Drawing.Point(16, 29);
            this.tb_search.MaxLength = 50;
            this.tb_search.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_search.Multiline = false;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(300, 36);
            this.tb_search.TabIndex = 106;
            this.tb_search.Text = "";
            this.tb_search.TrailingIcon = null;
            this.tb_search.UseTallSize = false;
            this.tb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_search_KeyPress);
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
            this.BTN_rechercher.Click += new System.EventHandler(this.BTN_rechercher_Click);
            // 
            // tp_StockQts
            // 
            this.tp_StockQts.Controls.Add(this.btn_clear_tbStock);
            this.tp_StockQts.Controls.Add(this.btn_updateListStocksQts);
            this.tp_StockQts.Controls.Add(this.lb_nbrPagesStockQts);
            this.tp_StockQts.Controls.Add(this.btn_previusStock);
            this.tp_StockQts.Controls.Add(this.btn_next_Stock);
            this.tp_StockQts.Controls.Add(this.ListV_StockQts);
            this.tp_StockQts.Controls.Add(this.tb_searchStock);
            this.tp_StockQts.Controls.Add(this.btn_searchStock);
            this.tp_StockQts.ImageKey = "in-stock (1).png";
            this.tp_StockQts.Location = new System.Drawing.Point(4, 43);
            this.tp_StockQts.Margin = new System.Windows.Forms.Padding(2);
            this.tp_StockQts.Name = "tp_StockQts";
            this.tp_StockQts.Size = new System.Drawing.Size(1351, 953);
            this.tp_StockQts.TabIndex = 2;
            this.tp_StockQts.Text = "List de Stock ";
            this.tp_StockQts.UseVisualStyleBackColor = true;
            // 
            // tp_admin
            // 
            this.tp_admin.BackColor = System.Drawing.Color.White;
            this.tp_admin.Controls.Add(this.materialTabSelector2);
            this.tp_admin.Controls.Add(this.tp_admin_second);
            this.tp_admin.ImageKey = "admin.png";
            this.tp_admin.Location = new System.Drawing.Point(4, 43);
            this.tp_admin.Margin = new System.Windows.Forms.Padding(2);
            this.tp_admin.Name = "tp_admin";
            this.tp_admin.Size = new System.Drawing.Size(1351, 953);
            this.tp_admin.TabIndex = 3;
            this.tp_admin.Text = "Page administration";
            // 
            // materialTabSelector2
            // 
            this.materialTabSelector2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector2.BackColor = System.Drawing.Color.White;
            this.materialTabSelector2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialTabSelector2.BackgroundImage")));
            this.materialTabSelector2.BaseTabControl = this.tp_admin_second;
            this.materialTabSelector2.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector2.Depth = 0;
            this.materialTabSelector2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector2.Location = new System.Drawing.Point(-6, 0);
            this.materialTabSelector2.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector2.Name = "materialTabSelector2";
            this.materialTabSelector2.Size = new System.Drawing.Size(1452, 38);
            this.materialTabSelector2.TabIndex = 27;
            this.materialTabSelector2.Text = "materialTabSelector2";
            // 
            // tp_admin_second
            // 
            this.tp_admin_second.Controls.Add(this.tp_employee);
            this.tp_admin_second.Controls.Add(this.tp_lab);
            this.tp_admin_second.Controls.Add(this.tp_produit);
            this.tp_admin_second.Controls.Add(this.tabPage10);
            this.tp_admin_second.Depth = 0;
            this.tp_admin_second.ImageList = this.imageList1;
            this.tp_admin_second.Location = new System.Drawing.Point(0, 38);
            this.tp_admin_second.Margin = new System.Windows.Forms.Padding(0);
            this.tp_admin_second.MouseState = MaterialSkin.MouseState.HOVER;
            this.tp_admin_second.Multiline = true;
            this.tp_admin_second.Name = "tp_admin_second";
            this.tp_admin_second.SelectedIndex = 0;
            this.tp_admin_second.Size = new System.Drawing.Size(1274, 641);
            this.tp_admin_second.TabIndex = 26;
            this.tp_admin_second.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.Tp_admin_second_Selecting);
            // 
            // tp_employee
            // 
            this.tp_employee.BackColor = System.Drawing.Color.White;
            this.tp_employee.Controls.Add(this.card_employee);
            this.tp_employee.Location = new System.Drawing.Point(4, 39);
            this.tp_employee.Name = "tp_employee";
            this.tp_employee.Padding = new System.Windows.Forms.Padding(3);
            this.tp_employee.Size = new System.Drawing.Size(1266, 598);
            this.tp_employee.TabIndex = 1;
            this.tp_employee.Text = "Ajouter un Employee";
            // 
            // card_employee
            // 
            this.card_employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_employee.Controls.Add(this.btn_Useranuller);
            this.card_employee.Controls.Add(this.BTN_ajouterPerso);
            this.card_employee.Controls.Add(this.panel_add_employee);
            this.card_employee.Depth = 0;
            this.card_employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_employee.Location = new System.Drawing.Point(385, 65);
            this.card_employee.Margin = new System.Windows.Forms.Padding(14);
            this.card_employee.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_employee.Name = "card_employee";
            this.card_employee.Padding = new System.Windows.Forms.Padding(14);
            this.card_employee.Size = new System.Drawing.Size(497, 468);
            this.card_employee.TabIndex = 106;
            // 
            // btn_Useranuller
            // 
            this.btn_Useranuller.AutoSize = false;
            this.btn_Useranuller.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Useranuller.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Useranuller.Depth = 0;
            this.btn_Useranuller.HighEmphasis = false;
            this.btn_Useranuller.Icon = null;
            this.btn_Useranuller.Location = new System.Drawing.Point(316, 392);
            this.btn_Useranuller.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Useranuller.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Useranuller.Name = "btn_Useranuller";
            this.btn_Useranuller.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Useranuller.Size = new System.Drawing.Size(106, 36);
            this.btn_Useranuller.TabIndex = 107;
            this.btn_Useranuller.Text = "Annuler";
            this.btn_Useranuller.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Useranuller.UseAccentColor = false;
            this.btn_Useranuller.UseVisualStyleBackColor = true;
            this.btn_Useranuller.Click += new System.EventHandler(this.Btn_Useranuller_Click);
            // 
            // BTN_ajouterPerso
            // 
            this.BTN_ajouterPerso.AutoSize = false;
            this.BTN_ajouterPerso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_ajouterPerso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_ajouterPerso.Depth = 0;
            this.BTN_ajouterPerso.HighEmphasis = true;
            this.BTN_ajouterPerso.Icon = null;
            this.BTN_ajouterPerso.Location = new System.Drawing.Point(57, 392);
            this.BTN_ajouterPerso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTN_ajouterPerso.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_ajouterPerso.Name = "BTN_ajouterPerso";
            this.BTN_ajouterPerso.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_ajouterPerso.Size = new System.Drawing.Size(208, 36);
            this.BTN_ajouterPerso.TabIndex = 106;
            this.BTN_ajouterPerso.Text = "ajouter un Emploiee";
            this.BTN_ajouterPerso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_ajouterPerso.UseAccentColor = false;
            this.BTN_ajouterPerso.UseVisualStyleBackColor = true;
            this.BTN_ajouterPerso.Click += new System.EventHandler(this.BTN_ajouterPerso_Click_1);
            // 
            // panel_add_employee
            // 
            this.panel_add_employee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_add_employee.BackColor = System.Drawing.Color.Transparent;
            this.panel_add_employee.Controls.Add(this.label28);
            this.panel_add_employee.Controls.Add(this.groupBox_role);
            this.panel_add_employee.Controls.Add(this.tb_conPass);
            this.panel_add_employee.Controls.Add(this.tb_motpass);
            this.panel_add_employee.Controls.Add(this.tb_username);
            this.panel_add_employee.Controls.Add(this.tb_prenom);
            this.panel_add_employee.Controls.Add(this.label25);
            this.panel_add_employee.Controls.Add(this.tb_Nom);
            this.panel_add_employee.Controls.Add(this.label13);
            this.panel_add_employee.Controls.Add(this.label6);
            this.panel_add_employee.Controls.Add(this.label5);
            this.panel_add_employee.Controls.Add(this.label3);
            this.panel_add_employee.Location = new System.Drawing.Point(0, 0);
            this.panel_add_employee.Name = "panel_add_employee";
            this.panel_add_employee.Size = new System.Drawing.Size(497, 361);
            this.panel_add_employee.TabIndex = 105;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(53, 282);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 20);
            this.label28.TabIndex = 111;
            this.label28.Text = "Role :";
            // 
            // groupBox_role
            // 
            this.groupBox_role.Controls.Add(this.rb_remb_emp);
            this.groupBox_role.Controls.Add(this.rb_rembo_admin);
            this.groupBox_role.Location = new System.Drawing.Point(172, 270);
            this.groupBox_role.Name = "groupBox_role";
            this.groupBox_role.Size = new System.Drawing.Size(292, 63);
            this.groupBox_role.TabIndex = 112;
            this.groupBox_role.TabStop = false;
            // 
            // rb_remb_emp
            // 
            this.rb_remb_emp.AutoSize = true;
            this.rb_remb_emp.BackColor = System.Drawing.Color.Transparent;
            this.rb_remb_emp.Depth = 0;
            this.rb_remb_emp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_remb_emp.Location = new System.Drawing.Point(182, 17);
            this.rb_remb_emp.Margin = new System.Windows.Forms.Padding(0);
            this.rb_remb_emp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_remb_emp.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_remb_emp.Name = "rb_remb_emp";
            this.rb_remb_emp.Ripple = true;
            this.rb_remb_emp.Size = new System.Drawing.Size(68, 37);
            this.rb_remb_emp.TabIndex = 1;
            this.rb_remb_emp.TabStop = true;
            this.rb_remb_emp.Text = "EMP";
            this.rb_remb_emp.UseVisualStyleBackColor = false;
            // 
            // rb_rembo_admin
            // 
            this.rb_rembo_admin.AutoSize = true;
            this.rb_rembo_admin.BackColor = System.Drawing.Color.Transparent;
            this.rb_rembo_admin.Depth = 0;
            this.rb_rembo_admin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_rembo_admin.Location = new System.Drawing.Point(31, 17);
            this.rb_rembo_admin.Margin = new System.Windows.Forms.Padding(0);
            this.rb_rembo_admin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_rembo_admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_rembo_admin.Name = "rb_rembo_admin";
            this.rb_rembo_admin.Ripple = true;
            this.rb_rembo_admin.Size = new System.Drawing.Size(85, 37);
            this.rb_rembo_admin.TabIndex = 0;
            this.rb_rembo_admin.TabStop = true;
            this.rb_rembo_admin.Text = "ADMIN";
            this.rb_rembo_admin.UseVisualStyleBackColor = false;
            // 
            // tb_conPass
            // 
            this.tb_conPass.AnimateReadOnly = false;
            this.tb_conPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_conPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_conPass.Depth = 0;
            this.tb_conPass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_conPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_conPass.Hint = "tapez ici...";
            this.tb_conPass.LeadingIcon = null;
            this.tb_conPass.Location = new System.Drawing.Point(182, 211);
            this.tb_conPass.MaxLength = 50;
            this.tb_conPass.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_conPass.Multiline = false;
            this.tb_conPass.Name = "tb_conPass";
            this.tb_conPass.Size = new System.Drawing.Size(270, 36);
            this.tb_conPass.TabIndex = 110;
            this.tb_conPass.Text = "";
            this.tb_conPass.TrailingIcon = null;
            this.tb_conPass.UseTallSize = false;
            // 
            // tb_motpass
            // 
            this.tb_motpass.AnimateReadOnly = false;
            this.tb_motpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_motpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_motpass.Depth = 0;
            this.tb_motpass.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_motpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_motpass.Hint = "tapez ici...";
            this.tb_motpass.LeadingIcon = null;
            this.tb_motpass.Location = new System.Drawing.Point(182, 157);
            this.tb_motpass.MaxLength = 50;
            this.tb_motpass.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_motpass.Multiline = false;
            this.tb_motpass.Name = "tb_motpass";
            this.tb_motpass.Size = new System.Drawing.Size(270, 36);
            this.tb_motpass.TabIndex = 109;
            this.tb_motpass.Text = "";
            this.tb_motpass.TrailingIcon = null;
            this.tb_motpass.UseTallSize = false;
            // 
            // tb_username
            // 
            this.tb_username.AnimateReadOnly = false;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_username.Depth = 0;
            this.tb_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_username.Hint = "tapez ici...";
            this.tb_username.LeadingIcon = null;
            this.tb_username.Location = new System.Drawing.Point(182, 115);
            this.tb_username.MaxLength = 50;
            this.tb_username.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(270, 36);
            this.tb_username.TabIndex = 108;
            this.tb_username.Text = "";
            this.tb_username.TrailingIcon = null;
            this.tb_username.UseTallSize = false;
            // 
            // tb_prenom
            // 
            this.tb_prenom.AnimateReadOnly = false;
            this.tb_prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_prenom.Depth = 0;
            this.tb_prenom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_prenom.Hint = "tapez ici...";
            this.tb_prenom.LeadingIcon = null;
            this.tb_prenom.Location = new System.Drawing.Point(182, 73);
            this.tb_prenom.MaxLength = 50;
            this.tb_prenom.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_prenom.Multiline = false;
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(270, 36);
            this.tb_prenom.TabIndex = 107;
            this.tb_prenom.Text = "";
            this.tb_prenom.TrailingIcon = null;
            this.tb_prenom.UseTallSize = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(53, 211);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 40);
            this.label25.TabIndex = 106;
            this.label25.Text = "Confirmer mot \r\n de pass :";
            // 
            // tb_Nom
            // 
            this.tb_Nom.AnimateReadOnly = false;
            this.tb_Nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Nom.Depth = 0;
            this.tb_Nom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_Nom.Hint = "tapez ici...";
            this.tb_Nom.LeadingIcon = null;
            this.tb_Nom.Location = new System.Drawing.Point(183, 17);
            this.tb_Nom.MaxLength = 50;
            this.tb_Nom.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_Nom.Multiline = false;
            this.tb_Nom.Name = "tb_Nom";
            this.tb_Nom.Size = new System.Drawing.Size(270, 36);
            this.tb_Nom.TabIndex = 105;
            this.tb_Nom.Text = "";
            this.tb_Nom.TrailingIcon = null;
            this.tb_Nom.UseTallSize = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(53, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 103;
            this.label13.Text = "prenom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "mot de pass :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "nom utilisateur : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Nom :";
            // 
            // tp_lab
            // 
            this.tp_lab.BackColor = System.Drawing.Color.White;
            this.tp_lab.Controls.Add(this.card_lab);
            this.tp_lab.Location = new System.Drawing.Point(4, 39);
            this.tp_lab.Name = "tp_lab";
            this.tp_lab.Size = new System.Drawing.Size(1266, 598);
            this.tp_lab.TabIndex = 2;
            this.tp_lab.Text = "Ajouter un Laboratoire";
            // 
            // card_lab
            // 
            this.card_lab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.card_lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_lab.Controls.Add(this.panel_lab);
            this.card_lab.Controls.Add(this.tb_addLab);
            this.card_lab.Controls.Add(this.materialButton2);
            this.card_lab.Depth = 0;
            this.card_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_lab.Location = new System.Drawing.Point(355, 53);
            this.card_lab.Margin = new System.Windows.Forms.Padding(14);
            this.card_lab.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_lab.Name = "card_lab";
            this.card_lab.Padding = new System.Windows.Forms.Padding(14);
            this.card_lab.Size = new System.Drawing.Size(492, 433);
            this.card_lab.TabIndex = 108;
            // 
            // panel_lab
            // 
            this.panel_lab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_lab.BackColor = System.Drawing.Color.White;
            this.panel_lab.Controls.Add(this.cb_pay);
            this.panel_lab.Controls.Add(this.tb_webAdress);
            this.panel_lab.Controls.Add(this.tb_phone);
            this.panel_lab.Controls.Add(this.tb_adress);
            this.panel_lab.Controls.Add(this.tb_codeLab);
            this.panel_lab.Controls.Add(this.label26);
            this.panel_lab.Controls.Add(this.tb_nomLab);
            this.panel_lab.Controls.Add(this.label20);
            this.panel_lab.Controls.Add(this.label21);
            this.panel_lab.Controls.Add(this.label22);
            this.panel_lab.Controls.Add(this.label23);
            this.panel_lab.Controls.Add(this.label24);
            this.panel_lab.Location = new System.Drawing.Point(0, 0);
            this.panel_lab.Name = "panel_lab";
            this.panel_lab.Size = new System.Drawing.Size(497, 361);
            this.panel_lab.TabIndex = 105;
            // 
            // cb_pay
            // 
            this.cb_pay.AutoResize = false;
            this.cb_pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_pay.Depth = 0;
            this.cb_pay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_pay.DropDownHeight = 118;
            this.cb_pay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pay.DropDownWidth = 121;
            this.cb_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_pay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_pay.FormattingEnabled = true;
            this.cb_pay.Hint = "choisissez le pays";
            this.cb_pay.IntegralHeight = false;
            this.cb_pay.ItemHeight = 29;
            this.cb_pay.Location = new System.Drawing.Point(171, 284);
            this.cb_pay.MaxDropDownItems = 4;
            this.cb_pay.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_pay.Name = "cb_pay";
            this.cb_pay.Size = new System.Drawing.Size(271, 35);
            this.cb_pay.StartIndex = -1;
            this.cb_pay.TabIndex = 112;
            this.cb_pay.UseTallSize = false;
            // 
            // tb_webAdress
            // 
            this.tb_webAdress.AnimateReadOnly = false;
            this.tb_webAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_webAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_webAdress.Depth = 0;
            this.tb_webAdress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_webAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_webAdress.Hint = "tapez ici...";
            this.tb_webAdress.LeadingIcon = null;
            this.tb_webAdress.Location = new System.Drawing.Point(172, 228);
            this.tb_webAdress.MaxLength = 50;
            this.tb_webAdress.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_webAdress.Multiline = false;
            this.tb_webAdress.Name = "tb_webAdress";
            this.tb_webAdress.Size = new System.Drawing.Size(270, 36);
            this.tb_webAdress.TabIndex = 111;
            this.tb_webAdress.Text = "";
            this.tb_webAdress.TrailingIcon = null;
            this.tb_webAdress.UseTallSize = false;
            // 
            // tb_phone
            // 
            this.tb_phone.AnimateReadOnly = false;
            this.tb_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_phone.Depth = 0;
            this.tb_phone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_phone.Hint = "tapez ici...";
            this.tb_phone.LeadingIcon = null;
            this.tb_phone.Location = new System.Drawing.Point(172, 184);
            this.tb_phone.MaxLength = 50;
            this.tb_phone.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_phone.Multiline = false;
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(270, 36);
            this.tb_phone.TabIndex = 110;
            this.tb_phone.Text = "";
            this.tb_phone.TrailingIcon = null;
            this.tb_phone.UseTallSize = false;
            this.tb_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_phone_KeyPress);
            // 
            // tb_adress
            // 
            this.tb_adress.AnimateReadOnly = false;
            this.tb_adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_adress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_adress.Depth = 0;
            this.tb_adress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_adress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_adress.Hint = "tapez ici...";
            this.tb_adress.LeadingIcon = null;
            this.tb_adress.Location = new System.Drawing.Point(172, 135);
            this.tb_adress.MaxLength = 50;
            this.tb_adress.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_adress.Multiline = false;
            this.tb_adress.Name = "tb_adress";
            this.tb_adress.Size = new System.Drawing.Size(270, 36);
            this.tb_adress.TabIndex = 109;
            this.tb_adress.Text = "";
            this.tb_adress.TrailingIcon = null;
            this.tb_adress.UseTallSize = false;
            // 
            // tb_codeLab
            // 
            this.tb_codeLab.AnimateReadOnly = false;
            this.tb_codeLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_codeLab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_codeLab.Depth = 0;
            this.tb_codeLab.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_codeLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_codeLab.Hint = "tapez ici...";
            this.tb_codeLab.LeadingIcon = null;
            this.tb_codeLab.Location = new System.Drawing.Point(172, 83);
            this.tb_codeLab.MaxLength = 50;
            this.tb_codeLab.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_codeLab.Multiline = false;
            this.tb_codeLab.Name = "tb_codeLab";
            this.tb_codeLab.Size = new System.Drawing.Size(270, 36);
            this.tb_codeLab.TabIndex = 108;
            this.tb_codeLab.Text = "";
            this.tb_codeLab.TrailingIcon = null;
            this.tb_codeLab.UseTallSize = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(48, 235);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 20);
            this.label26.TabIndex = 107;
            this.label26.Text = "web adress : ";
            // 
            // tb_nomLab
            // 
            this.tb_nomLab.AnimateReadOnly = false;
            this.tb_nomLab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nomLab.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nomLab.Depth = 0;
            this.tb_nomLab.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_nomLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_nomLab.Hint = "tapez ici...";
            this.tb_nomLab.LeadingIcon = null;
            this.tb_nomLab.Location = new System.Drawing.Point(172, 19);
            this.tb_nomLab.MaxLength = 50;
            this.tb_nomLab.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_nomLab.Multiline = false;
            this.tb_nomLab.Name = "tb_nomLab";
            this.tb_nomLab.Size = new System.Drawing.Size(270, 36);
            this.tb_nomLab.TabIndex = 105;
            this.tb_nomLab.Text = "";
            this.tb_nomLab.TrailingIcon = null;
            this.tb_nomLab.UseTallSize = false;
            this.tb_nomLab.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_nomLab_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(48, 83);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 20);
            this.label20.TabIndex = 103;
            this.label20.Text = "code Lab :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(48, 183);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 20);
            this.label21.TabIndex = 98;
            this.label21.Text = "numero   :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(48, 135);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 20);
            this.label22.TabIndex = 96;
            this.label22.Text = "adress : ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(57, 287);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 20);
            this.label23.TabIndex = 94;
            this.label23.Text = "Pays :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(46, 35);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 20);
            this.label24.TabIndex = 93;
            this.label24.Text = "Nom Lab :";
            // 
            // tb_addLab
            // 
            this.tb_addLab.AutoSize = false;
            this.tb_addLab.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tb_addLab.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.tb_addLab.Depth = 0;
            this.tb_addLab.HighEmphasis = true;
            this.tb_addLab.Icon = null;
            this.tb_addLab.Location = new System.Drawing.Point(86, 377);
            this.tb_addLab.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tb_addLab.MouseState = MaterialSkin.MouseState.HOVER;
            this.tb_addLab.Name = "tb_addLab";
            this.tb_addLab.NoAccentTextColor = System.Drawing.Color.Empty;
            this.tb_addLab.Size = new System.Drawing.Size(168, 36);
            this.tb_addLab.TabIndex = 107;
            this.tb_addLab.Text = "ajouter Lab";
            this.tb_addLab.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.tb_addLab.UseAccentColor = false;
            this.tb_addLab.UseVisualStyleBackColor = true;
            this.tb_addLab.Click += new System.EventHandler(this.Tb_addLab_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = false;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(305, 377);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(106, 36);
            this.materialButton2.TabIndex = 98;
            this.materialButton2.Text = "Annuler";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // tp_produit
            // 
            this.tp_produit.Controls.Add(this.card_produit);
            this.tp_produit.Location = new System.Drawing.Point(4, 39);
            this.tp_produit.Margin = new System.Windows.Forms.Padding(2);
            this.tp_produit.Name = "tp_produit";
            this.tp_produit.Size = new System.Drawing.Size(1266, 598);
            this.tp_produit.TabIndex = 3;
            this.tp_produit.Text = "Ajouter un produit";
            this.tp_produit.UseVisualStyleBackColor = true;
            // 
            // card_produit
            // 
            this.card_produit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_produit.Controls.Add(this.panel_add_med);
            this.card_produit.Controls.Add(this.materialButton1);
            this.card_produit.Controls.Add(this.materialButton9);
            this.card_produit.Controls.Add(this.materialButton5);
            this.card_produit.Depth = 0;
            this.card_produit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_produit.Location = new System.Drawing.Point(52, 17);
            this.card_produit.Margin = new System.Windows.Forms.Padding(14);
            this.card_produit.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_produit.Name = "card_produit";
            this.card_produit.Padding = new System.Windows.Forms.Padding(14);
            this.card_produit.Size = new System.Drawing.Size(1143, 567);
            this.card_produit.TabIndex = 111;
            // 
            // panel_add_med
            // 
            this.panel_add_med.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_add_med.BackColor = System.Drawing.Color.Transparent;
            this.panel_add_med.Controls.Add(this.tb_conditionemnt);
            this.panel_add_med.Controls.Add(this.label29);
            this.panel_add_med.Controls.Add(this.label15);
            this.panel_add_med.Controls.Add(this.cb_Dci);
            this.panel_add_med.Controls.Add(this.label14);
            this.panel_add_med.Controls.Add(this.cb_classThera);
            this.panel_add_med.Controls.Add(this.label1);
            this.panel_add_med.Controls.Add(this.cb_classPharma);
            this.panel_add_med.Controls.Add(this.tb_lab);
            this.panel_add_med.Controls.Add(this.cb_lab);
            this.panel_add_med.Controls.Add(this.tb_ppa);
            this.panel_add_med.Controls.Add(this.label2);
            this.panel_add_med.Controls.Add(this.tb_tarif);
            this.panel_add_med.Controls.Add(this.label7);
            this.panel_add_med.Controls.Add(this.gb_rembo);
            this.panel_add_med.Controls.Add(this.label8);
            this.panel_add_med.Controls.Add(this.label9);
            this.panel_add_med.Controls.Add(this.gb_comm);
            this.panel_add_med.Controls.Add(this.label10);
            this.panel_add_med.Controls.Add(this.gb_list);
            this.panel_add_med.Controls.Add(this.label11);
            this.panel_add_med.Controls.Add(this.gb_type);
            this.panel_add_med.Controls.Add(this.label12);
            this.panel_add_med.Controls.Add(this.cb_pays);
            this.panel_add_med.Controls.Add(this.tb_dossage);
            this.panel_add_med.Controls.Add(this.label16);
            this.panel_add_med.Controls.Add(this.tb_form);
            this.panel_add_med.Controls.Add(this.label17);
            this.panel_add_med.Controls.Add(this.tb_NomMed);
            this.panel_add_med.Controls.Add(this.label18);
            this.panel_add_med.Controls.Add(this.tb_refMed);
            this.panel_add_med.Controls.Add(this.label19);
            this.panel_add_med.Location = new System.Drawing.Point(57, 17);
            this.panel_add_med.Name = "panel_add_med";
            this.panel_add_med.Size = new System.Drawing.Size(1036, 460);
            this.panel_add_med.TabIndex = 112;
            // 
            // tb_conditionemnt
            // 
            this.tb_conditionemnt.AnimateReadOnly = false;
            this.tb_conditionemnt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_conditionemnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_conditionemnt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_conditionemnt.Depth = 0;
            this.tb_conditionemnt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_conditionemnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_conditionemnt.Hint = "tapez ici....";
            this.tb_conditionemnt.LeadingIcon = null;
            this.tb_conditionemnt.Location = new System.Drawing.Point(704, 403);
            this.tb_conditionemnt.MaxLength = 50;
            this.tb_conditionemnt.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_conditionemnt.Multiline = false;
            this.tb_conditionemnt.Name = "tb_conditionemnt";
            this.tb_conditionemnt.Size = new System.Drawing.Size(322, 36);
            this.tb_conditionemnt.TabIndex = 109;
            this.tb_conditionemnt.Text = "";
            this.tb_conditionemnt.TrailingIcon = null;
            this.tb_conditionemnt.UseTallSize = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(516, 409);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(142, 20);
            this.label29.TabIndex = 108;
            this.label29.Text = "Conditionnement  :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(613, 370);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 107;
            this.label15.Text = "DCI :";
            // 
            // cb_Dci
            // 
            this.cb_Dci.AutoResize = false;
            this.cb_Dci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_Dci.Depth = 0;
            this.cb_Dci.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Dci.DropDownHeight = 118;
            this.cb_Dci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Dci.DropDownWidth = 121;
            this.cb_Dci.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_Dci.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_Dci.FormattingEnabled = true;
            this.cb_Dci.Hint = "sélectionner une classe";
            this.cb_Dci.IntegralHeight = false;
            this.cb_Dci.ItemHeight = 29;
            this.cb_Dci.Location = new System.Drawing.Point(710, 362);
            this.cb_Dci.MaxDropDownItems = 4;
            this.cb_Dci.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_Dci.Name = "cb_Dci";
            this.cb_Dci.Size = new System.Drawing.Size(271, 35);
            this.cb_Dci.StartIndex = -1;
            this.cb_Dci.TabIndex = 106;
            this.cb_Dci.UseTallSize = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(500, 329);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 20);
            this.label14.TabIndex = 105;
            this.label14.Text = "Classe thérapeutique :";
            // 
            // cb_classThera
            // 
            this.cb_classThera.AutoResize = false;
            this.cb_classThera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_classThera.Depth = 0;
            this.cb_classThera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_classThera.DropDownHeight = 118;
            this.cb_classThera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_classThera.DropDownWidth = 121;
            this.cb_classThera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_classThera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_classThera.FormattingEnabled = true;
            this.cb_classThera.Hint = "sélectionner une classe";
            this.cb_classThera.IntegralHeight = false;
            this.cb_classThera.ItemHeight = 29;
            this.cb_classThera.Location = new System.Drawing.Point(710, 321);
            this.cb_classThera.MaxDropDownItems = 4;
            this.cb_classThera.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_classThera.Name = "cb_classThera";
            this.cb_classThera.Size = new System.Drawing.Size(271, 35);
            this.cb_classThera.StartIndex = -1;
            this.cb_classThera.TabIndex = 104;
            this.cb_classThera.UseTallSize = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 279);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Classe pharmacologique :";
            // 
            // cb_classPharma
            // 
            this.cb_classPharma.AutoResize = false;
            this.cb_classPharma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_classPharma.Depth = 0;
            this.cb_classPharma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_classPharma.DropDownHeight = 118;
            this.cb_classPharma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_classPharma.DropDownWidth = 121;
            this.cb_classPharma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_classPharma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_classPharma.FormattingEnabled = true;
            this.cb_classPharma.Hint = "sélectionner une classe";
            this.cb_classPharma.IntegralHeight = false;
            this.cb_classPharma.ItemHeight = 29;
            this.cb_classPharma.Location = new System.Drawing.Point(710, 274);
            this.cb_classPharma.MaxDropDownItems = 4;
            this.cb_classPharma.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_classPharma.Name = "cb_classPharma";
            this.cb_classPharma.Size = new System.Drawing.Size(271, 35);
            this.cb_classPharma.StartIndex = -1;
            this.cb_classPharma.TabIndex = 102;
            this.cb_classPharma.UseTallSize = false;
            // 
            // tb_lab
            // 
            this.tb_lab.AutoSize = true;
            this.tb_lab.BackColor = System.Drawing.Color.Transparent;
            this.tb_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lab.Location = new System.Drawing.Point(565, 229);
            this.tb_lab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tb_lab.Name = "tb_lab";
            this.tb_lab.Size = new System.Drawing.Size(98, 20);
            this.tb_lab.TabIndex = 101;
            this.tb_lab.Text = "Laboratoire :";
            // 
            // cb_lab
            // 
            this.cb_lab.AutoResize = false;
            this.cb_lab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_lab.Depth = 0;
            this.cb_lab.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_lab.DropDownHeight = 118;
            this.cb_lab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lab.DropDownWidth = 121;
            this.cb_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_lab.FormattingEnabled = true;
            this.cb_lab.Hint = "sélectionner un laboratoire";
            this.cb_lab.IntegralHeight = false;
            this.cb_lab.ItemHeight = 29;
            this.cb_lab.Location = new System.Drawing.Point(710, 221);
            this.cb_lab.MaxDropDownItems = 4;
            this.cb_lab.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_lab.Name = "cb_lab";
            this.cb_lab.Size = new System.Drawing.Size(271, 35);
            this.cb_lab.StartIndex = -1;
            this.cb_lab.TabIndex = 100;
            this.cb_lab.UseTallSize = false;
            // 
            // tb_ppa
            // 
            this.tb_ppa.AnimateReadOnly = false;
            this.tb_ppa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ppa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_ppa.Depth = 0;
            this.tb_ppa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ppa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ppa.Hint = "tapez ici....";
            this.tb_ppa.LeadingIcon = null;
            this.tb_ppa.Location = new System.Drawing.Point(711, 175);
            this.tb_ppa.MaxLength = 50;
            this.tb_ppa.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_ppa.Multiline = false;
            this.tb_ppa.Name = "tb_ppa";
            this.tb_ppa.Size = new System.Drawing.Size(270, 36);
            this.tb_ppa.TabIndex = 99;
            this.tb_ppa.Text = "";
            this.tb_ppa.TrailingIcon = null;
            this.tb_ppa.UseTallSize = false;
            this.tb_ppa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_tarif_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 98;
            this.label2.Text = "PPA (indicatif) :";
            // 
            // tb_tarif
            // 
            this.tb_tarif.AnimateReadOnly = false;
            this.tb_tarif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_tarif.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tarif.Depth = 0;
            this.tb_tarif.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_tarif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_tarif.Hint = "tapez ici....";
            this.tb_tarif.LeadingIcon = null;
            this.tb_tarif.Location = new System.Drawing.Point(711, 116);
            this.tb_tarif.MaxLength = 50;
            this.tb_tarif.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_tarif.Multiline = false;
            this.tb_tarif.Name = "tb_tarif";
            this.tb_tarif.Size = new System.Drawing.Size(270, 36);
            this.tb_tarif.TabIndex = 97;
            this.tb_tarif.Text = "";
            this.tb_tarif.TrailingIcon = null;
            this.tb_tarif.UseTallSize = false;
            this.tb_tarif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_tarif_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(525, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 96;
            this.label7.Text = "Tarif de référence: ";
            // 
            // gb_rembo
            // 
            this.gb_rembo.Controls.Add(this.rb_non_remborsable);
            this.gb_rembo.Controls.Add(this.rb_remborsable);
            this.gb_rembo.Location = new System.Drawing.Point(711, 39);
            this.gb_rembo.Name = "gb_rembo";
            this.gb_rembo.Size = new System.Drawing.Size(270, 61);
            this.gb_rembo.TabIndex = 95;
            this.gb_rembo.TabStop = false;
            // 
            // rb_non_remborsable
            // 
            this.rb_non_remborsable.AutoSize = true;
            this.rb_non_remborsable.BackColor = System.Drawing.Color.Transparent;
            this.rb_non_remborsable.Depth = 0;
            this.rb_non_remborsable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_non_remborsable.Location = new System.Drawing.Point(176, 15);
            this.rb_non_remborsable.Margin = new System.Windows.Forms.Padding(0);
            this.rb_non_remborsable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_non_remborsable.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_non_remborsable.Name = "rb_non_remborsable";
            this.rb_non_remborsable.Ripple = true;
            this.rb_non_remborsable.Size = new System.Drawing.Size(55, 37);
            this.rb_non_remborsable.TabIndex = 1;
            this.rb_non_remborsable.TabStop = true;
            this.rb_non_remborsable.Text = "No";
            this.rb_non_remborsable.UseVisualStyleBackColor = false;
            // 
            // rb_remborsable
            // 
            this.rb_remborsable.AutoSize = true;
            this.rb_remborsable.BackColor = System.Drawing.Color.Transparent;
            this.rb_remborsable.Checked = true;
            this.rb_remborsable.Depth = 0;
            this.rb_remborsable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_remborsable.Location = new System.Drawing.Point(12, 15);
            this.rb_remborsable.Margin = new System.Windows.Forms.Padding(0);
            this.rb_remborsable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_remborsable.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_remborsable.Name = "rb_remborsable";
            this.rb_remborsable.Ripple = true;
            this.rb_remborsable.Size = new System.Drawing.Size(59, 37);
            this.rb_remborsable.TabIndex = 0;
            this.rb_remborsable.TabStop = true;
            this.rb_remborsable.Text = "Oui";
            this.rb_remborsable.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 94;
            this.label8.Text = "Remboursable :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(589, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 93;
            this.label9.Text = "Pays :";
            // 
            // gb_comm
            // 
            this.gb_comm.Controls.Add(this.rb_comme_No);
            this.gb_comm.Controls.Add(this.rb_comme_Oui);
            this.gb_comm.Location = new System.Drawing.Point(166, 342);
            this.gb_comm.Name = "gb_comm";
            this.gb_comm.Size = new System.Drawing.Size(271, 62);
            this.gb_comm.TabIndex = 92;
            this.gb_comm.TabStop = false;
            // 
            // rb_comme_No
            // 
            this.rb_comme_No.AutoSize = true;
            this.rb_comme_No.BackColor = System.Drawing.Color.Transparent;
            this.rb_comme_No.Depth = 0;
            this.rb_comme_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_comme_No.Location = new System.Drawing.Point(146, 15);
            this.rb_comme_No.Margin = new System.Windows.Forms.Padding(0);
            this.rb_comme_No.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_comme_No.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_comme_No.Name = "rb_comme_No";
            this.rb_comme_No.Ripple = true;
            this.rb_comme_No.Size = new System.Drawing.Size(55, 37);
            this.rb_comme_No.TabIndex = 1;
            this.rb_comme_No.TabStop = true;
            this.rb_comme_No.Text = "No";
            this.rb_comme_No.UseVisualStyleBackColor = false;
            // 
            // rb_comme_Oui
            // 
            this.rb_comme_Oui.AutoSize = true;
            this.rb_comme_Oui.BackColor = System.Drawing.Color.Transparent;
            this.rb_comme_Oui.Depth = 0;
            this.rb_comme_Oui.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_comme_Oui.Location = new System.Drawing.Point(48, 16);
            this.rb_comme_Oui.Margin = new System.Windows.Forms.Padding(0);
            this.rb_comme_Oui.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_comme_Oui.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_comme_Oui.Name = "rb_comme_Oui";
            this.rb_comme_Oui.Ripple = true;
            this.rb_comme_Oui.Size = new System.Drawing.Size(59, 37);
            this.rb_comme_Oui.TabIndex = 0;
            this.rb_comme_Oui.TabStop = true;
            this.rb_comme_Oui.Text = "Oui";
            this.rb_comme_Oui.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 365);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Commercialisation :";
            // 
            // gb_list
            // 
            this.gb_list.Controls.Add(this.rb_list3);
            this.gb_list.Controls.Add(this.rb_list2);
            this.gb_list.Controls.Add(this.rb_list1);
            this.gb_list.Location = new System.Drawing.Point(115, 281);
            this.gb_list.Name = "gb_list";
            this.gb_list.Size = new System.Drawing.Size(322, 62);
            this.gb_list.TabIndex = 90;
            this.gb_list.TabStop = false;
            // 
            // rb_list3
            // 
            this.rb_list3.AutoSize = true;
            this.rb_list3.BackColor = System.Drawing.Color.Transparent;
            this.rb_list3.Depth = 0;
            this.rb_list3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_list3.Location = new System.Drawing.Point(197, 16);
            this.rb_list3.Margin = new System.Windows.Forms.Padding(0);
            this.rb_list3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_list3.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_list3.Name = "rb_list3";
            this.rb_list3.Ripple = true;
            this.rb_list3.Size = new System.Drawing.Size(74, 37);
            this.rb_list3.TabIndex = 2;
            this.rb_list3.TabStop = true;
            this.rb_list3.Text = "List 3";
            this.rb_list3.UseVisualStyleBackColor = false;
            // 
            // rb_list2
            // 
            this.rb_list2.AutoSize = true;
            this.rb_list2.BackColor = System.Drawing.Color.Transparent;
            this.rb_list2.Depth = 0;
            this.rb_list2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_list2.Location = new System.Drawing.Point(99, 16);
            this.rb_list2.Margin = new System.Windows.Forms.Padding(0);
            this.rb_list2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_list2.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_list2.Name = "rb_list2";
            this.rb_list2.Ripple = true;
            this.rb_list2.Size = new System.Drawing.Size(74, 37);
            this.rb_list2.TabIndex = 1;
            this.rb_list2.TabStop = true;
            this.rb_list2.Text = "List 2";
            this.rb_list2.UseVisualStyleBackColor = false;
            // 
            // rb_list1
            // 
            this.rb_list1.AutoSize = true;
            this.rb_list1.BackColor = System.Drawing.Color.Transparent;
            this.rb_list1.Depth = 0;
            this.rb_list1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_list1.Location = new System.Drawing.Point(13, 16);
            this.rb_list1.Margin = new System.Windows.Forms.Padding(0);
            this.rb_list1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_list1.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_list1.Name = "rb_list1";
            this.rb_list1.Ripple = true;
            this.rb_list1.Size = new System.Drawing.Size(74, 37);
            this.rb_list1.TabIndex = 0;
            this.rb_list1.TabStop = true;
            this.rb_list1.Text = "List 1";
            this.rb_list1.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 305);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 89;
            this.label11.Text = "List :";
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.type_non_generique);
            this.gb_type.Controls.Add(this.rb_type_generique);
            this.gb_type.Location = new System.Drawing.Point(115, 213);
            this.gb_type.Name = "gb_type";
            this.gb_type.Size = new System.Drawing.Size(322, 62);
            this.gb_type.TabIndex = 88;
            this.gb_type.TabStop = false;
            // 
            // type_non_generique
            // 
            this.type_non_generique.AutoSize = true;
            this.type_non_generique.BackColor = System.Drawing.Color.Transparent;
            this.type_non_generique.Depth = 0;
            this.type_non_generique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.type_non_generique.Location = new System.Drawing.Point(197, 16);
            this.type_non_generique.Margin = new System.Windows.Forms.Padding(0);
            this.type_non_generique.MouseLocation = new System.Drawing.Point(-1, -1);
            this.type_non_generique.MouseState = MaterialSkin.MouseState.HOVER;
            this.type_non_generique.Name = "type_non_generique";
            this.type_non_generique.Ripple = true;
            this.type_non_generique.Size = new System.Drawing.Size(96, 37);
            this.type_non_generique.TabIndex = 1;
            this.type_non_generique.TabStop = true;
            this.type_non_generique.Text = "Princeps";
            this.type_non_generique.UseVisualStyleBackColor = false;
            this.type_non_generique.Click += new System.EventHandler(this.Type_non_generique_Click);
            // 
            // rb_type_generique
            // 
            this.rb_type_generique.AutoSize = true;
            this.rb_type_generique.BackColor = System.Drawing.Color.Transparent;
            this.rb_type_generique.Checked = true;
            this.rb_type_generique.Depth = 0;
            this.rb_type_generique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_type_generique.Location = new System.Drawing.Point(13, 16);
            this.rb_type_generique.Margin = new System.Windows.Forms.Padding(0);
            this.rb_type_generique.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_type_generique.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_type_generique.Name = "rb_type_generique";
            this.rb_type_generique.Ripple = true;
            this.rb_type_generique.Size = new System.Drawing.Size(106, 37);
            this.rb_type_generique.TabIndex = 0;
            this.rb_type_generique.TabStop = true;
            this.rb_type_generique.Text = "Générique";
            this.rb_type_generique.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 20);
            this.label12.TabIndex = 82;
            this.label12.Text = "Form :";
            // 
            // cb_pays
            // 
            this.cb_pays.AutoResize = false;
            this.cb_pays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cb_pays.Depth = 0;
            this.cb_pays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_pays.DropDownHeight = 118;
            this.cb_pays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pays.DropDownWidth = 121;
            this.cb_pays.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cb_pays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cb_pays.FormattingEnabled = true;
            this.cb_pays.Hint = "choisissez le pays";
            this.cb_pays.IntegralHeight = false;
            this.cb_pays.ItemHeight = 29;
            this.cb_pays.Location = new System.Drawing.Point(711, 3);
            this.cb_pays.MaxDropDownItems = 4;
            this.cb_pays.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_pays.Name = "cb_pays";
            this.cb_pays.Size = new System.Drawing.Size(271, 35);
            this.cb_pays.StartIndex = -1;
            this.cb_pays.TabIndex = 71;
            this.cb_pays.UseTallSize = false;
            // 
            // tb_dossage
            // 
            this.tb_dossage.AnimateReadOnly = false;
            this.tb_dossage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dossage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_dossage.Depth = 0;
            this.tb_dossage.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_dossage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_dossage.Hint = "tapez ici....";
            this.tb_dossage.LeadingIcon = null;
            this.tb_dossage.Location = new System.Drawing.Point(115, 171);
            this.tb_dossage.MaxLength = 50;
            this.tb_dossage.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_dossage.Multiline = false;
            this.tb_dossage.Name = "tb_dossage";
            this.tb_dossage.Size = new System.Drawing.Size(322, 36);
            this.tb_dossage.TabIndex = 87;
            this.tb_dossage.Text = "";
            this.tb_dossage.TrailingIcon = null;
            this.tb_dossage.UseTallSize = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 59);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 78;
            this.label16.Text = "Nom Med :";
            // 
            // tb_form
            // 
            this.tb_form.AnimateReadOnly = false;
            this.tb_form.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_form.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_form.Depth = 0;
            this.tb_form.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_form.Hint = "tapez ici....";
            this.tb_form.LeadingIcon = null;
            this.tb_form.Location = new System.Drawing.Point(115, 116);
            this.tb_form.MaxLength = 50;
            this.tb_form.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_form.Multiline = false;
            this.tb_form.Name = "tb_form";
            this.tb_form.Size = new System.Drawing.Size(322, 36);
            this.tb_form.TabIndex = 86;
            this.tb_form.Text = "";
            this.tb_form.TrailingIcon = null;
            this.tb_form.UseTallSize = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 180);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 20);
            this.label17.TabIndex = 79;
            this.label17.Text = "Dossage :";
            // 
            // tb_NomMed
            // 
            this.tb_NomMed.AnimateReadOnly = false;
            this.tb_NomMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_NomMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_NomMed.Depth = 0;
            this.tb_NomMed.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_NomMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_NomMed.Hint = "tapez ici....";
            this.tb_NomMed.LeadingIcon = null;
            this.tb_NomMed.Location = new System.Drawing.Point(115, 50);
            this.tb_NomMed.MaxLength = 50;
            this.tb_NomMed.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_NomMed.Multiline = false;
            this.tb_NomMed.Name = "tb_NomMed";
            this.tb_NomMed.Size = new System.Drawing.Size(322, 36);
            this.tb_NomMed.TabIndex = 85;
            this.tb_NomMed.Text = "";
            this.tb_NomMed.TrailingIcon = null;
            this.tb_NomMed.UseTallSize = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(15, 247);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 20);
            this.label18.TabIndex = 80;
            this.label18.Text = "Type :";
            // 
            // tb_refMed
            // 
            this.tb_refMed.AnimateReadOnly = false;
            this.tb_refMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_refMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_refMed.Depth = 0;
            this.tb_refMed.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_refMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_refMed.Hint = "tapez ici...";
            this.tb_refMed.LeadingIcon = null;
            this.tb_refMed.Location = new System.Drawing.Point(118, 3);
            this.tb_refMed.MaxLength = 50;
            this.tb_refMed.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_refMed.Multiline = false;
            this.tb_refMed.Name = "tb_refMed";
            this.tb_refMed.Size = new System.Drawing.Size(319, 36);
            this.tb_refMed.TabIndex = 84;
            this.tb_refMed.Text = "";
            this.tb_refMed.TrailingIcon = null;
            this.tb_refMed.UseTallSize = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 20);
            this.label19.TabIndex = 81;
            this.label19.Text = "Ref Med :";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(738, 511);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(108, 36);
            this.materialButton1.TabIndex = 108;
            this.materialButton1.Text = "Annuler";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton9
            // 
            this.materialButton9.AutoSize = false;
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(292, 511);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(168, 36);
            this.materialButton9.TabIndex = 110;
            this.materialButton9.Text = "Sauvegarder";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            this.materialButton9.Click += new System.EventHandler(this.Btn_addProduit_Click);
            // 
            // materialButton5
            // 
            this.materialButton5.AutoSize = false;
            this.materialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton5.Depth = 0;
            this.materialButton5.HighEmphasis = true;
            this.materialButton5.Icon = null;
            this.materialButton5.Location = new System.Drawing.Point(497, 486);
            this.materialButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton5.Name = "materialButton5";
            this.materialButton5.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton5.Size = new System.Drawing.Size(189, 61);
            this.materialButton5.TabIndex = 109;
            this.materialButton5.Text = "ajouter une nouvelle classe";
            this.materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton5.UseAccentColor = false;
            this.materialButton5.UseVisualStyleBackColor = true;
            this.materialButton5.Click += new System.EventHandler(this.Btn_addClass_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.panel_listkhdamin);
            this.tabPage10.Location = new System.Drawing.Point(4, 39);
            this.tabPage10.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(1266, 598);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "list des employees";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // panel_listkhdamin
            // 
            this.panel_listkhdamin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_listkhdamin.Location = new System.Drawing.Point(2, 0);
            this.panel_listkhdamin.Margin = new System.Windows.Forms.Padding(2);
            this.panel_listkhdamin.Name = "panel_listkhdamin";
            this.panel_listkhdamin.Size = new System.Drawing.Size(1538, 604);
            this.panel_listkhdamin.TabIndex = 0;
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
            this.imageList1.Images.SetKeyName(8, "setting (1).png");
            this.imageList1.Images.SetKeyName(9, "in-stock (1).png");
            // 
            // tp_alert
            // 
            this.tp_alert.Controls.Add(this.materialTabControl2);
            this.tp_alert.Controls.Add(this.materialTabSelector1);
            this.tp_alert.ImageKey = "danger.png";
            this.tp_alert.Location = new System.Drawing.Point(4, 43);
            this.tp_alert.Margin = new System.Windows.Forms.Padding(2);
            this.tp_alert.Name = "tp_alert";
            this.tp_alert.Size = new System.Drawing.Size(1351, 953);
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
            this.materialTabControl2.Location = new System.Drawing.Point(4, 38);
            this.materialTabControl2.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabControl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl2.Multiline = true;
            this.materialTabControl2.Name = "materialTabControl2";
            this.materialTabControl2.SelectedIndex = 0;
            this.materialTabControl2.Size = new System.Drawing.Size(1180, 391);
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
            this.tp_lowSupply.Size = new System.Drawing.Size(1172, 348);
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
            this.materialLabel44.Size = new System.Drawing.Size(1136, 275);
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
            this.tp_expired_med.Size = new System.Drawing.Size(1172, 348);
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
            this.tp_other.Size = new System.Drawing.Size(1172, 348);
            this.tp_other.TabIndex = 2;
            this.tp_other.Text = "Autre";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.materialTabSelector1.Size = new System.Drawing.Size(1136, 38);
            this.materialTabSelector1.TabIndex = 26;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // tp_settings
            // 
            this.tp_settings.BackColor = System.Drawing.Color.White;
            this.tp_settings.Controls.Add(this.materialTabSelector3);
            this.tp_settings.Controls.Add(this.settins_tabcontrol);
            this.tp_settings.ImageKey = "setting (1).png";
            this.tp_settings.Location = new System.Drawing.Point(4, 43);
            this.tp_settings.Name = "tp_settings";
            this.tp_settings.Size = new System.Drawing.Size(1351, 953);
            this.tp_settings.TabIndex = 10;
            this.tp_settings.Text = "Parametre";
            // 
            // materialTabSelector3
            // 
            this.materialTabSelector3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector3.BackColor = System.Drawing.Color.White;
            this.materialTabSelector3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("materialTabSelector3.BackgroundImage")));
            this.materialTabSelector3.BaseTabControl = this.settins_tabcontrol;
            this.materialTabSelector3.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector3.Depth = 0;
            this.materialTabSelector3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector3.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector3.Margin = new System.Windows.Forms.Padding(0);
            this.materialTabSelector3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector3.Name = "materialTabSelector3";
            this.materialTabSelector3.Size = new System.Drawing.Size(1199, 38);
            this.materialTabSelector3.TabIndex = 93;
            this.materialTabSelector3.Text = "materialTabSelector3";
            // 
            // settins_tabcontrol
            // 
            this.settins_tabcontrol.Controls.Add(this.tabPage5);
            this.settins_tabcontrol.Controls.Add(this.tabPage8);
            this.settins_tabcontrol.Controls.Add(this.tabPage9);
            this.settins_tabcontrol.Depth = 0;
            this.settins_tabcontrol.ImageList = this.imageList1;
            this.settins_tabcontrol.Location = new System.Drawing.Point(0, 41);
            this.settins_tabcontrol.Margin = new System.Windows.Forms.Padding(0);
            this.settins_tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.settins_tabcontrol.Multiline = true;
            this.settins_tabcontrol.Name = "settins_tabcontrol";
            this.settins_tabcontrol.SelectedIndex = 0;
            this.settins_tabcontrol.Size = new System.Drawing.Size(1333, 752);
            this.settins_tabcontrol.TabIndex = 92;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.materialCard1);
            this.tabPage5.Controls.Add(this.card_settings);
            this.tabPage5.ImageKey = "product.png";
            this.tabPage5.Location = new System.Drawing.Point(4, 39);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1325, 709);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "appearance";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialComboBox1);
            this.materialCard1.Controls.Add(this.label4);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 96);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(474, 98);
            this.materialCard1.TabIndex = 93;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "blue",
            "green",
            "red",
            "yellow",
            "orange",
            "pink"});
            this.materialComboBox1.Location = new System.Drawing.Point(112, 25);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(323, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 90;
            this.materialComboBox1.SelectedIndexChanged += new System.EventHandler(this.MaterialComboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 89;
            this.label4.Text = "color Themes :";
            // 
            // card_settings
            // 
            this.card_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card_settings.Controls.Add(this.groupBox1);
            this.card_settings.Controls.Add(this.label27);
            this.card_settings.Depth = 0;
            this.card_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.card_settings.Location = new System.Drawing.Point(0, 0);
            this.card_settings.Margin = new System.Windows.Forms.Padding(14);
            this.card_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.card_settings.Name = "card_settings";
            this.card_settings.Padding = new System.Windows.Forms.Padding(14);
            this.card_settings.Size = new System.Drawing.Size(474, 98);
            this.card_settings.TabIndex = 92;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_darkTheme);
            this.groupBox1.Controls.Add(this.materialRadioButton5);
            this.groupBox1.Location = new System.Drawing.Point(112, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 62);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            // 
            // rb_darkTheme
            // 
            this.rb_darkTheme.AutoSize = true;
            this.rb_darkTheme.BackColor = System.Drawing.Color.Transparent;
            this.rb_darkTheme.Depth = 0;
            this.rb_darkTheme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_darkTheme.Location = new System.Drawing.Point(197, 16);
            this.rb_darkTheme.Margin = new System.Windows.Forms.Padding(0);
            this.rb_darkTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_darkTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_darkTheme.Name = "rb_darkTheme";
            this.rb_darkTheme.Ripple = true;
            this.rb_darkTheme.Size = new System.Drawing.Size(68, 37);
            this.rb_darkTheme.TabIndex = 1;
            this.rb_darkTheme.TabStop = true;
            this.rb_darkTheme.Text = "Dark";
            this.rb_darkTheme.UseVisualStyleBackColor = false;
            this.rb_darkTheme.Click += new System.EventHandler(this.Rb_darkTheme_CheckedChanged);
            // 
            // materialRadioButton5
            // 
            this.materialRadioButton5.AutoSize = true;
            this.materialRadioButton5.BackColor = System.Drawing.Color.Transparent;
            this.materialRadioButton5.Depth = 0;
            this.materialRadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.materialRadioButton5.Location = new System.Drawing.Point(13, 16);
            this.materialRadioButton5.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton5.Name = "materialRadioButton5";
            this.materialRadioButton5.Ripple = true;
            this.materialRadioButton5.Size = new System.Drawing.Size(75, 37);
            this.materialRadioButton5.TabIndex = 0;
            this.materialRadioButton5.TabStop = true;
            this.materialRadioButton5.Text = "Light ";
            this.materialRadioButton5.UseVisualStyleBackColor = false;
            this.materialRadioButton5.Click += new System.EventHandler(this.Rb_darkTheme_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(28, 37);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 20);
            this.label27.TabIndex = 89;
            this.label27.Text = "Theme :";
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.materialLabel3);
            this.tabPage8.Location = new System.Drawing.Point(4, 39);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1325, 709);
            this.tabPage8.TabIndex = 1;
            this.tabPage8.Text = "idk yet";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.Location = new System.Drawing.Point(6, 7);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(475, 58);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Everything is possible!";
            this.materialLabel3.UseAccent = true;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage9.Location = new System.Drawing.Point(4, 39);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(1325, 709);
            this.tabPage9.TabIndex = 2;
            this.tabPage9.Text = "idk yet";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Location = new System.Drawing.Point(4, 43);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1351, 953);
            this.tabPage6.TabIndex = 13;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 43);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1351, 953);
            this.tabPage4.TabIndex = 14;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 43);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1351, 953);
            this.tabPage7.TabIndex = 15;
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tp_logout
            // 
            this.tp_logout.BackColor = System.Drawing.Color.White;
            this.tp_logout.ImageKey = "exit.png";
            this.tp_logout.Location = new System.Drawing.Point(4, 43);
            this.tp_logout.Name = "tp_logout";
            this.tp_logout.Size = new System.Drawing.Size(1351, 953);
            this.tp_logout.TabIndex = 12;
            this.tp_logout.Text = "Se déconnecter";
            // 
            // btn_clear_tbStock
            // 
            this.btn_clear_tbStock.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear_tbStock.FlatAppearance.BorderSize = 0;
            this.btn_clear_tbStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_tbStock.Image = global::User_Interface.Properties.Resources.remove;
            this.btn_clear_tbStock.Location = new System.Drawing.Point(327, 21);
            this.btn_clear_tbStock.Name = "btn_clear_tbStock";
            this.btn_clear_tbStock.Size = new System.Drawing.Size(33, 33);
            this.btn_clear_tbStock.TabIndex = 120;
            this.btn_clear_tbStock.UseVisualStyleBackColor = false;
            this.btn_clear_tbStock.Visible = false;
            // 
            // btn_updateListStocksQts
            // 
            this.btn_updateListStocksQts.BackColor = System.Drawing.Color.Transparent;
            this.btn_updateListStocksQts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_updateListStocksQts.Image = global::User_Interface.Properties.Resources.refresh;
            this.btn_updateListStocksQts.Location = new System.Drawing.Point(705, 67);
            this.btn_updateListStocksQts.Name = "btn_updateListStocksQts";
            this.btn_updateListStocksQts.Size = new System.Drawing.Size(33, 33);
            this.btn_updateListStocksQts.TabIndex = 119;
            this.btn_updateListStocksQts.UseVisualStyleBackColor = false;
            // 
            // lb_nbrPagesStockQts
            // 
            this.lb_nbrPagesStockQts.AutoSize = true;
            this.lb_nbrPagesStockQts.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nbrPagesStockQts.ForeColor = System.Drawing.Color.DimGray;
            this.lb_nbrPagesStockQts.Location = new System.Drawing.Point(510, 73);
            this.lb_nbrPagesStockQts.Name = "lb_nbrPagesStockQts";
            this.lb_nbrPagesStockQts.Size = new System.Drawing.Size(35, 21);
            this.lb_nbrPagesStockQts.TabIndex = 118;
            this.lb_nbrPagesStockQts.Text = "2/3";
            // 
            // btn_previusStock
            // 
            this.btn_previusStock.FlatAppearance.BorderSize = 0;
            this.btn_previusStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_previusStock.Image = global::User_Interface.Properties.Resources.back;
            this.btn_previusStock.Location = new System.Drawing.Point(455, 66);
            this.btn_previusStock.Name = "btn_previusStock";
            this.btn_previusStock.Size = new System.Drawing.Size(34, 34);
            this.btn_previusStock.TabIndex = 117;
            this.btn_previusStock.UseVisualStyleBackColor = true;
            // 
            // btn_next_Stock
            // 
            this.btn_next_Stock.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btn_next_Stock.FlatAppearance.BorderSize = 0;
            this.btn_next_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_Stock.Image = global::User_Interface.Properties.Resources.next__1_;
            this.btn_next_Stock.Location = new System.Drawing.Point(561, 65);
            this.btn_next_Stock.Name = "btn_next_Stock";
            this.btn_next_Stock.Size = new System.Drawing.Size(39, 34);
            this.btn_next_Stock.TabIndex = 116;
            this.btn_next_Stock.UseVisualStyleBackColor = true;
            // 
            // ListV_StockQts
            // 
            this.ListV_StockQts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListV_StockQts.AutoSizeTable = false;
            this.ListV_StockQts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ListV_StockQts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListV_StockQts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.ListV_StockQts.Depth = 0;
            this.ListV_StockQts.Font = new System.Drawing.Font("Segoe UI Semilight", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListV_StockQts.ForeColor = System.Drawing.SystemColors.Info;
            this.ListV_StockQts.FullRowSelect = true;
            this.ListV_StockQts.HideSelection = false;
            this.ListV_StockQts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ListV_StockQts.Location = new System.Drawing.Point(21, 108);
            this.ListV_StockQts.MinimumSize = new System.Drawing.Size(200, 100);
            this.ListV_StockQts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ListV_StockQts.MouseState = MaterialSkin.MouseState.OUT;
            this.ListV_StockQts.Name = "ListV_StockQts";
            this.ListV_StockQts.OwnerDraw = true;
            this.ListV_StockQts.Scrollable = false;
            this.ListV_StockQts.Size = new System.Drawing.Size(1314, 482);
            this.ListV_StockQts.TabIndex = 115;
            this.ListV_StockQts.UseCompatibleStateImageBehavior = false;
            this.ListV_StockQts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Designation:";
            this.columnHeader5.Width = 300;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Laboratoire";
            this.columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "C.Thérapeutique";
            this.columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "C.Pharmacologique";
            this.columnHeader12.Width = 160;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Type";
            this.columnHeader13.Width = 80;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Locale";
            this.columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Remboursable";
            this.columnHeader15.Width = 80;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Tarif";
            this.columnHeader16.Width = 90;
            // 
            // tb_searchStock
            // 
            this.tb_searchStock.AnimateReadOnly = false;
            this.tb_searchStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_searchStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_searchStock.Depth = 0;
            this.tb_searchStock.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_searchStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_searchStock.Hint = "tapez ici...";
            this.tb_searchStock.LeadingIcon = null;
            this.tb_searchStock.Location = new System.Drawing.Point(21, 22);
            this.tb_searchStock.MaxLength = 50;
            this.tb_searchStock.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_searchStock.Multiline = false;
            this.tb_searchStock.Name = "tb_searchStock";
            this.tb_searchStock.Size = new System.Drawing.Size(300, 36);
            this.tb_searchStock.TabIndex = 114;
            this.tb_searchStock.Text = "";
            this.tb_searchStock.TrailingIcon = null;
            this.tb_searchStock.UseTallSize = false;
            // 
            // btn_searchStock
            // 
            this.btn_searchStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchStock.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_searchStock.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_searchStock.Depth = 0;
            this.btn_searchStock.HighEmphasis = true;
            this.btn_searchStock.Icon = null;
            this.btn_searchStock.Location = new System.Drawing.Point(382, 22);
            this.btn_searchStock.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_searchStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_searchStock.Name = "btn_searchStock";
            this.btn_searchStock.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_searchStock.Size = new System.Drawing.Size(115, 36);
            this.btn_searchStock.TabIndex = 113;
            this.btn_searchStock.Text = "rechercher";
            this.btn_searchStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_searchStock.UseAccentColor = false;
            this.btn_searchStock.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1386, 788);
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_main_Load);
            this.tab_control.ResumeLayout(false);
            this.tp_list_stock.ResumeLayout(false);
            this.tp_list_stock.PerformLayout();
            this.tp_StockQts.ResumeLayout(false);
            this.tp_StockQts.PerformLayout();
            this.tp_admin.ResumeLayout(false);
            this.tp_admin_second.ResumeLayout(false);
            this.tp_employee.ResumeLayout(false);
            this.card_employee.ResumeLayout(false);
            this.panel_add_employee.ResumeLayout(false);
            this.panel_add_employee.PerformLayout();
            this.groupBox_role.ResumeLayout(false);
            this.groupBox_role.PerformLayout();
            this.tp_lab.ResumeLayout(false);
            this.card_lab.ResumeLayout(false);
            this.panel_lab.ResumeLayout(false);
            this.panel_lab.PerformLayout();
            this.tp_produit.ResumeLayout(false);
            this.card_produit.ResumeLayout(false);
            this.panel_add_med.ResumeLayout(false);
            this.panel_add_med.PerformLayout();
            this.gb_rembo.ResumeLayout(false);
            this.gb_rembo.PerformLayout();
            this.gb_comm.ResumeLayout(false);
            this.gb_comm.PerformLayout();
            this.gb_list.ResumeLayout(false);
            this.gb_list.PerformLayout();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.tp_alert.ResumeLayout(false);
            this.materialTabControl2.ResumeLayout(false);
            this.tp_lowSupply.ResumeLayout(false);
            this.tp_lowSupply.PerformLayout();
            this.tp_expired_med.ResumeLayout(false);
            this.tp_expired_med.PerformLayout();
            this.tp_settings.ResumeLayout(false);
            this.settins_tabcontrol.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.card_settings.ResumeLayout(false);
            this.card_settings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tab_control;
        private System.Windows.Forms.TabPage tp_home;
        private System.Windows.Forms.TabPage tp_StockQts;
        private System.Windows.Forms.TabPage tp_admin;
        private System.Windows.Forms.TabPage tp_alert;
        private System.Windows.Forms.TabPage tp_list_stock;
        private MaterialSkin.Controls.MaterialButton BTN_rechercher;
        private System.Windows.Forms.ImageList imageList1;
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
        private System.Windows.Forms.TabPage tp_settings;
        private System.Windows.Forms.TabPage tp_logout;
        private System.Windows.Forms.TabPage tabPage6;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector2;
        private MaterialSkin.Controls.MaterialTabControl tp_admin_second;
        private System.Windows.Forms.TabPage tp_employee;


        private System.Windows.Forms.TabPage tp_lab;
        private System.Windows.Forms.TabPage tp_produit;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton tb_addLab;
        private System.Windows.Forms.Panel panel_lab;
        private MaterialSkin.Controls.MaterialTextBox tb_nomLab;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialButton materialButton5;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard card_lab;
        private MaterialSkin.Controls.MaterialCard card_produit;
        private System.Windows.Forms.Panel panel_add_med;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialComboBox cb_Dci;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialComboBox cb_classThera;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cb_classPharma;
        private System.Windows.Forms.Label tb_lab;
        private MaterialSkin.Controls.MaterialComboBox cb_lab;
        private MaterialSkin.Controls.MaterialTextBox tb_ppa;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox tb_tarif;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gb_rembo;
        private MaterialSkin.Controls.MaterialRadioButton rb_non_remborsable;
        private MaterialSkin.Controls.MaterialRadioButton rb_remborsable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gb_comm;
        private MaterialSkin.Controls.MaterialRadioButton rb_comme_No;
        private MaterialSkin.Controls.MaterialRadioButton rb_comme_Oui;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gb_list;
        private MaterialSkin.Controls.MaterialRadioButton rb_list3;
        private MaterialSkin.Controls.MaterialRadioButton rb_list2;
        private MaterialSkin.Controls.MaterialRadioButton rb_list1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gb_type;
        private MaterialSkin.Controls.MaterialRadioButton type_non_generique;
        private MaterialSkin.Controls.MaterialRadioButton rb_type_generique;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialComboBox cb_pays;
        private MaterialSkin.Controls.MaterialTextBox tb_dossage;
        private System.Windows.Forms.Label label16;
        private MaterialSkin.Controls.MaterialTextBox tb_form;
        private System.Windows.Forms.Label label17;
        private MaterialSkin.Controls.MaterialTextBox tb_NomMed;
        private System.Windows.Forms.Label label18;
        private MaterialSkin.Controls.MaterialTextBox tb_refMed;
        private System.Windows.Forms.Label label19;
        private MaterialSkin.Controls.MaterialCard card_employee;
        private Panel panel_add_employee;
        private Label label25;
        private MaterialSkin.Controls.MaterialTextBox tb_Nom;
        private Label label13;
        private Label label6;
        private Label label5;
        private Label label3;
        private TabPage tabPage4;
        private TabPage tabPage7;
        private MaterialSkin.Controls.MaterialTextBox tb_search;
        private MaterialSkin.Controls.MaterialTextBox tb_conPass;
        private MaterialSkin.Controls.MaterialTextBox tb_motpass;
        private MaterialSkin.Controls.MaterialTextBox tb_username;
        private MaterialSkin.Controls.MaterialTextBox tb_prenom;
        private MaterialSkin.Controls.MaterialTextBox tb_webAdress;
        private MaterialSkin.Controls.MaterialTextBox tb_phone;
        private MaterialSkin.Controls.MaterialTextBox tb_adress;
        private MaterialSkin.Controls.MaterialTextBox tb_codeLab;
        private MaterialSkin.Controls.MaterialComboBox cb_pay;
        private Label label28;
        private GroupBox groupBox_role;
        private MaterialSkin.Controls.MaterialRadioButton rb_remb_emp;
        private MaterialSkin.Controls.MaterialRadioButton rb_rembo_admin;
        private MaterialSkin.Controls.MaterialButton btn_Useranuller;
        private MaterialSkin.Controls.MaterialButton BTN_ajouterPerso;
        private MaterialSkin.Controls.MaterialListView lv_listStock;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector3;
        private MaterialSkin.Controls.MaterialTabControl settins_tabcontrol;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private Label label4;
        private MaterialSkin.Controls.MaterialCard card_settings;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRadioButton rb_darkTheme;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton5;
        private Label label27;
        private TabPage tabPage8;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private Panel panel_listkhdamin;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private MaterialSkin.Controls.MaterialTextBox tb_conditionemnt;
        private Label label29;
        private Button btn_next;
        private Button btn_previou_s;
        private Label lb_pageIndex;
        private Button btn_stocklist;
        private Button btn_deleteText;
        private Button btn_clear_tbStock;
        private Button btn_updateListStocksQts;
        private Label lb_nbrPagesStockQts;
        private Button btn_previusStock;
        private Button btn_next_Stock;
        private MaterialSkin.Controls.MaterialListView ListV_StockQts;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private MaterialSkin.Controls.MaterialTextBox tb_searchStock;
        private MaterialSkin.Controls.MaterialButton btn_searchStock;
    }
}