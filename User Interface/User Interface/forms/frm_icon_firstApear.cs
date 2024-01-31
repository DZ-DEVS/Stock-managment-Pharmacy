using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface.forms
{
    public partial class frm_icon_firstApear : Form
    {
        public frm_icon_firstApear()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            
            InitializeAsync();
            
            //frm.Show();
        }
        private async void InitializeAsync()
        {
            // Add any initialization code here

            // Introduce a delay of 3 seconds
            await Task.Delay(1500);
            this.Hide();
            frm_login frm = new frm_login();
            frm.Show();
            // Continue with the rest of your initialization code or any other logic
        }
        private void frm_icon_firstApear_Load(object sender, EventArgs e)
        {
            

        }
    }
}
