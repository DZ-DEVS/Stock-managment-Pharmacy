using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Pharma_Libarary.Data;
using Pharma_Libarary.Model;
namespace User_Interface
{
    public partial class LOGINFrame : MaterialForm
    {
        public LOGINFrame()
        {
            InitializeComponent();
            intializeMat();
        }
        /// <summary>
        /// a theme with a primary clr and secondary clr
        /// </summary>
        public void intializeMat()
        {

            var materialSkinManager = MaterialSkinManager.Instance;

            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue500, Primary.Blue300, Accent.LightBlue200, TextShade.WHITE);

        }

        private void connectionBtn_Click_1(object sender, EventArgs e)
        {

            if (authLogin(tb_userName.Text, tb_password.Text))
            {
                enter_theapp();
                this.Close();
            }
            else
            {
                MessageBox.Show("invalid creditianls");
                rest_textboxes(tb_userName, tb_password);
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


            mp.ShowDialog();

            this.Close();




        }
        /// <summary>
        /// rests the textbots for a new try at loging in
        /// </summary>
        /// <param name="textBoxes"></param>
        private void rest_textboxes(params MaterialTextBox[] textBoxes)
        {

            foreach (MaterialTextBox tb in textBoxes)
            {


                tb.Text = "";


            }


        }

       
    }
}
