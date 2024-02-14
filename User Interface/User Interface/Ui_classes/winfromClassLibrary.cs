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

namespace User_Interface
{
    public static class WinformClassLibrary  
    {
        public enum classMed
        {
            cPharma,
            cTheta,
            dci,
        }
        private static dbcontext _context;
        static WinformClassLibrary()
        {
            _context = new dbcontext();
        }
        private static void position_newButton(int width, int btol, int bwidth, string Type_AndID, ListViewItem lvi, ListView lv, Button btn)
        {
            btn.Bounds = new Rectangle(lv.Width - width, lvi.Bounds.Top, btol, bwidth);
            btn.Text = "";
            btn.FlatStyle = FlatStyle.Flat;
            btn.Name = Type_AndID;//e edit
            btn.FlatAppearance.BorderSize = 0;
            btn.Click += edit_delete_click;
        }

        private static void edit_delete_click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string[] op = clickedButton.Name.Split('/');

            if (op[0]=="d")
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce médicament ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check the user's response
                if (result == DialogResult.Yes)
                {
                    sql_connection.delete_elemnt<Medicament>(op[1]);
                    
                    MessageBox.Show("le médicament a été supprimé avec succès");
                    /// 
                    load_Med_ToListView_with_OutButton(listGlobal);
                }
                else return;
            }
            else
            {
                diag_Edit_Med diag_Edit_Med = new diag_Edit_Med(op[1]);
                diag_Edit_Med.ShowDialog();
                if (diag_Edit_Med.DialogResult == DialogResult.OK) {
                    load_Med_ToListView_with_OutButton(listGlobal);
                }
            }
        }

        private static void add_button_Edit_Delete(ListView listView,string  ID,ListViewItem item,ListView listView1)
        {
            Button editbutton = new Button();
            Button deletebutton = new Button();
          
            listView.Controls.Add(editbutton);
            listView.Controls.Add(deletebutton);
            position_newButton(160, 34, 34, "e/"+ID, item, listView, editbutton);
            position_newButton(200, 34, 34, "d/"+ID, item, listView, deletebutton);
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            editbutton.Image = System.Drawing.Image.FromFile(currentDirectory + "\\edit-_1_.bmp");
            deletebutton.Image = System.Drawing.Image.FromFile(currentDirectory + "\\delete.bmp");
        }
        private static ListViewItem listviewItem_MEd(Medicament med)
        {
            var item = new ListViewItem($"{removeSpacesFromString(med.nom_comrsl)}, {removeSpacesFromString(med.Dossage)}" +
                $" ({removeSpacesFromString(med.Dossage)}/100ml)" +
                $" {removeSpacesFromString(med.Form)}, " +
                $"{removeSpacesFromString(med.Conditionnement)}");
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
        public static void load_Med_ToListView_withButton(ListView listView)
        {
            if (_context != null)
            {
                listGlobal = listView;
                ListView listView1 = new ListView();
                var medicaments = _context.Medicaments
                    .Include(m => m.Laboratoire) // Include Laboratoire entity
                    .Include(m => m.Classe_pharmacologique)
                    .Include(m => m.Laboratoire.Pay)
                    .Include(m => m.Classe_thérapeutique)
                    .Include(m => m.DCI)
                    .ToList(); // Force immediate execution and close the DataReader

                listView.View = View.Details;
                listView.Scrollable = true;
                listView.GridLines = true;

                foreach (var med in medicaments)
                {
                    var item = listviewItem_MEd(med);
                    listView.Items.Add(item);
                    add_button_Edit_Delete(listView, med.Ref_med,item,listView);
                }
            }
            else
            {
                MessageBox.Show("Database isn't initialized");
            }
        }
        
        public static void load_Med_ToListView_with_OutButton(ListView listView)
        {
            if (_context != null)
            {

                var medicaments = _context.Medicaments
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
                    var item = listviewItem_MEd(med);
                    listView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Database isn't initialized");
            }
        }

        private  static string removeSpacesFromString( string str)
        {
            int lastLetterOrDigitIndex = -1;
            // Find the index of the last letter or digit
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (char.IsLetterOrDigit(str[i]))
                {
                    lastLetterOrDigitIndex = i;
                    if (lastLetterOrDigitIndex != -1)
                    {
                        str = str.Substring(0, lastLetterOrDigitIndex + 1);
                    }
                    break;


                }
                
               
            }
            return str;
        }
        public static void intialiaze_ComboBox<T>(MaterialComboBox comboBox, string name, string id) where T : class
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
        public static void set_textBoxNullValuesTO(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    if (textBox==null)
                    {
                        textBox.Text = "";
                    }
                    
                }
            }
        }
        




    }
}

