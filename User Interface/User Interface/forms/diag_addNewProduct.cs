using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.forms
{
    public partial class diag_addNewProduct : Form
    {
        public diag_addNewProduct()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue50, Primary.LightBlue700, Accent.LightBlue700, TextShade.WHITE);

            //MaterialFormTheme.ApplyTheme(this);
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialComboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_type_generique_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_list1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_list2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_list3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_comme_No_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_comme_Oui_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {

        }
    }
}
