using System;
using System.Windows.Forms;
using User_Interface.forms;
using Pharma_Libarary.Model;
using System.Data.Entity;
using System.Drawing;
using MaterialSkin.Controls;
using System.Linq;
using Pharma_Libarary.Data;
using static System.Net.Mime.MediaTypeNames;
using System.IdentityModel.Metadata;

namespace User_Interface
{
    public static class WinformClassLibrary 
    {
        public enum ClassMed
        {
            cPharma,
            cTheta,
            dci,
        }
        private static void Position_newButton(int width, int btol, int bwidth, string Type_AndID, ListViewItem lvi, ListView lv, Button btn)
        {
            btn.Bounds = new Rectangle(lv.Width - width, lvi.Bounds.Top, btol, bwidth);
            btn.Text = "";
            btn.FlatStyle = FlatStyle.Flat;
            btn.Name = Type_AndID;//e edit
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += Edit_delete_click;
        }

        private static void Edit_delete_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string[] op = clickedButton.Name.Split('/');

            if (op[0]=="d")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce médicament ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    Sql_connection.Delete_elemnt<Medicament>(op[1]);
                    
                    MessageBox.Show("le médicament a été supprimé avec succès");
                    /// 
                    //Load_Med_ToListView_with_OutButton(listGlobal);
                }
                else return;
            }
            else
            {
                diag_Edit_Med diag_Edit_Med = new diag_Edit_Med(op[1]);
                diag_Edit_Med.ShowDialog();
            }
        }

        private static void Add_button_Edit_Delete(ListView listView,string  ID,ListViewItem item)
        {
            Button editbutton = new Button();
            Button deletebutton = new Button();
          
            listView.Controls.Add(editbutton);
            listView.Controls.Add(deletebutton);
            Position_newButton(160, 34, 34, "e/"+ID, item, listView, editbutton);
            Position_newButton(200, 34, 34, "d/"+ID, item, listView, deletebutton);
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            editbutton.Image = System.Drawing.Image.FromFile(currentDirectory + "\\edit-_1_.bmp");
            deletebutton.Image = System.Drawing.Image.FromFile(currentDirectory + "\\delete.bmp");
        }
        private static ListViewItem ListviewItem_MEd(Medicament med)
        {
            var item = new ListViewItem($"{RemoveSpacesFromString(med.nom_comrsl)}, {RemoveSpacesFromString(med.Dossage)}" +
                $" ({RemoveSpacesFromString(med.Dossage)}/100ml)" +
                $" {RemoveSpacesFromString(med.Form)}, " +
                $"{RemoveSpacesFromString(med.Conditionnement)}");
            item.SubItems.Add(med.Laboratoire.Lab_nom);
            item.SubItems.Add(med.Classe_pharmacologique.nom_Cpharma);
            item.SubItems.Add(med.Classe_thérapeutique.code_Cthera);
            item.SubItems.Add((bool)med.Type ? "Générique" : "Princeps");
            item.SubItems.Add(med.Laboratoire.Pay.Pays_code == "DZD" ? "OUI" : "NON");
            item.SubItems.Add((bool)med.Remboursable ? "OUI" : "NON");
            item.SubItems.Add(med.Tarif.ToString());

            return item;
        }
        public static ListView listGlobal = new ListView();
        public static void Load_Med_ToListView_withButton(ListView listView,int start)
        {
            using (var dbContext = new dbcontext())
            {
                if (dbContext != null)
                {
                    listView.Items.Clear();
                    listView.Controls.Clear();

                    listView.Refresh();
                    var medicaments = dbContext.Medicaments
                     .OrderBy(m => m.Ref_med)
                    .Include(m => m.Laboratoire)
                    .Include(m => m.Classe_pharmacologique)
                    .Include(m => m.Laboratoire.Pay)
                    .Include(m => m.Classe_thérapeutique)
                    .Include(m => m.DCI)
                    // Assuming there's a property like Id you can order by
                    .Skip(start)
                    .Take(10)
                    .ToList();// Force immediate execution and close the DataReader


                    listView.View = View.Details;
                    listView.Scrollable = true;
                    listView.GridLines = true;

                    foreach (var med in medicaments)
                    {
                        var item = ListviewItem_MEd(med);
                        listView.Items.Add(item);
                        Add_button_Edit_Delete(listView, med.Ref_med, item);
                    }
                }
                else
                {
                    MessageBox.Show("Database isn't initialized");
                }
            }
        }
        
        public static void Load_Med_ToListView_with_OutButton(ListView listView)
        {
            using (var dbContext = new dbcontext())
            {
                if (dbContext != null)
                {

                    var medicaments = dbContext.Medicaments
                        .Include(m => m.Laboratoire) // Include Laboratoire entity
                        .Include(m => m.Classe_pharmacologique)
                        .Include(m => m.Laboratoire.Pay)
                        .ToList(); // Force immediate execution and close the DataReader
                    listView.Items.Clear();
                    listView.View = View.Details;
                    listView.Scrollable = true;
                    listView.GridLines = true;

                    foreach (var med in medicaments)
                    {
                        var item = ListviewItem_MEd(med);
                        listView.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("Database isn't initialized");
                }
            }
        }

        private  static string RemoveSpacesFromString( string str)
        {
            
            // Find the index of the last letter or digit
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(str[i]))
                {
                    int lastLetterOrDigitIndex = i;
                    if (lastLetterOrDigitIndex != -1)
                    {
                        str = str.Substring(0, lastLetterOrDigitIndex + 1);
                    }
                    break;


                }
                
               
            }
            return str;
        }
        public static void Intialiaze_ComboBox<T>(MaterialComboBox comboBox, string name, string id) where T : class
        {
            using (var dbContext = new dbcontext())
            {
                var table = dbContext.Set<T>().ToList();
                table = table.OrderBy(item => item.GetType().GetProperty(name)?.GetValue(item, null) as string).ToList();

                comboBox.DataSource = table;
                comboBox.DisplayMember = name;
                comboBox.ValueMember = id;
            }
        }
        public static void Set_textBoxNullValuesTO(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                }
            }

        }





    }
}

