using Pharma_Libarary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharma_Libarary.Data
{
    public class sql_connection
    {
        #region insert in data base tables
        public static bool add_newUser(User newUser)
        {
            try
            {
                using (var context = new dbcontext()) // Replace YourDbContext with the actual name of your DbContext class
                {
                    bool recordExists = context.Users.Any(e => e.userName == newUser.userName);/// check if user exist
                    if (recordExists)
                    {
                        MessageBox.Show("Ce utilisatuer existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else
                    {
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
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("une erreur s'est produite lors de la création :" + e.ToString());
                return false;
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
                    else
                    {
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
                    else
                    {
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
        public static void add_Lab(Laboratoire lab)
        {
            try
            {
                using (var context = new dbcontext())
                {
                    // Check if the Laboratoire already exists
                    bool recordExists = context.Laboratoires.Any(e => e.Lab_code == lab.Lab_code);
                    if (recordExists)
                    {
                        MessageBox.Show("Cette classe existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        lab.Pay = null;
                        var pays = context.Pays.FirstOrDefault(p => p.Pays_code == lab.pay_code);
                        if (pays != null)
                        {
                            pays.Laboratoires.Add(lab);
                            context.SaveChanges();
                            MessageBox.Show("La classe labo a été ajoutée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Le pays avec le code '" + lab.pay_code + "' n'existe pas.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Une erreur s'est produite lors de la création : " + e.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void add_Med(Medicament med)
        {

            try
            {
                using (var context = new dbcontext())
                {
                    bool recordExist = context.Medicaments.Any(e => e.Ref_med == med.Ref_med);
                    
                    if (recordExist)
                    {
                        MessageBox.Show("cette classe existe déjà !!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var labs = context.Laboratoires.FirstOrDefault(p => p.Lab_code == med.Lab_code);
                        var Cphara = context.Classe_pharmacologiques.FirstOrDefault(p => p.nom_Cpharma == med.nom_Cpharma);
                        var Cthera = context.Classe_thérapeutique.FirstOrDefault(p => p.code_Cthera == med.code_Cthera);
                        var Dci = context.DCIs.FirstOrDefault(p => p.nom_DCI == med.nom_DCI);
                        labs.Medicaments.Add(med);
                        Cphara.Medicaments.Add(med);
                        Cthera.Medicaments.Add(med);
                        Dci.Medicaments.Add(med);
                        context.Medicaments.Add(med);
                        context.SaveChanges();

                        MessageBox.Show("la class Produit a ete bien ajoute", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("une erreur s'est produite lors de la création :" + e.ToString());
            }
        }


        #endregion

        #region edit and delete
        public static void edit_Med(Medicament med)
        {
            using (var dbContext = new dbcontext())
            {
                try
                {
                    var editedMed = dbContext.Medicaments
                              .Include(m => m.Laboratoire.Pay)
                              .Include(m => m.Classe_pharmacologique)
                              .Include(m => m.Classe_thérapeutique)
                              .Include(m => m.DCI)
                              .FirstOrDefault(m => m.Ref_med == med.Ref_med);
                    dbContext.Entry(editedMed).CurrentValues.SetValues(med);
                    dbContext.SaveChanges();
                    MessageBox.Show("The details of the medication have been edited.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                        }
                    }
                }
            }
        }
        public static void delete_elemnt<T>(string Ref_Med) where T : class
        {
            using (var context = new dbcontext())
            {
                var dbSet = context.Set<T>(); // Get the DbSet for the specified entity type

                var entityToDelete = dbSet.Find(Ref_Med);

                if (entityToDelete != null)
                {
                    dbSet.Remove(entityToDelete);
                    context.SaveChanges();
                }
                entityToDelete = dbSet.Find(Ref_Med);
            }
        }
        #endregion
        #region load class
        public static Medicament load_med(string ID)
        {
            
            using (var db = new dbcontext())
            {

                var load = db.Medicaments
                  .Include(m => m.Laboratoire.Pay)
                  .Include(m => m.Classe_pharmacologique)
                  .Include(m => m.Classe_thérapeutique)
                  .Include(m => m.DCI)
                  .FirstOrDefault(m => m.Ref_med == ID);
                Medicament med = load;
                return med;
            }
            
        }
        public static List<Medicament> load_nonGeneriqueMeds()
        {
            using (var db = new dbcontext())
            {
                List<Medicament> meds = db.Medicaments
                    .Include(m => m.Laboratoire.Pay)
                    .Include(m => m.Laboratoire)
                    .Include(m => m.Classe_pharmacologique)
                    .Include(m => m.Classe_thérapeutique)
                    .Include(m => m.DCI)
                    .Where(m => m.Type == false)
                    .ToList(); // Corrected: Call ToList() without angle brackets

                return meds; // Return the loaded list of Medicament entities
            }
        }
        #endregion

    }
}
