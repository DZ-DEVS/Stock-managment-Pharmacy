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
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;
using Microsoft.IdentityModel.Tokens;
using ReactiveUI;
using Button = System.Windows.Forms.Button;
using Bogus;
using User_Interface.Properties;
using Microsoft.EntityFrameworkCore;

namespace User_Interface.forms
{
    public partial class frm_main : MaterialForm
    {
        readonly User thisUser = new User("admin", "06122099youcef           ", "youcef         ", "youcef         ", true);
        int indexListviewStock = 0;
        int numberOfpagesStock = (int)Math.Ceiling((double)Sql_connection.MedListCount() / 10);
        int currentPaageStock = 1;
        


        public frm_main()
        {


            InitializeComponent();
            MaterialFormTheme.ApplyTheme(this);
            lb_pageIndex.Text = currentPaageStock + "/" + numberOfpagesStock;
        }

        private void Frm_main_Load(object sender, EventArgs e)
        {
            //test<User>(listview_khdamin,200, "nom", "prenom", "username");
            tab_control.SelectedTab = tp_list_stock;
        }



       
        
        
        private void Tab_control_Selecting(object sender, TabControlCancelEventArgs e)
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

                        WinformClassLibrary.Load_Med_ToListView_withButton(lv_listStock,indexListviewStock);
                        //WinformClassLibrary.cleanListview(lv_listStock);
                        break;

                    case "tp_lab":
                        WinformClassLibrary.Intialiaze_ComboBox<Pay>(cb_pay, "pay_nom", "Pays_code");
                        break;

                }
            }
            finally 
            {

                Cursor.Current = Cursors.Default;
            }
            


        }
        


        public bool ValidateallInputs(params MaterialTextBox[] tbs)
        {
            foreach (MaterialTextBox t in tbs)
            {
                if (t.Text.Length == 0) 
                { 
                   return false; 
                }
            }
  
            return true;
        }


        private void Clear_fields(GroupBox gb,params MaterialTextBox[] tbs) 
        {
            tbs.ToList().ForEach(t => t.Text = "");

            if (gb != null)
            foreach (RadioButton c in gb.Controls) c.Checked = false;
        }


        private bool ValidatphoneNumber(string phone)
        {
            if (string.IsNullOrEmpty(phone)) return false;
            if (phone.Length != 10) return false;
            if (phone[0] != '0') return false;
            return true;
        }

        private void Tb_addLab_Click(object sender, EventArgs e)
        {
            
            if (!ValidateallInputs(tb_nomLab, tb_adress, tb_codeLab))
            {
                MessageBox.Show("Please make sure to fill all neccassery shit");
                return;
            }
            if (!ValidatphoneNumber(tb_phone.Text)) 
            { 
                MessageBox.Show("invalid phone number"); 
                Clear_fields(null, tb_phone); return;  
            }
            Laboratoire lab = new Laboratoire( tb_codeLab.Text,
                tb_nomLab.Text,
                tb_adress.Text,
                tb_phone.Text,
                tb_webAdress.Text,
                (Pay) cb_pay.SelectedItem);
            Sql_connection.Add_Lab(lab);
        }

        private void Tb_nomLab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.') e.Handled = true;
        }

        private void Tb_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.') e.Handled = true;
        }

        

        private void Btn_addClass_Click(object sender, EventArgs e)
        {
            diag_Add_Class frm = new diag_Add_Class();
            frm.ShowDialog();
            if (frm.DialogResult==DialogResult.OK)
            {
                // TODO: reload all three classes
                MessageBox.Show("saved");
                WinformClassLibrary.Intialiaze_ComboBox<Laboratoire>(cb_lab, "Lab_code", "Lab_nom");
                WinformClassLibrary.Intialiaze_ComboBox<Classe_pharmacologique>(cb_classPharma, "nom_Cpharma", "nom_Cpharma");
                WinformClassLibrary.Intialiaze_ComboBox<Classe_thérapeutique>(cb_classThera, "code_Cthera", "code_Cthera");
            }
            /// todo : refresh combo box dont work check it 
        }

        

        private void Rb_darkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_darkTheme.Checked)
            {
                MaterialFormTheme.ApplyDarkTheme();
            }
            else MaterialFormTheme.ApplyLightTheme();
        }

      

        private void BTN_ajouterPerso_Click_1(object sender, EventArgs e)
        {
            
            if (!ValidateallInputs(tb_username, tb_Nom, tb_motpass, tb_prenom))
            {
                MessageBox.Show("Veuillez vous assurer de remplir tous les champs nécessaires");
                return;
            }

            if (tb_motpass.Text.Length < 8)
            {
                MessageBox.Show("Pour des raisons de sécurité, le mot de passe doit comporter au moins 8 caractères"); Clear_fields(null, tb_motpass, tb_conPass);
                return;
            }

            if (tb_motpass.Text != tb_conPass.Text)
            {
                MessageBox.Show("le mot de passe ne correspond pas"); Clear_fields(null, tb_motpass, tb_conPass);
                return;
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
            

            if (Sql_connection.Add_newUser(user))
                MessageBox.Show("Utilisateur ajouté avec succès"); Clear_fields(groupBox_role, tb_username, tb_Nom, tb_motpass, tb_prenom, tb_conPass);
            

        }

        private void Tp_admin_second_Selecting(object sender, TabControlCancelEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                switch (e.TabPage.Name)
                {
                    case "tp_lab":
                        WinformClassLibrary.Intialiaze_ComboBox<Pay>(cb_pay, "pay_nom", "Pays_code");
                        break;


                    case "tp_produit":
                        WinformClassLibrary.Intialiaze_ComboBox<Laboratoire>(cb_lab, "Lab_code", "Lab_nom");
                        WinformClassLibrary.Intialiaze_ComboBox<Classe_pharmacologique>(cb_classPharma, "nom_Cpharma", "nom_Cpharma");
                        WinformClassLibrary.Intialiaze_ComboBox<Classe_thérapeutique>(cb_classThera, "code_Cthera", "code_Cthera");
                        WinformClassLibrary.Intialiaze_ComboBox<DCI>(cb_Dci, "nom_DCI", "nom_DCI");
                        WinformClassLibrary.Intialiaze_ComboBox<Pay>(cb_pays, "pay_nom", "Pays_code");
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

        private void Btn_Useranuller_Click(object sender, EventArgs e)
        {
            Clear_fields(groupBox_role,tb_Nom,tb_motpass,tb_prenom, tb_conPass,tb_username);
        }

        private void MaterialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteditem = materialComboBox1.SelectedItem.ToString();
            MaterialFormTheme.Changecolorsetting(selecteditem);



        }
        private void Btn_addProduit_Click(object sender, EventArgs e)
        {
            WinformClassLibrary.Set_textBoxNullValuesTO(panel_add_employee);
            if (tb_tarif.Text.IsNullOrEmpty())
            {
                tb_tarif.Text = "0.00";
            }
            if (tb_ppa.Text.IsNullOrEmpty())
            {
                tb_ppa.Text = "0.00";
            }
            Medicament med = new Medicament(tb_refMed.Text,
                tb_NomMed.Text,
                tb_form.Text,
                tb_dossage.Text,
                tb_conditionemnt.Text,

                Convert.ToDecimal(tb_ppa.Text),
                Convert.ToDecimal(tb_tarif.Text),
                (Laboratoire)cb_lab.SelectedItem,
                (Classe_pharmacologique)cb_classPharma.SelectedItem,
                (Classe_thérapeutique)cb_classThera.SelectedItem,
                (DCI)cb_Dci.SelectedItem,
                thisUser);

            if (rb_comme_Oui.Checked)
            {
                med.Commercialisation = true;
            }else med.Commercialisation = false;

            if (rb_remborsable.Checked)
            {
                med.Remboursable = true;
            }
            else if (rb_non_remborsable.Checked)
            {
                med.Remboursable = false;
            }
            else med.Remboursable = null;

            if (rb_type_generique.Checked)
            {
                med.Type = true;
                // todo: add dialog to select original med 

            }else med.Type=false;
            if (rb_list1.Checked)
            {
                med.Liste = "List 1";
            }
            else if (rb_list2.Checked)
            {
                med.Liste = "List 2";
            }
            else if (rb_list3.Checked)
            {
                med.Liste = "List 3";
            }
            else med.Liste = null;
            Sql_connection.Add_Med(med);

        }

        private void Tb_tarif_KeyPress(object sender, KeyPressEventArgs e)
        {
            MaterialTextBox textBox = sender as MaterialTextBox;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                textBox.Hint = "Seuls les chiffres et les points sont autorisés."; 
                e.Handled = true;
            }
            
            if (e.KeyChar == '.' && textBox != null && textBox.Text.Contains('.'))
            {
                e.Handled = true; 
            }
        }

        private void Type_non_generique_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPaageStock < numberOfpagesStock)
            {
                btn_next.Enabled = true;
                btn_previou_s.Enabled = true;
                currentPaageStock++;
                indexListviewStock += 10;
                WinformClassLibrary.Load_Med_ToListView_withButton(lv_listStock, indexListviewStock);
                lb_pageIndex.Text = currentPaageStock + "/" + numberOfpagesStock;
            }
            else {
                btn_next.Enabled = false;
                btn_previou_s.Enabled = true;
            } 
           

        }

        private void btn_previou_s_Click(object sender, EventArgs e)
        {
            if (currentPaageStock > 1)
            {
                btn_previou_s.Enabled = true;
                btn_next.Enabled = true;
                currentPaageStock--;
                indexListviewStock -= 10;
                WinformClassLibrary.Load_Med_ToListView_withButton(lv_listStock, indexListviewStock);
                lb_pageIndex.Text = currentPaageStock + "/" + numberOfpagesStock;
            }
            else {
                btn_previou_s.Enabled = false;
                btn_next.Enabled = true;
            }  
        }
    }



}                                          