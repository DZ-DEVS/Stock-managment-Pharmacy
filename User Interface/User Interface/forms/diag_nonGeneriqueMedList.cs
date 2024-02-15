using Pharma_Libarary.Data;
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

namespace User_Interface.forms
{
    public partial class diag_nonGeneriqueMedList : Form
    {
        public diag_nonGeneriqueMedList()
        {
            InitializeComponent();

        }

        private void dialog_nonGeneriqueMedList_Load(object sender, EventArgs e)
        {
            List<Medicament> meds=Sql_connection.Load_nonGeneriqueMeds();
            combobox.DataSource = meds;
            combobox.DisplayMember = "nom_comrsl";
            combobox.ValueMember = "Ref_med";



        }
    }
}
