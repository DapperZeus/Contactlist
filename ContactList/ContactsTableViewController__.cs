using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace contactlist
{
    public partial class ContactsTableViewController : UITableViewController
    {
        List<Contact> Contactlist;

        public ContactsTableViewController (IntPtr handle) : base (handle)
        {
            Contactlist = new List<Contact>();

            Contactlist.Add(new Contact() {

                Name = "Dumbledor",
                Number = "345-353-9278",
                Location = "Hogwarts"
                
            });

            Contactlist.Add(new Contact()
            {
                Name = "Jar Jar Binks",
                Number = "123-456-7890",
                Location = "Naboo",
            });

            Contactlist.Add(new Contact()
            {
                Name = "Nicholas Cage",
                Number = "403-105-2468",
                Location = "California, U.S.A.",
            });

            Contactlist.Add(new Contact()
            {
                Name = "Kenny",
                Number = "135-791-3579",
                Location = "South Park, Colorado",
            });
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

       public override nint RowsInSection(UITableView tableView, nint section)
        {
            return Contactlist.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("Contact") as ContactTableViewCell;
         
            var data = Contactlist[indexPath.Row];

            cell.ContactData = data;

            return cell;
            }
        }

    public class Contact
    {
        public string Name;
        public string Number;
        public string Location;
    }
}