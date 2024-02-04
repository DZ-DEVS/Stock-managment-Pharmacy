using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Pharma_Libarary.Data;
using Pharma_Libarary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharma_Libarary.Model;
using Pharma_Libarary.Data;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
using Microsoft.IdentityModel.Tokens;
using User_Interface.Ui_classes;

namespace User_Interface.forms
{
    public partial class frm_main : MaterialForm
    {

        public frm_main()
        {


            InitializeComponent();

            MaterialFormTheme.ApplyTheme(this);
            


           

        }


     




        private void frm_main_Load(object sender, EventArgs e)
        {


            //filldatatable<Medicament>();
            //filldatatable<Selle>(dgb_soldMed);
            
            
            tab_control.SelectedTab = tp_alert;

            


        }

        /// <summary>
        /// use this to fill combo box withh all talbe infos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="comboBox"></param>
        /// <param name="name"> champs t 3 </param>
        /// <param name="id">primary key</param>

        private void intialiazeCountries<T>(MaterialComboBox comboBox, string name, string id) where T : class
        {
            using (var dbContext = new dbcontext())
            {
                var table = dbContext.Set<T>().ToList();

                // Assuming 'name' property is a string property in the class T
                // You can modify this based on your actual class structure
                table = table.OrderBy(item => item.GetType().GetProperty(name)?.GetValue(item, null) as string).ToList();

                comboBox.DataSource = table;
                comboBox.DisplayMember = name;
                comboBox.ValueMember = id;
            }
        }





        /// <summary>
        /// fetch data from a specifi table
        /// </summary>
        /// <typeparam name="T">db classes</typeparam>
        /// <param name="dgv"> data grid view </param>
        /// 


        private void fillListView<T>(ListView listView) where T : class
        {
            if (listView == null)
            {
                throw new ArgumentNullException(nameof(listView), "ListView cannot be null.");
            }

            using (dbcontext context = new dbcontext())
            {
                var data = context.Set<T>().ToList();

                foreach (var item in data)
                {
                    var listViewItem = new ListViewItem();

                    // Get the value of the "pay_nom" property
                    var payNomProperty = typeof(T).GetProperty("pay_nom");

                    if (payNomProperty != null)
                    {
                        var payNomValue = payNomProperty.GetValue(item);

                        // Set the item text directly for the first column
                        listViewItem.Text = payNomValue?.ToString();

                        // Add the ListViewItem to the ListView
                        listView.Items.Add(listViewItem);
                    }
                }
            }
        }















        private void tab_control_Selecting(object sender, TabControlCancelEventArgs e)
        {

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (e.TabPage.Name)
                {
                    case "tabPage1":
                        // Perform actions for tabPage1 if needed
                        e.Cancel = true;
                        break;

                    case "tabPage2":
                        e.Cancel = true;
                        break;

                    case "tabPage3":
                        e.Cancel = true;
                        break;

                    case "tabPage5":
                        e.Cancel = true;
                        break;

                    case "tabPage6":
                        e.Cancel = true;
                        break;

                    case "tabPage4":
                        e.Cancel = true;
                        break;

                    case "tabPage7":
                        e.Cancel = true;
                        break;


                    case "tp_list_stock":
                        fillListView_Stock();
                        //fillListView<Pay>(lv_listStock);
                        break;

                    case "tp_admin":
                        
                        //WinformClassLibrary.LoadButtonOnListView(lv_listStock, 5);




                        break;

                    case "tp_lab":
                        intialiazeCountries<Pay>(cb_pay, "pay_nom", "Pays_code");
                        break;

                }
            }
            finally 
            {

                Cursor.Current = Cursors.Default;
            }
            


        }
        private void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked " + e.SubItem.Text);
        }

        private void OnButtonInThirdColumnClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show(this, @"you clicked button in the third column");
        }
        public void fillListView_Stock()
        {
            // Create an instance of ListViewExtender
            ListViewExtender extender = new ListViewExtender(lv_listStock);

            // Extend the 2nd column
            ListViewButtonColumn buttonAction = new ListViewButtonColumn(1);
            buttonAction.Click += OnButtonActionClick;
            buttonAction.ImageFilePath = "C:\\Users\\bouro\\Downloads\\edit-_1_.bmp";
            buttonAction.FixedWidth = true;

            // Extend the 3rd column
            ListViewButtonColumn buttonInThirdColumn = new ListViewButtonColumn(2);
            buttonInThirdColumn.Click += OnButtonInThirdColumnClick;
            buttonInThirdColumn.ImageFilePath = "C:\\Users\\bouro\\Downloads\\delete.bmp"; // Specify the path to your image
            buttonInThirdColumn.FixedWidth = true;

            // Add the columns to the extender
            extender.AddColumn(buttonAction);
            extender.AddColumn(buttonInThirdColumn);
            // Populate the ListView
            for (int i = 0; i < 5; i++)
            {
                ListViewItem item = lv_listStock.Items.Add("" + i);
                item.SubItems.Add(" ");
                item.SubItems.Add(" "); // Add an extra subitem for the third column
            }
        }


        public bool validateallInputs(params MaterialTextBox[] tbs) {

            foreach (MaterialTextBox t in tbs)
            {

                if (t.Text.Length == 0) 
                { 
                   return false; 
                }
             

            }
  
            return true;
        }


        private void clear_fields(GroupBox gb,params MaterialTextBox[] tbs) 
        {
        
            foreach (MaterialTextBox t in tbs)
            {

                t.Text = "";

            }

           if(gb != null)
            foreach (RadioButton c in gb.Controls) 

            {
                c.Checked = false; 
            }

           
        }


        private bool validatphoneNumber(string phone)
        {

            if (string.IsNullOrEmpty(phone)) return false;
            if (phone.Length != 10) return false;
            if (phone[0] != '0') return false;




            return true;
        }

        


        

        private void tb_addLab_Click(object sender, EventArgs e)
        {

            if (!validateallInputs(tb_nomLab, tb_adress, tb_codeLab))
            {
                MessageBox.Show("Please make sure to fill all neccassery shit");
                return;
            }
            if (!validatphoneNumber(tb_phone.Text)) 
            { 
                MessageBox.Show("invalid phone number"); 
                clear_fields(null, tb_phone); return;  
            }

            


            Laboratoire lab = new Laboratoire
            {
                
              Lab_code = tb_codeLab.Text,
              Lab_nom = tb_nomLab.Text,
              Adress = tb_adress.Text,
              tel = tb_phone.Text,
              web_adress = tb_webAdress.Text,
              //error hna
              pay_code = cb_pays.SelectedText,


            };

            if (sql_connection.add_Lab(lab))
            {
                MessageBox.Show("Lab added succefuly UwU"); clear_fields(null,tb_nomLab,tb_adress,tb_codeLab,tb_phone,tb_webAdress);
            }
            else MessageBox.Show("error adding user , wtf did u do");clear_fields(null,tb_nomLab,tb_adress,tb_codeLab,tb_phone,tb_webAdress);







        }

        private void tb_nomLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {
               
                e.Handled = true;
            }
        }

        private void tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.')
            {

                e.Handled = true;
            }
        }

        

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            diag_addClass frm = new diag_addClass();
            frm.ShowDialog();
            if (frm.DialogResult==DialogResult.OK)
            {
                // TODO: reload all three classes
                MessageBox.Show("saved");
            }
            
        }

        

        private void rb_darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_darkTheme.Checked)
            {
                MaterialFormTheme.ApplyDarkTheme();
            }
            else MaterialFormTheme.ApplyLightTheme();
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN_ajouterPerso_Click_1(object sender, EventArgs e)
        {
            if (!validateallInputs(tb_username, tb_Nom, tb_motpass, tb_prenom))
            {
                MessageBox.Show("Please make sure to fill all neccassery shit");
                return;
            }
            if (!rb_rembo_admin.Checked && !rb_remb_emp.Checked)
            {
                MessageBox.Show("Please make sure to select a role ");
                return;
            }

            if (tb_motpass.Text.Length < 8)
            {
                MessageBox.Show("For security reason , the passowrd must me atleast 8 chars long "); clear_fields(null, tb_motpass, tb_conPass);
                return;
            }

            if (tb_motpass.Text != tb_conPass.Text)
            {
                MessageBox.Show("password Doesnt match"); clear_fields(null, tb_motpass, tb_conPass);
                return;
            }

            if (!tb_webAdress.Text.Equals(""))
                
            {

                if (!tb_webAdress.Text.Contains('@') || !tb_webAdress.Text.Contains('.')) {

                    MessageBox.Show("invalid web adress"); clear_fields(null, tb_webAdress);
                    return;
                }
                   
            }
            bool admin = false;
            if (rb_rembo_admin.Checked) admin=true;
            User user = new User
            {
                userName = tb_username.Text,
                nom = tb_Nom.Text,
                prenom = tb_prenom.Text,
                password = tb_motpass.Text,
                isAdmin = admin,


            };

            if (sql_connection.add_newUser(user))
            {
                MessageBox.Show("User added succefuly UwU"); clear_fields(groupBox_role, tb_username, tb_Nom, tb_motpass, tb_prenom, tb_conPass);
            }
            else MessageBox.Show("error adding user , wtf did u do"); clear_fields(groupBox_role, tb_username, tb_Nom, tb_motpass, tb_prenom, tb_conPass);

        }

        private void tp_admin_second_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (e.TabPage.Name)
                {
                    case "tp_lab":
                        intialiazeCountries<Pay>(cb_pay, "pay_nom", "Pays_code");
                        break;


                    case "tp_produit":
                        intialiazeCountries<Pay>(cb_pays, "pay_nom", "Pays_code");
                        break;

                }
            }
            finally 
            {

                Cursor.Current = Cursors.Default;
            }
            
        }
    }



}                                          