using System;
using System.Windows.Forms;
using User_Interface.Ui_classes;
using User_Interface.forms;
using Pharma_Libarary.Model;
using System.Data.Entity;
using System.Drawing;
using MaterialSkin.Controls;

namespace User_Interface
{
    public static class WinformClassLibrary  
    {

        private static dbcontext _context;
        static WinformClassLibrary()
        {
            _context = new dbcontext();
        }
        private static void addbutton(int width, int btol, int bwidth, string name, ListViewItem lvi, ListView lv, Button btn)
        {
            btn.Bounds = new Rectangle(lv.Width - width, lvi.Bounds.Top, btol, bwidth);
            btn.Text = name;
            btn.Name = name;

            btn.Click += ButtonClick;
            btn.Tag = lvi;


            lv.Controls.Add(btn);

        }
        private static void ButtonClick(object sender, EventArgs e)
        {

            Button clickedButton = sender as Button;


            ListViewItem listItem = (ListViewItem)clickedButton.Tag;

            string id = listItem.SubItems[0].Text;
            string temp = clickedButton.Name;
            switch (temp)
            {
                case "delete":
                    
                    break;
                case "edit":
                    // Code to execute for case2
                    break;
                case "case3":
                    // Code to execute for case3
                    break;
                default:
                    // Code to execute if userInput does not match any of the cases above
                    break;
            }


            if (clickedButton.Name == "edit")
            {
                Edit_table edit_Table = new Edit_table();

                edit_Table.Ref_med = id;

                edit_Table.Show();

                using (dbcontext db = new dbcontext())
                {



                    Medicament md = db.Medicaments.Find(id);


                    db.Medicaments.Remove(md);


                    db.SaveChanges();





                }




            }

            else if (clickedButton.Name == "delete")
            {
                



            }
        }
        public static void add_Med_ToListView(MaterialListView listView)
        {
            if (_context != null)
            {
                _context.Medicaments.Load();
                _context.Laboratoires.Load();
                _context.Classe_pharmacologiques.Load();
                _context.Pays.Load();
                listView.View = View.Details;
                listView.Scrollable = true;
                listView.GridLines = true;
                foreach (var Med in _context.Medicaments)
                {
                    
                    ListViewItem item = new ListViewItem(Med.nom_comrsl + "," + Med.Dossage + "(" 
                        + Med.Dossage+"/100ml) "+ Med.Form+","+Med.Conditionnement);
                    item.SubItems.Add(Med.Laboratoire.Lab_nom);
                    item.SubItems.Add(Med.Classe_pharmacologique.nom_Cpharma);
                    item.SubItems.Add(Med.Classe_thérapeutique.code_Cthera);
                    if (Med.Type)
                    {
                        item.SubItems.Add("Générique");
                    }else item.SubItems.Add("Princeps");
                    if (Med.Laboratoire.Pay.Pays_code=="DZD")
                    {
                        item.SubItems.Add("OUI");
                    }else item.SubItems.Add("NON");


                    listView.Items.Add(item);
                }
            }
            else MessageBox.Show("data base isnt intialized");
            

        }
        public static void edit_Med(Medicament med)
        {

        }
        public static void deleteMed(string Ref_Med)
        {
            using (var context = new dbcontext())
            {
                var entityToDelete = context.Users.Find(Ref_Med);

                if (entityToDelete != null)
                {
                    context.Users.Remove(entityToDelete);
                    context.SaveChanges();
                }
            }
        }
        

    }
}

