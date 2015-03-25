using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using MyContacts.Core.Models;
using UIKit;

namespace MyContacts.iOS
{
    public class ContactsTableSource : UITableViewSource
    {
        private const string CellIdentifier = "contactCell";
        private readonly List<Contact> _contacts;

        public ContactsTableSource(IEnumerable<Contact> data)
        {
            _contacts = data.ToList();
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _contacts.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var contact = _contacts[indexPath.Row];

            var cell = tableView.DequeueReusableCell(CellIdentifier) as ContactCellView;
            cell.Init(contact);

            return cell;
        }

        public Contact GetContact(int index)
        {
            return _contacts[index];
        }
    }
}