using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindFormsContacts
{
    public partial class ContactDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public ContactDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.FirstName = txtFirstName.Text;
            contact.LastName = textLastName.Text;
            contact.Phone = txtPhone.Text;
            contact.Adress = txtAdress.Text;


            _businessLogicLayer.SaveContact(contact);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
