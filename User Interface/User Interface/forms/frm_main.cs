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
using ReactiveUI;
using Button = System.Windows.Forms.Button;
using Bogus;
using User_Interface.Properties;
using Microsoft.EntityFrameworkCore;

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



            //test<Medicament>(lv_listStock,100,"Ref_med","nom_comrsl", "Form", "Dossage", "Conditionnement","Type", "Tarif", "Commercialisation","Lab_code","nom_Cpharma","code_Cthera", "nom_DCI");

            // test<Medicament>(lv_listStock,105, "nom_comrsl", "Form");

            //  test<User>(listview_khdamin,200, "nom", "prenom", "username");
            WinformClassLibrary.load_Med_ToListView_withButton(lv_listStock);
            tab_control.SelectedTab = tp_list_stock;
            
            


        }



        public void intialiazeCountries<T>(MaterialComboBox comboBox, string name, string id) where T : class
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







        private void fillListView<T>(ListView listView, int taille_De_champ, params string[] leschamps_de_tableux) where T : class
        {

            
            if (listView == null)
            {
                throw new ArgumentNullException(nameof(listView), "ListView cannot be null.");
            }
     
            using (dbcontext context = new dbcontext())
            {

                var data = context.Set<T>().ToList();




                foreach (var champs in leschamps_de_tableux)
                {
                    listView.Columns.Add(champs, taille_De_champ);
                }



                listView.View = View.Details;
                listView.Scrollable = true;
                listView.GridLines = true;

                foreach (var item in data)
                {
                    Button editbutton = new Button();
                    Button deletebutton = new Button();
                    var listItem = new ListViewItem();
                    
                
                    var firstitem = leschamps_de_tableux.FirstOrDefault();

                    var first_item = typeof(T).GetProperty(firstitem)?.GetValue(item)?.ToString() ?? "";
                    listItem.Text = first_item;
          


                    foreach (var subitems in leschamps_de_tableux.Skip(1))
                    {
                        var value = typeof(T).GetProperty(subitems)?.GetValue(item)?.ToString() ?? "";
                        listItem.SubItems.Add(value);

                    }

                    listView.Items.Add(listItem);
      

                            //250 //34 
                    addbutton(220,40,40,"edit",listItem,listView,editbutton);
                             //280  //34 
                    addbutton(160, 40, 40, "delete", listItem, listView, deletebutton);

               
                }

            }
        }

    



        private void addbutton(int width, int btol, int bwidth, string name, ListViewItem lvi, ListView lv, Button btn)
        {
            btn.Bounds = new Rectangle(lv.Width - width, lvi.Bounds.Top, btol, bwidth);
            btn.Text = name;
            btn.Name = name;  

            btn.Click += ButtonClick;
            btn.Tag = lvi;

          
            lv.Controls.Add(btn);
        
    }
        //we add update and delete operation in sql connection later
        // ki tclick 3la edit wla delete ysra tmnyik t3hom
        private void ButtonClick(object sender, EventArgs e)
        {
            
            Button clickedButton = sender as Button;

           
            ListViewItem listItem = (ListViewItem)clickedButton.Tag;

            string id = listItem.SubItems[0].Text;

            if (clickedButton.Name == "edit")
            {
              Edit_table edit_Table = new Edit_table();

              edit_Table.Ref_med = id;

              edit_Table.Show();

                using (dbcontext db = new dbcontext())
                {



                    Medicament md = db.Medicaments.Find(id);

                   
                        db.Medicaments.Remove(md);


                        db.SaveChanges();

                   
                    
                  

                }




            }
            
            else if (clickedButton.Name == "delete")
            {





                using (dbcontext db = new dbcontext())
                {
                    Medicament md = db.Medicaments.Find(id);

                  
                        db.Medicaments.Remove(md);

                    
                        db.SaveChanges();

                        MessageBox.Show("deleted.");
                    
                   

                }

                
            }
        }
        
        private void test<T>(ListView listView, int taille_De_champ, params string[] leschamps_de_tableux) where T : class
        {


            if (listView == null)
            {
                throw new ArgumentNullException(nameof(listView), "ListView cannot be null.");
            }

            using (dbcontext context = new dbcontext())
            {

                var data = context.Set<T>().ToList();

                listView.View = View.Details;
                listView.Scrollable = true;
                listView.GridLines = true;

                foreach (var item in data)
                {
                    
                    var listItem = new ListViewItem();

                    foreach (var subitems in leschamps_de_tableux)
                    {
                        var value = typeof(T).GetProperty(subitems)?.GetValue(item)?.ToString() ?? "";
                        listItem.SubItems.Add(value);

                    }

                    listView.Items.Add(listItem);
                    
                    

                    Button editbutton = new Button();
                    Button deletebutton = new Button();
                    listView.Controls.Add(editbutton);
                    listView.Controls.Add(deletebutton);
                    addbutton(250, 32, 32, "edit", listItem, listView, editbutton);
                    addbutton(288, 32, 32, "delete", listItem, listView, deletebutton);
                    string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    editbutton.Image = Image.FromFile(currentDirectory + "\\edit-_1_.bmp");
                    deletebutton.Image = Image.FromFile(currentDirectory + "\\delete.bmp");
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
            sql_connection.add_Lab(lab);
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

        private void BTN_rechercher_Click(object sender, EventArgs e)
        {


          
     

        }

        private void btn_Useranuller_Click(object sender, EventArgs e)
        {
            clear_fields(groupBox_role,tb_Nom,tb_motpass,tb_prenom, tb_conPass,tb_username);
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




            string selecteditem = materialComboBox1.SelectedItem.ToString();
            MaterialFormTheme.Changecolorsetting(selecteditem);



        }

        
    }



}                                          