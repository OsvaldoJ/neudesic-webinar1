using System;
using Foundation;
using MyContacts.Core.Services;
using UIKit;

namespace MyContacts.iOS
{
	partial class ContactsViewController : UITableViewController
	{
	    private readonly IContactService _contactService;

		public ContactsViewController (IntPtr handle) : base (handle)
		{
            _contactService = new ContactService();
        }

	    public override async void ViewDidLoad()
	    {
	        base.ViewDidLoad();

            var data = await _contactService.GetAllContacts();
            if (data != null)
            {
                TableView.Source = new ContactsTableSource(data);
                TableView.ReloadData();
            }
        }

	    public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
	    {
	        if (segue.Identifier == "ContactSegue")
	        {
	            var destCtlr = segue.DestinationViewController as ContactDetailViewController;
                if (destCtlr != null)
	            {
	                var source = TableView.Source as ContactsTableSource;
	                var rowPath = TableView.IndexPathForSelectedRow;
	                var contact = source.GetContact(rowPath.Row);
                    destCtlr.SetContact(contact);
	            }
	        }
	    }
	}
}
