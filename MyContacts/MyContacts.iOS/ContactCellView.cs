using System;
using MyContacts.Core.Models;
using UIKit;

namespace MyContacts.iOS
{
	partial class ContactCellView : UITableViewCell
	{
		public ContactCellView (IntPtr handle) : base (handle)
		{
		}

	    public void Init(Contact contact)
	    {
	        Name.Text = contact.Name;
	        Email.Text = contact.Email;
            HeadshotImage.Image = UIImage.FromFile("Images/" + contact.HeadshotUrl);
	    }
	}
}
