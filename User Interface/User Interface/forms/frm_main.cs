using MaterialSkin;
using MaterialSkin.Controls;
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

namespace User_Interface.forms
{
    public partial class frm_main : MaterialForm
    {
        public frm_main()
        {


            InitializeComponent();
            MaterialFormTheme.ApplyTheme(this);
            MaterialFormTheme.ApplyMenuStripTheme(menuStrip_pageAdmin,menuStrip_pageAlerts);
            
            
          
        }

        private void frm_main_Load(object sender, EventArgs e)
        {


            filldatatable<Medicament>(dgv_stocklist);
            filldatatable<Selle>(dgb_soldMed);
   
            tp_home.Focus();
         

      
        }





        /// <summary>
        /// fetch data from a specifi table
        /// </summary>
        /// <typeparam name="T">db classes</typeparam>
        /// <param name="dgv"> data grid view </param>
        /// 


        private void filldatatable<T>(DataGridView dgv) where T : class
        {

            using (dbcontext context = new dbcontext())
            {
                var data = context.Set<T>().ToList();
                dgv.DataSource = data;
            }




        }

        private void tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Text = tab_control.SelectedTab.Text;
        }

      

        private void eMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajouterMedicinToolStripMenuItem_Click(object sender, EventArgs e)
        {
     
        }




        private void HideUserControls(params UserControl[] userControls)
        {
            foreach(UserControl us in userControls)
            {


                us.Hide();


            }
            


        }

  

        }
    }

       

