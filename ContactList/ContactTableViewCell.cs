using Foundation;
using System;
using UIKit;

namespace contactlist
{
    public partial class ContactTableViewCell : UIView
    {
		private Contact contactData;

		public Contact ContactData
        {
            get { return contactData; }
            set { 
                contactData = value;

                labelName.Text = contactData.Name;
                labelNumber.Text = contactData.Number;
                labelLocation.Text = contactData.Location;
            }

        }
        public ContactTableViewCell (IntPtr handle) : base (handle)
        {
           
            
        }
    }
}