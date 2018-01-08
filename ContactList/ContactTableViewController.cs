using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace Contactlist
{
    public partial class ContactTableViewController : UITableViewController
    {

        List<Contact> contactList;

        public ContactTableViewController(IntPtr handle) : base(handle)
        {
            contactList = new List<Contact>();

            contactList.Add(new Contact()
            {

                Name = "Dumbledor",
                Number = "345-353-9278",
                Location = "Hogwarts",
                    ImagePath = "Resources/Unknown"
            });

            contactList.Add(new Contact()
            {
                Name = "Jar Jar Binks",
                Number = "123-456-7890",
                Location = "Naboo",
                ImagePath = "Resources/Unknown-2"
            });

            contactList.Add(new Contact()
            {
                Name = "Nicholas Cage",
                Number = "403-105-2468",
                Location = "California, U.S.A.",
                    ImagePath = "Resources/Unknown-3"
            });

            contactList.Add(new Contact()
            {
                Name = "Kenny",
                Number = "135-791-3579",
                Location = "South Park, Colorado",
                ImagePath = "Resources/Unknown-4"
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
            var cell = tableView.DequeueReusableCell("Contact") as ContactTableViewCell;

            var data = contactList[indexPath.Row];

            cell.ContactData = data;

            return cell;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "DetailsSegue")
            {
                var navigationController = segue.DestinationViewController as DetailsViewController;

                if (navigationController != null)
                {
                    var rowPath = TableView.IndexPathForSelectedRow;
                    var selectedData = contactList[rowPath.Row];
                    navigationController.selectedContact = selectedData;
                }
            }
            base.PrepareForSegue(segue, sender);
        }
    }





    public class Contact
    {
        public string Name;
        public string Number;
        public string Location;
        public string ImagePath;
    }
}