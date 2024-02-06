using System;
using System.Windows.Forms;
using User_Interface.Ui_classes;
using User_Interface.forms;
using Pharma_Libarary.Model;
using System.Data.Entity;
using System.Drawing;
using MaterialSkin.Controls;
using System.Linq;

namespace User_Interface
{
    public static class WinformClassLibrary  
    {

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
        }
        private static void add_button_Edit_Delete(ListView listView,string  ID,ListViewItem item)
        {
            Button editbutton = new Button();
            Button deletebutton = new Button();
            listView.Controls.Add(editbutton);
            listView.Controls.Add(deletebutton);
            position_newButton(250, 34, 34, "e/"+ID, item, listView, editbutton);
            position_newButton(288, 34, 34, "d/"+ID, item, listView, deletebutton);
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            editbutton.Image = Image.FromFile(currentDirectory + "\\edit-_1_.bmp");
            deletebutton.Image = Image.FromFile(currentDirectory + "\\delete.bmp");
        }
        private static ListViewItem listviewItem_MEd(Medicament med)
        {
            var item = new ListViewItem($"{med.nom_comrsl}, {med.Dossage} ({med.Dossage}/100ml) {med.Form}, {med.Conditionnement}");
            item.SubItems.Add(med.Laboratoire.Lab_nom);
            item.SubItems.Add(med.Classe_pharmacologique.nom_Cpharma);
            item.SubItems.Add(med.Classe_thérapeutique.code_Cthera);
            item.SubItems.Add(med.Type ? "Générique" : "Princeps");
            item.SubItems.Add(med.Laboratoire.Pay.Pays_code == "DZD" ? "OUI" : "NON");
            item.SubItems.Add(med.Remboursable == true ? "OUI" : "NON");

            return item;
        }
        public static void add_Med_ToListView(MaterialListView listView)
        {
            if (_context != null)
            {
                
                var medicaments = _context.Medicaments
                    .Include(m => m.Laboratoire) // Include Laboratoire entity
                    .Include(m => m.Classe_pharmacologique)
                    .Include(m => m.Laboratoire.Pay)
                    .ToList(); // Force immediate execution and close the DataReader

                listView.View = View.Details;
                listView.Scrollable = true;
                listView.GridLines = true;

                foreach (var med in medicaments)
                {
                    var item = listviewItem_MEd(med);
                    listView.Items.Add(item);
                    add_button_Edit_Delete(listView, med.Ref_med,item);
                }
            }
            else
            {
                MessageBox.Show("Database isn't initialized");
            }
        }





    }
}

