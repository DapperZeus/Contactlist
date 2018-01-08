using Foundation;
using System;
using UIKit;

namespace Contactlist
{
    public partial class ContactTableViewCell : UITableViewCell
    {

        private Contact contactData;

        public Contact ContactData
        {
            get { return contactData; }
            set { contactData = value;

                labelName.Text = contactData.Name;
                labelNumber.Text = contactData.Number.ToString();
                labelLocation.Text = contactData.Location;
            }
        }


        public ContactTableViewCell (IntPtr handle) : base (handle)
        {
        }
    }
}