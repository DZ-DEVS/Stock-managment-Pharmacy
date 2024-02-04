using System;
using System.Windows.Forms;
using User_Interface.Ui_classes;
using User_Interface.forms;

namespace User_Interface
{
    public class WinformClassLibrary  
    {
        //public static void LoadButtonOnListView(ListView listView1,int listLength)
        //{
        //    listView1.FullRowSelect = true;
        //    ListViewExtender extender = new ListViewExtender(listView1);

        //    // Extend 2nd column
        //    ListViewButtonColumn buttonAction = new ListViewButtonColumn(1);
        //    buttonAction.Click += OnButtonActionClick; // Use ButtonClick event
        //    buttonAction.FixedWidth = true;

        //    extender.AddColumn(buttonAction);

        //    for (int i = 0; i < listLength; i++)
        //    {
        //        ListViewItem item = listView1.Items.Add("item" + i);
        //        item.SubItems.Add("button " + i);
        //    }
        //}

        private static void OnButtonActionClick(object sender, ListViewColumnMouseEventArgs e)
        {
            MessageBox.Show( "You clicked " + e.SubItem.Text);
        }
    }
}

