using Pharma_Libarary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma_Libarary.Data
{
    public  class sql_connection
    {
        #region insert in data base tables
        public static void add_newUser(User newUser)
        {
            try
            {
                using (var context = new dbcontext()) // Replace YourDbContext with the actual name of your DbContext class
                {
                    bool recordExists = context.Users.Any(e => e.userName == newUser.userName);/// check if user exist
                    if (recordExists)
                    {
                        MessageBox.Show("Ce utilisatuer existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        // Step 2: Create a new User instance and set its properties
                        User instance = new User
                        {
                            userName = newUser.userName,  // Set your desired values
                            password = newUser.password,
                            nom = newUser.nom,
                            prenom = newUser.prenom
                            // You may need to set other properties if required
                        };

                        // Step 3: Add the user instance to the DbSet in the DbContext
                        context.Users.Add(instance);  // Assuming the DbSet in your DbContext is named "Users"

                        // Step 4: Save changes to the database
                        context.SaveChanges();
                    }
                    
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("une erreur s'est produite lors de la création :" + e.ToString());

            }
            
        }

        public static void add_newClass_phatmacologique(String classe_pharmacologique_Name)
        {
            try
            {
                using (var context = new dbcontext())
                {
                    /// check is exist 
                    bool recordExists = context.Classe_pharmacologiques.Any(e => e.nom_Cpharma == classe_pharmacologique_Name);
                    if (recordExists)
                    {
                        MessageBox.Show("cette classe existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        Classe_pharmacologique instance = new Classe_pharmacologique
                        {
                            nom_Cpharma = classe_pharmacologique_Name
                        };
                        context.Classe_pharmacologiques.Add(instance);
                        context.SaveChanges();

                        MessageBox.Show("la class pharmalogique a ete bien ajoute", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("une erreur s'est produite lors de la création :" + e.ToString());
                
            }
            

        }
        public static void add_newClass_therapeutique(String Classe_therapeutique_Name)
        {
            try
            {
                using (var context = new dbcontext())
                {
                    /// check is exist 
                    bool recordExists = context.Classe_thérapeutique.Any(e => e.code_Cthera == Classe_therapeutique_Name);
                    if (recordExists)
                    {
                        MessageBox.Show("cette classe existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else {
                        Classe_thérapeutique instance = new Classe_thérapeutique
                        {
                            code_Cthera = Classe_therapeutique_Name
                        };
                        context.Classe_thérapeutique.Add(instance);
                        context.SaveChanges();

                        MessageBox.Show("la class thérapeutique a ete bien ajoute", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("une erreur s'est produite lors de la création :" + e.ToString());
                
            }
            

        }
        public static void add_newClass_DCI(String Classe_DCI_Name)
        {
            try
            {
                using (var context = new dbcontext())
                {
                    /// check is exist 
                    bool recordExists = context.DCIs.Any(e => e.nom_DCI == Classe_DCI_Name);
                    if (recordExists)
                    {
                        MessageBox.Show("cette classe existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DCI instance = new DCI
                        {
                            nom_DCI = Classe_DCI_Name
                        };
                        context.DCIs.Add(instance);
                        context.SaveChanges();

                        MessageBox.Show("la class DCI a ete bien ajoute", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("une erreur s'est produite lors de la création :" + e.ToString());

            }


        }

        #endregion
    }
}
