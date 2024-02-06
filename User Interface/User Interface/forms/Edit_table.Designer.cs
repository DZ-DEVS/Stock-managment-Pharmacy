namespace User_Interface.forms
{
    partial class Edit_table
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
            this.btn_update = new MaterialSkin.Controls.MaterialButton();
            this.BTN_Annuler = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_Dci = new MaterialSkin.Controls.MaterialComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_classThera = new MaterialSkin.Controls.MaterialComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_classPharma = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_lab = new System.Windows.Forms.Label();
            this.cb_lab = new MaterialSkin.Controls.MaterialComboBox();
            this.tb_PPA = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_tarif = new MaterialSkin.Controls.MaterialTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_rembo = new System.Windows.Forms.GroupBox();
            this.rb_remb_no = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_rembo_yes = new MaterialSkin.Controls.MaterialRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gb_commersilation = new System.Windows.Forms.GroupBox();
            this.rb_comme_No = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_comme_Oui = new MaterialSkin.Controls.MaterialRadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_list = new System.Windows.Forms.GroupBox();
            this.rb_list3 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_list2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_list1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_type = new System.Windows.Forms.GroupBox();
            this.rb_typ_principe = new MaterialSkin.Controls.MaterialRadioButton();
            this.rb_type_generique = new MaterialSkin.Controls.MaterialRadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_dossage = new MaterialSkin.Controls.MaterialTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_form = new MaterialSkin.Controls.MaterialTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_nomMed = new MaterialSkin.Controls.MaterialTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_refMed = new MaterialSkin.Controls.MaterialTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gb_rembo.SuspendLayout();
            this.gb_commersilation.SuspendLayout();
            this.gb_list.SuspendLayout();
            this.gb_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.AutoSize = false;
            this.btn_update.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_update.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_update.Depth = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.HighEmphasis = true;
            this.btn_update.Icon = null;
            this.btn_update.Location = new System.Drawing.Point(317, 638);
            this.btn_update.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_update.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_update.Name = "btn_update";
            this.btn_update.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_update.Size = new System.Drawing.Size(224, 44);
            this.btn_update.TabIndex = 96;
            this.btn_update.Text = "update";
            this.btn_update.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_update.UseAccentColor = false;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.AutoSize = false;
            this.BTN_Annuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTN_Annuler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BTN_Annuler.Depth = 0;
            this.BTN_Annuler.HighEmphasis = false;
            this.BTN_Annuler.Icon = null;
            this.BTN_Annuler.Location = new System.Drawing.Point(685, 638);
            this.BTN_Annuler.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.BTN_Annuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BTN_Annuler.Size = new System.Drawing.Size(144, 44);
            this.BTN_Annuler.TabIndex = 94;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BTN_Annuler.UseAccentColor = false;
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cb_Dci);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cb_classThera);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb_classPharma);
            this.panel1.Controls.Add(this.tb_lab);
            this.panel1.Controls.Add(this.cb_lab);
            this.panel1.Controls.Add(this.tb_PPA);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_tarif);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.gb_rembo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gb_commersilation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.gb_list);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gb_type);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tb_dossage);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_form);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_nomMed);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tb_refMed);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 571);
            this.panel1.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(695, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 25);
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
            this.cb_Dci.Location = new System.Drawing.Point(957, 506);
            this.cb_Dci.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Dci.MaxDropDownItems = 4;
            this.cb_Dci.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_Dci.Name = "cb_Dci";
            this.cb_Dci.Size = new System.Drawing.Size(351, 35);
            this.cb_Dci.StartIndex = -1;
            this.cb_Dci.TabIndex = 106;
            this.cb_Dci.UseTallSize = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(695, 464);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(208, 25);
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
            this.cb_classThera.Location = new System.Drawing.Point(957, 455);
            this.cb_classThera.Margin = new System.Windows.Forms.Padding(4);
            this.cb_classThera.MaxDropDownItems = 4;
            this.cb_classThera.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_classThera.Name = "cb_classThera";
            this.cb_classThera.Size = new System.Drawing.Size(351, 35);
            this.cb_classThera.StartIndex = -1;
            this.cb_classThera.TabIndex = 104;
            this.cb_classThera.UseTallSize = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(695, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(239, 25);
            this.label13.TabIndex = 103;
            this.label13.Text = "Classe pharmacologique :";
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
            this.cb_classPharma.Location = new System.Drawing.Point(957, 394);
            this.cb_classPharma.Margin = new System.Windows.Forms.Padding(4);
            this.cb_classPharma.MaxDropDownItems = 4;
            this.cb_classPharma.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_classPharma.Name = "cb_classPharma";
            this.cb_classPharma.Size = new System.Drawing.Size(351, 35);
            this.cb_classPharma.StartIndex = -1;
            this.cb_classPharma.TabIndex = 102;
            this.cb_classPharma.UseTallSize = false;
            // 
            // tb_lab
            // 
            this.tb_lab.AutoSize = true;
            this.tb_lab.BackColor = System.Drawing.Color.Transparent;
            this.tb_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lab.Location = new System.Drawing.Point(695, 347);
            this.tb_lab.Name = "tb_lab";
            this.tb_lab.Size = new System.Drawing.Size(121, 25);
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
            this.cb_lab.Location = new System.Drawing.Point(957, 337);
            this.cb_lab.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lab.MaxDropDownItems = 4;
            this.cb_lab.MouseState = MaterialSkin.MouseState.HOVER;
            this.cb_lab.Name = "cb_lab";
            this.cb_lab.Size = new System.Drawing.Size(351, 35);
            this.cb_lab.StartIndex = -1;
            this.cb_lab.TabIndex = 100;
            this.cb_lab.UseTallSize = false;
            // 
            // tb_PPA
            // 
            this.tb_PPA.AnimateReadOnly = false;
            this.tb_PPA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_PPA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_PPA.Depth = 0;
            this.tb_PPA.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_PPA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_PPA.Hint = "tapez ici....";
            this.tb_PPA.LeadingIcon = null;
            this.tb_PPA.Location = new System.Drawing.Point(897, 251);
            this.tb_PPA.Margin = new System.Windows.Forms.Padding(4);
            this.tb_PPA.MaxLength = 50;
            this.tb_PPA.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_PPA.Multiline = false;
            this.tb_PPA.Name = "tb_PPA";
            this.tb_PPA.Size = new System.Drawing.Size(225, 36);
            this.tb_PPA.TabIndex = 99;
            this.tb_PPA.Text = "";
            this.tb_PPA.TrailingIcon = null;
            this.tb_PPA.UseTallSize = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(691, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 98;
            this.label6.Text = "PPA (indicatif) :";
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
            this.tb_tarif.Location = new System.Drawing.Point(897, 187);
            this.tb_tarif.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tarif.MaxLength = 50;
            this.tb_tarif.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_tarif.Multiline = false;
            this.tb_tarif.Name = "tb_tarif";
            this.tb_tarif.Size = new System.Drawing.Size(225, 36);
            this.tb_tarif.TabIndex = 97;
            this.tb_tarif.Text = "";
            this.tb_tarif.TrailingIcon = null;
            this.tb_tarif.UseTallSize = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(691, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "Tarif de référence: ";
            // 
            // gb_rembo
            // 
            this.gb_rembo.Controls.Add(this.rb_remb_no);
            this.gb_rembo.Controls.Add(this.rb_rembo_yes);
            this.gb_rembo.Location = new System.Drawing.Point(897, 78);
            this.gb_rembo.Margin = new System.Windows.Forms.Padding(4);
            this.gb_rembo.Name = "gb_rembo";
            this.gb_rembo.Padding = new System.Windows.Forms.Padding(4);
            this.gb_rembo.Size = new System.Drawing.Size(361, 76);
            this.gb_rembo.TabIndex = 95;
            this.gb_rembo.TabStop = false;
            // 
            // rb_remb_no
            // 
            this.rb_remb_no.AutoSize = true;
            this.rb_remb_no.BackColor = System.Drawing.Color.Transparent;
            this.rb_remb_no.Depth = 0;
            this.rb_remb_no.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_remb_no.Location = new System.Drawing.Point(232, 20);
            this.rb_remb_no.Margin = new System.Windows.Forms.Padding(0);
            this.rb_remb_no.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_remb_no.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_remb_no.Name = "rb_remb_no";
            this.rb_remb_no.Ripple = true;
            this.rb_remb_no.Size = new System.Drawing.Size(55, 37);
            this.rb_remb_no.TabIndex = 1;
            this.rb_remb_no.TabStop = true;
            this.rb_remb_no.Text = "No";
            this.rb_remb_no.UseVisualStyleBackColor = false;
            // 
            // rb_rembo_yes
            // 
            this.rb_rembo_yes.AutoSize = true;
            this.rb_rembo_yes.BackColor = System.Drawing.Color.Transparent;
            this.rb_rembo_yes.Depth = 0;
            this.rb_rembo_yes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_rembo_yes.Location = new System.Drawing.Point(17, 20);
            this.rb_rembo_yes.Margin = new System.Windows.Forms.Padding(0);
            this.rb_rembo_yes.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_rembo_yes.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_rembo_yes.Name = "rb_rembo_yes";
            this.rb_rembo_yes.Ripple = true;
            this.rb_rembo_yes.Size = new System.Drawing.Size(59, 37);
            this.rb_rembo_yes.TabIndex = 0;
            this.rb_rembo_yes.TabStop = true;
            this.rb_rembo_yes.Text = "Oui";
            this.rb_rembo_yes.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 94;
            this.label4.Text = "Remboursable :";
            // 
            // gb_commersilation
            // 
            this.gb_commersilation.Controls.Add(this.rb_comme_No);
            this.gb_commersilation.Controls.Add(this.rb_comme_Oui);
            this.gb_commersilation.Location = new System.Drawing.Point(231, 459);
            this.gb_commersilation.Margin = new System.Windows.Forms.Padding(4);
            this.gb_commersilation.Name = "gb_commersilation";
            this.gb_commersilation.Padding = new System.Windows.Forms.Padding(4);
            this.gb_commersilation.Size = new System.Drawing.Size(361, 76);
            this.gb_commersilation.TabIndex = 92;
            this.gb_commersilation.TabStop = false;
            // 
            // rb_comme_No
            // 
            this.rb_comme_No.AutoSize = true;
            this.rb_comme_No.BackColor = System.Drawing.Color.Transparent;
            this.rb_comme_No.Depth = 0;
            this.rb_comme_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_comme_No.Location = new System.Drawing.Point(195, 18);
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
            this.rb_comme_Oui.Location = new System.Drawing.Point(64, 20);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 91;
            this.label2.Text = "Commercialisation :";
            // 
            // gb_list
            // 
            this.gb_list.Controls.Add(this.rb_list3);
            this.gb_list.Controls.Add(this.rb_list2);
            this.gb_list.Controls.Add(this.rb_list1);
            this.gb_list.Location = new System.Drawing.Point(163, 384);
            this.gb_list.Margin = new System.Windows.Forms.Padding(4);
            this.gb_list.Name = "gb_list";
            this.gb_list.Padding = new System.Windows.Forms.Padding(4);
            this.gb_list.Size = new System.Drawing.Size(429, 76);
            this.gb_list.TabIndex = 90;
            this.gb_list.TabStop = false;
            // 
            // rb_list3
            // 
            this.rb_list3.AutoSize = true;
            this.rb_list3.BackColor = System.Drawing.Color.Transparent;
            this.rb_list3.Depth = 0;
            this.rb_list3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_list3.Location = new System.Drawing.Point(263, 20);
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
            this.rb_list2.Location = new System.Drawing.Point(132, 20);
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
            this.rb_list1.Location = new System.Drawing.Point(17, 20);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 89;
            this.label1.Text = "List :";
            // 
            // gb_type
            // 
            this.gb_type.Controls.Add(this.rb_typ_principe);
            this.gb_type.Controls.Add(this.rb_type_generique);
            this.gb_type.Location = new System.Drawing.Point(163, 300);
            this.gb_type.Margin = new System.Windows.Forms.Padding(4);
            this.gb_type.Name = "gb_type";
            this.gb_type.Padding = new System.Windows.Forms.Padding(4);
            this.gb_type.Size = new System.Drawing.Size(429, 76);
            this.gb_type.TabIndex = 88;
            this.gb_type.TabStop = false;
            // 
            // rb_typ_principe
            // 
            this.rb_typ_principe.AutoSize = true;
            this.rb_typ_principe.BackColor = System.Drawing.Color.Transparent;
            this.rb_typ_principe.Depth = 0;
            this.rb_typ_principe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_typ_principe.Location = new System.Drawing.Point(263, 20);
            this.rb_typ_principe.Margin = new System.Windows.Forms.Padding(0);
            this.rb_typ_principe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rb_typ_principe.MouseState = MaterialSkin.MouseState.HOVER;
            this.rb_typ_principe.Name = "rb_typ_principe";
            this.rb_typ_principe.Ripple = true;
            this.rb_typ_principe.Size = new System.Drawing.Size(96, 37);
            this.rb_typ_principe.TabIndex = 1;
            this.rb_typ_principe.TabStop = true;
            this.rb_typ_principe.Text = "Princeps";
            this.rb_typ_principe.UseVisualStyleBackColor = false;
            // 
            // rb_type_generique
            // 
            this.rb_type_generique.AutoSize = true;
            this.rb_type_generique.BackColor = System.Drawing.Color.Transparent;
            this.rb_type_generique.Depth = 0;
            this.rb_type_generique.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rb_type_generique.Location = new System.Drawing.Point(17, 20);
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
            this.label12.Location = new System.Drawing.Point(25, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 82;
            this.label12.Text = "Form :";
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
            this.tb_dossage.Location = new System.Drawing.Point(163, 249);
            this.tb_dossage.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dossage.MaxLength = 50;
            this.tb_dossage.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_dossage.Multiline = false;
            this.tb_dossage.Name = "tb_dossage";
            this.tb_dossage.Size = new System.Drawing.Size(429, 36);
            this.tb_dossage.TabIndex = 87;
            this.tb_dossage.Text = "";
            this.tb_dossage.TrailingIcon = null;
            this.tb_dossage.UseTallSize = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Nom Med :";
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
            this.tb_form.Location = new System.Drawing.Point(163, 181);
            this.tb_form.Margin = new System.Windows.Forms.Padding(4);
            this.tb_form.MaxLength = 50;
            this.tb_form.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_form.Multiline = false;
            this.tb_form.Name = "tb_form";
            this.tb_form.Size = new System.Drawing.Size(429, 36);
            this.tb_form.TabIndex = 86;
            this.tb_form.Text = "";
            this.tb_form.TrailingIcon = null;
            this.tb_form.UseTallSize = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "Dossage :";
            // 
            // tb_nomMed
            // 
            this.tb_nomMed.AnimateReadOnly = false;
            this.tb_nomMed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nomMed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_nomMed.Depth = 0;
            this.tb_nomMed.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_nomMed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_nomMed.Hint = "tapez ici....";
            this.tb_nomMed.LeadingIcon = null;
            this.tb_nomMed.Location = new System.Drawing.Point(163, 100);
            this.tb_nomMed.Margin = new System.Windows.Forms.Padding(4);
            this.tb_nomMed.MaxLength = 50;
            this.tb_nomMed.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_nomMed.Multiline = false;
            this.tb_nomMed.Name = "tb_nomMed";
            this.tb_nomMed.Size = new System.Drawing.Size(361, 36);
            this.tb_nomMed.TabIndex = 85;
            this.tb_nomMed.Text = "";
            this.tb_nomMed.TrailingIcon = null;
            this.tb_nomMed.UseTallSize = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Type :";
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
            this.tb_refMed.Location = new System.Drawing.Point(167, 42);
            this.tb_refMed.Margin = new System.Windows.Forms.Padding(4);
            this.tb_refMed.MaxLength = 50;
            this.tb_refMed.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_refMed.Multiline = false;
            this.tb_refMed.Name = "tb_refMed";
            this.tb_refMed.Size = new System.Drawing.Size(227, 36);
            this.tb_refMed.TabIndex = 84;
            this.tb_refMed.Text = "";
            this.tb_refMed.TrailingIcon = null;
            this.tb_refMed.UseTallSize = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 25);
            this.label11.TabIndex = 81;
            this.label11.Text = "Ref Med :";
            // 
            // Edit_table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 728);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_table";
            this.Text = "Edit_table";
            this.Load += new System.EventHandler(this.Edit_table_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gb_rembo.ResumeLayout(false);
            this.gb_rembo.PerformLayout();
            this.gb_commersilation.ResumeLayout(false);
            this.gb_commersilation.PerformLayout();
            this.gb_list.ResumeLayout(false);
            this.gb_list.PerformLayout();
            this.gb_type.ResumeLayout(false);
            this.gb_type.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_update;
        private MaterialSkin.Controls.MaterialButton BTN_Annuler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label15;
        private MaterialSkin.Controls.MaterialComboBox cb_Dci;
        private System.Windows.Forms.Label label14;
        private MaterialSkin.Controls.MaterialComboBox cb_classThera;
        private System.Windows.Forms.Label label13;
        private MaterialSkin.Controls.MaterialComboBox cb_classPharma;
        private System.Windows.Forms.Label tb_lab;
        private MaterialSkin.Controls.MaterialComboBox cb_lab;
        private MaterialSkin.Controls.MaterialTextBox tb_PPA;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox tb_tarif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gb_rembo;
        private MaterialSkin.Controls.MaterialRadioButton rb_remb_no;
        private MaterialSkin.Controls.MaterialRadioButton rb_rembo_yes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gb_commersilation;
        private MaterialSkin.Controls.MaterialRadioButton rb_comme_No;
        private MaterialSkin.Controls.MaterialRadioButton rb_comme_Oui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_list;
        private MaterialSkin.Controls.MaterialRadioButton rb_list3;
        private MaterialSkin.Controls.MaterialRadioButton rb_list2;
        private MaterialSkin.Controls.MaterialRadioButton rb_list1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_type;
        private MaterialSkin.Controls.MaterialRadioButton rb_typ_principe;
        private MaterialSkin.Controls.MaterialRadioButton rb_type_generique;
        private System.Windows.Forms.Label label12;
        private MaterialSkin.Controls.MaterialTextBox tb_dossage;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox tb_form;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialTextBox tb_nomMed;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox tb_refMed;
        private System.Windows.Forms.Label label11;
    }
}