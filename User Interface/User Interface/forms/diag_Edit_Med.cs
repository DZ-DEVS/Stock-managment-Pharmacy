using Azure;
using MaterialSkin;
using MaterialSkin.Controls;
using Pharma_Libarary.Data;
using Pharma_Libarary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.forms
{
    public partial class diag_Edit_Med : Form
    {
        string Ref_med;
        // todo : link user in edit med diag
        User thisUser = new User("admin", "06122099youcef           ", "youcef         ", "youcef         ", true);
        public diag_Edit_Med(String Id_forEditing)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue50, Primary.LightBlue700, Accent.LightBlue700, TextShade.WHITE);
            WinformClassLibrary.intialiaze_ComboBox<Laboratoire>(cb_lab, "Lab_code", "Lab_nom");
            WinformClassLibrary.intialiaze_ComboBox<Classe_pharmacologique>(cb_classPharma, "nom_Cpharma", "nom_Cpharma");
            WinformClassLibrary.intialiaze_ComboBox<Classe_thérapeutique>(cb_classThera, "code_Cthera", "code_Cthera");
            WinformClassLibrary.intialiaze_ComboBox<DCI>(cb_Dci, "nom_DCI", "nom_DCI");
            WinformClassLibrary.intialiaze_ComboBox<Pay>(cb_pays,"pay_nom", "Pays_code");
            Ref_med = Id_forEditing;
            
            

            //MaterialFormTheme.ApplyTheme(this);

        }
        private MaterialRadioButton returnCheckedRadio(GroupBox gp)
        {

            foreach (MaterialRadioButton rb in gp.Controls)
            {

                if (rb.Checked)
                {
                    return rb;
                }

            }

            return null;
        }
        
        private void materialButton9_Click(object sender, EventArgs e)
        {
            WinformClassLibrary.set_textBoxNullValuesTO(panel1);
            Medicament med = new Medicament(tb_ref_med.Text,
                tb_nomMed.Text,
                tb_form.Text,
                tb_dossage.Text,
                tb_conditionemnt.Text,

                Convert.ToDecimal(tb_PPA.Text),
                Convert.ToDecimal(tb_tarif.Text),
                (Laboratoire)cb_lab.SelectedItem,
                (Classe_pharmacologique)cb_classPharma.SelectedItem,
                (Classe_thérapeutique)cb_classThera.SelectedItem,
                (DCI)cb_Dci.SelectedItem,
                thisUser);

            if (rb_comme_Oui.Checked)
            {
                med.Commercialisation = true;
            }
            else med.Commercialisation = false;

            if (rb_rembo_yes.Checked)
            {
                med.Remboursable = true;
            }
            else if (rb_remb_no.Checked)
            {
                med.Remboursable = false;
            }
            else med.Remboursable = null;

            if (rb_type_generique.Checked)
            {
                med.Type = true;
                // todo: add dialog to select original med 

            }
            else med.Type = false;
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
            sql_connection.edit_Med(med);
            DialogResult= DialogResult.OK;
            this.Close();
        }
        Medicament med = new Medicament();
        private void diag_addNewProduct_Load(object sender, EventArgs e)
        {
            if (Ref_med !=null)
            {
                med = sql_connection.load_med(Ref_med);
                tb_ref_med.Text = med.Ref_med;
                tb_nomMed.Text = med.nom_comrsl;
                tb_dossage.Text = med.Dossage;
                tb_PPA.Text = med.PPA.ToString();
                tb_tarif.Text = med.Tarif.ToString();
                tb_lab.Text = med.Lab_code.ToString();
                tb_form.Text = med.Form.ToString();


                if ((bool)med.Remboursable) { rb_rembo_yes.Checked = true; } else rb_remb_no.Checked = true;
                if ((bool)med.Commercialisation) { rb_comme_Oui.Checked = true; } else rb_comme_No.Checked = true;
                if ((bool)med.Type) { rb_type_generique.Checked = true; } else rb_typ_principe.Checked = true;

                if (med.Liste == "List1") rb_list1.Checked = true;
                else if (med.Liste == "List2") rb_list2.Checked = true;
                else rb_list3.Checked = true;


                cb_lab.SelectedItem = cb_lab.Items.Cast<Laboratoire>().FirstOrDefault(item => item.Lab_code == med.Lab_code);
                cb_Dci.SelectedItem = cb_Dci.Items.Cast<DCI>().FirstOrDefault(item => item.nom_DCI == med.nom_DCI);
                cb_classPharma.SelectedItem = cb_classPharma.Items.Cast<Classe_pharmacologique>().FirstOrDefault(item => item.nom_Cpharma == med.nom_Cpharma);
                cb_classThera.SelectedItem = cb_classThera.Items.Cast<Classe_thérapeutique>().FirstOrDefault(item => item.code_Cthera == med.code_Cthera);

            }
        }
    }
}
