using System;
using MyContacts.Core.Models;
using UIKit;

namespace MyContacts.iOS
{
	partial class ContactDetailViewController : UIViewController
	{
	    private Contact _contact;

		public ContactDetailViewController (IntPtr handle) : base (handle)
		{
		}

	    public override void ViewWillAppear(bool animated)
	    {
	        base.ViewWillAppear(animated);

	        NameLabel.Text = _contact.Name;
	        EmailLabel.Text = _contact.Email;
	        HeadshotImage.Image = UIImage.FromBundle("Images/" + _contact.HeadshotUrl);
	    }

	    public void SetContact(Contact contact)
	    {
	        _contact = contact;
	    }
	}
}
