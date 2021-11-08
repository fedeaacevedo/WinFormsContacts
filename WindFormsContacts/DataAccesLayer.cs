using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindFormsContacts
{
    class DataAccesLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-DN0SE9D");

        public void InsertContact(Contact contact)
        {
            try
            {
                conn.Open();
                string query = @"
                                INSERT INTO Contacts([First Name], [Last Name], [Phone], [Adress])
                                VALUES (@FirstName, @LastName, @Phone, @Adress) ";


                SqlParameter firstName = new SqlParameter("@FirstName", contact.FirstName);
                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter adress = new SqlParameter("@Adress", contact.Adress);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(adress);


                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
