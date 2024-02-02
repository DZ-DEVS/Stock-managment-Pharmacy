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
<<<<<<< HEAD
            MaterialFormTheme.ApplyMenuStripTheme(menuStrip_pageAdmin, menuStrip_pageAlerts);
            MaterialFormTheme.ApplyHeaderSkin(labelheader_EMP,labelheader_gene,labelheader_produit1,label_headerlabo);



=======
            //MaterialFormTheme.ApplyMenuStripTheme(menuStrip_pageAdmin,menuStrip_pageAlerts);
            
            
          
>>>>>>> 744d095ff054ddbaea682d803e0803bfcdd02b9f
        }

        private void frm_main_Load(object sender, EventArgs e)
        {


            filldatatable<Medicament>(dgv_stocklist);
            filldatatable<Selle>(dgb_soldMed);
<<<<<<< HEAD
            HideUserControls(panel_addemp,panel_addgen,panel_addpro,panel_addLabo);
            tp_home.Focus();

=======

            tab_control.SelectedTab = tp_alert;


>>>>>>> 744d095ff054ddbaea682d803e0803bfcdd02b9f


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




        private void HideUserControls(params Panel[] panels)
        {
            foreach (Panel p in panels)
            {


                p.Hide();


            }



        }
        /// <summary>
        /// make it in a clss later
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterLabToolStripMenuItem_Click(object sender, EventArgs e)
       {
            var clickedSecondaryTab = sender as System.Windows.Forms.ToolStripMenuItem;

<<<<<<< HEAD
            Dictionary<System.Windows.Forms.ToolStripMenuItem, Panel> clickingMap = new Dictionary<ToolStripMenuItem, Panel>
    {
        {ajouterGeniriqueToolStripMenuItem, panel_addgen},
        {ajouterMedicinToolStripMenuItem, panel_addpro},
        {ajouterToolStripMenuItem,panel_addemp},
        {ajouterLabToolStripMenuItem, panel_addLabo}
    };

            if (clickingMap.ContainsKey(clickedSecondaryTab))
            {
                Panel targetedPanel = clickingMap[clickedSecondaryTab];

                if (tp_admin.Controls.Count > 1)
                {
                    foreach (Control otherPanels in tp_admin.Controls)
                    {
                        if (otherPanels is Panel)
                        {
                            if (otherPanels != targetedPanel)
                            {
                                otherPanels.Visible = false;
                            }
                        }
                    }

                    targetedPanel.Visible = true;
                }
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void panel_addpro_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
  
=======
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
    }
    }

       
>>>>>>> 744d095ff054ddbaea682d803e0803bfcdd02b9f

