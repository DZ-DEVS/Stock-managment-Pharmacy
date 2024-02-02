using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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

namespace User_Interface.forms
{
    public partial class frm_main : MaterialForm
    {
        public frm_main()
        {


            InitializeComponent();
            MaterialFormTheme.ApplyTheme(this);
            //MaterialFormTheme.ApplyMenuStripTheme(menuStrip_pageAdmin,menuStrip_pageAlerts);
            
            
          
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

            
            //filldatatable<Medicament>();
            //filldatatable<Selle>(dgb_soldMed);
            fillListView<Pay>(lv_listStock);

            tab_control.SelectedTab = tp_alert;



        }





        /// <summary>
        /// fetch data from a specifi table
        /// </summary>
        /// <typeparam name="T">db classes</typeparam>
        /// <param name="dgv"> data grid view </param>
        /// 


        private void fillListView<T>(ListView listView) where T : class
        {
            if (listView == null)
            {
                throw new ArgumentNullException(nameof(listView), "ListView cannot be null.");
            }

            using (dbcontext context = new dbcontext())
            {
                var data = context.Set<T>().ToList();

                foreach (var item in data)
                {
                    var listViewItem = new ListViewItem();

                    // Get the value of the "pay_nom" property
                    var payNomProperty = typeof(T).GetProperty("pay_nom");

                    if (payNomProperty != null)
                    {
                        var payNomValue = payNomProperty.GetValue(item);

                        // Set the item text directly for the first column
                        listViewItem.Text = payNomValue?.ToString();

                        // Add the ListViewItem to the ListView
                        listView.Items.Add(listViewItem);
                    }
                }
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

        private void tab_control_Selecting(object sender, TabControlCancelEventArgs e)
        {


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

            }       
            

        }
        
        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

       

                                                  