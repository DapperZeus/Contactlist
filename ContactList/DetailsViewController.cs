using Foundation;
using System;
using UIKit;

namespace Contactlist
{
    public partial class DetailsViewController : UIViewController
    {

        public Contact selectedContact;

        public DetailsViewController(IntPtr handle) : base(handle)
        {
        }


        public override void ViewWillAppear(bool animated)
        {
            labelContactName.Text = selectedContact.Name;
            imgContactImage.Image = UIImage.FromFile(selectedContact.ImagePath);
        }

        }

     }
  
