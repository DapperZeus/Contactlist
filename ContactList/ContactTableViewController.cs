using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace Contactlist
{
    public partial class ContactTableViewController : UITableViewController
    {

        List<Contact> contactList;

        public ContactTableViewController (IntPtr handle) : base (handle)
        {
            contactList = new List<Contact>();

            contactList.Add(new Contact()
            {

                Name = "Dumbledor",
                Number = "345-353-9278",
                Location = "Hogwarts"
            });

            contactList.Add(new Contact()
            {
                Name = "Jar Jar Binks",
                Number = "123-456-7890",
                Location = "Naboo"
            });

            contactList.Add(new Contact()
            {
                Name = "Nicholas Cage",
                Number = "403-105-2468",
                Location = "California, U.S.A."
            });

            contactList.Add(new Contact()
            {
                Name = "Kenny",
                Number = "135-791-3579",
                Location = "South Park, Colorado"
            });

		}

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return contactList.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Contact");

            var data = contactList[indexPath.Row];

            cell.TextLabel.Text = data.Name;

            return cell;
        }
        }


    }



    public class Contact 
    {
        public string Name;
        public string Number;
        public string Location;
    }
}