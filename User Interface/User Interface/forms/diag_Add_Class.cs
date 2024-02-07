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
    public partial class diag_Add_Class : Form
    {
        
        public diag_Add_Class()
        {
            InitializeComponent();
            

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btn_saveClass_Click(object sender, EventArgs e)
        {
            // TODO : save class depend radio button 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
