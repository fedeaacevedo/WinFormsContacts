using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindFormsContacts
{
    public class BusinessLogicLayer
    {
        private DataAccesLayer _dataAccesLayer;

        public BusinessLogicLayer()
        {
            _dataAccesLayer = new DataAccesLayer();
        }

        public Contact SaveContact(Contact contact)
        {
            if (contact.Id == 0)
                _dataAccesLayer.InsertContact(contact);
            //else 
            //  _dataAccesLayer.UpdateContact

            return contact;
        }
    }
}
