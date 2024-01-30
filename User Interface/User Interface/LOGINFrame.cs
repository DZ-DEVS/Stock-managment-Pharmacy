using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pharma_Libarary.Model;
namespace User_Interface
{
    public partial class LOGINFrame : Form
    {
        public LOGINFrame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new dbcontext()) // Replace YourDbContext with the actual name of your DbContext class
            {
                // Step 2: Create a new User instance and set its properties
                User newUser = new User
                {
                    userName = "YourUserName",  // Set your desired values
                    password = "YourPassword",
                    nom = "YourLastName",
                    prenom = "YourFirstName"
                    // You may need to set other properties if required
                };

                // Step 3: Add the user instance to the DbSet in the DbContext
                context.Users.Add(newUser);  // Assuming the DbSet in your DbContext is named "Users"

                // Step 4: Save changes to the database
                context.SaveChanges();
            }
        }
    }
}
