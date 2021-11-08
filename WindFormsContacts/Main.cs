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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region EVENTS
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDial();
        }
        #endregion


        #region PRIVATE METHODS
        private void OpenContactDetailsDial()
        {

            ContactDetails contactDetails = new ContactDetails();
            contactDetails.ShowDialog();
        }
        #endregion


    }
}
