using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharma_Libarary.Model;
using Bogus;
using MaterialSkin.Controls;

namespace User_Interface.forms
{
    public partial class Edit_table : Form
    {



        public string Ref_med { get; set; }

  
  















        public Edit_table()
        {
            InitializeComponent();
            frm_main frm = new frm_main();
            frm.intialiazeCountries<Laboratoire>(cb_lab, "Lab_code", "Lab_nom");
            frm.intialiazeCountries<Classe_pharmacologique>(cb_classPharma, "nom_Cpharma", "nom_Cpharma");
            frm.intialiazeCountries<Classe_thérapeutique>(cb_classThera, "code_Cthera", "code_Cthera");
            frm.intialiazeCountries<DCI>(cb_Dci, "nom_DCI", "nom_DCI");
        }

    

        private void Edit_table_Load(object sender, EventArgs e)
        {
            using(dbcontext db = new dbcontext())
            {
             

                var selectedchamps = db.Medicaments
               .Where(entity => entity.Ref_med == Ref_med)
               .ToList();

                foreach (var champs in selectedchamps)
                {
                    tb_refMed.Text = champs.Ref_med;
                    tb_nomMed.Text = champs.nom_comrsl;
                    tb_dossage.Text = champs.Dossage;
                    tb_PPA.Text = champs.PPA.ToString();
                    tb_tarif.Text = champs.Tarif.ToString();
                    tb_lab.Text = champs.Lab_code.ToString();
                    tb_form.Text = champs.Form.ToString();


                    if ((bool)champs.Remboursable) { rb_rembo_yes.Checked = true; }else rb_remb_no.Checked = true;
                    if((bool)champs.Commercialisation) { rb_comme_Oui.Checked = true; } else rb_comme_No.Checked = true;
                    if ((bool)champs.Type) { rb_type_generique.Checked = true; } else rb_typ_principe.Checked = true;





                    cb_lab.SelectedItem = champs.Lab_code;
                    cb_Dci.SelectedItem = champs.nom_DCI;
                    cb_classPharma.SelectedItem = champs.nom_Cpharma;
                    cb_classThera.SelectedItem = champs.code_Cthera;





                }


            }
        }

 

        private void btn_update_Click(object sender, EventArgs e)
        {
            using (dbcontext db = new dbcontext())
            {
                var update = db.Medicaments.Find(Ref_med);

              
                   
                    update.Ref_med = tb_refMed.Text;
                    update.nom_comrsl = tb_nomMed.Text;
                    update.Dossage = tb_dossage.Text;
                    update.PPA = Convert.ToDecimal(tb_PPA.Text);
                    update.Tarif = Convert.ToDecimal(tb_tarif.Text);

                    update.Lab_code = tb_lab.Text;
                    update.Form = tb_form.Text;
                    
                    if(returnCheckedRadio(gb_rembo).Text == "Oui") update.Remboursable = true; else update.Remboursable = false;
                    if (returnCheckedRadio(gb_type).Text == "Générique") update.Type = true; else update.Type = false;
                    if (returnCheckedRadio(gb_commersilation).Text == "oui") update.Commercialisation = true; else update.Commercialisation = false;

                    update.Lab_code = cb_lab.SelectedItem.ToString();
                    update.nom_Cpharma = cb_classPharma.SelectedItem.ToString();
                    update.nom_DCI = cb_Dci.SelectedItem.ToString();
                    update.code_Cthera = cb_classThera.SelectedItem.ToString();




                    db.SaveChanges();

                    MessageBox.Show("produit a ete modifier");
                


                db.SaveChanges();
            }

        }


        private MaterialRadioButton returnCheckedRadio( GroupBox gp)
        {

            foreach(MaterialRadioButton rb in gp.Controls)
            {

                if (rb.Checked)
                {
                    return rb;
                }

            }

            return null;
        }

    }
}
