using MaterialSkin;
using MaterialSkin.Controls;
using Pharma_Libarary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Interface
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.LightBlue700, Accent.LightBlue700, TextShade.WHITE);
        }



        private void BTN_Connecter_Click(object sender, EventArgs e)
        {
            if (authLogin(tb_userName.Text, tb_password.Text))
            {
                enter_theapp();
               
            }
            else
            {
                MessageBox.Show("invalid creditianls");
                reset_textboxes(tb_userName, tb_password);
            }
        }


        /// <summary>
        /// does the login shit
        /// </summary>
        /// <param name="username">username input</param>
        /// <param name="password">pass input </param>
        /// <returns> return a bool , if it finds matching cridintials it returns true , else => faalse</returns>

        private bool authLogin(string username, string password)
        {



            /// takes
            using (dbcontext dbc = new dbcontext())
            {

                var logincrid = dbc.Users.FirstOrDefault(e => e.userName == username && e.password == password);


                return logincrid != null;


            }




        }

        /// <summary>
        /// creates a frame
        /// </summary>
        private void enter_theapp()
        {

            MainPage mp = new MainPage();

            mp.Show();

            this.Close();




        }
        /// <summary>
        /// rests the textbots for a new try at loging in
        /// </summary>
        /// <param name="textBoxes"></param>
        private void reset_textboxes(params MaterialTextBox[] textBoxes)
        {

            foreach (MaterialTextBox tb in textBoxes)
            {


                tb.Text = "";


            }


        }

     
    }
}
