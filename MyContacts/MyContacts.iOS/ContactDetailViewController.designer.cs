// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace MyContacts.iOS
{
	[Register ("ContactDetailViewController")]
	partial class ContactDetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel EmailLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView HeadshotImage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel NameLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (EmailLabel != null) {
				EmailLabel.Dispose ();
				EmailLabel = null;
			}
			if (HeadshotImage != null) {
				HeadshotImage.Dispose ();
				HeadshotImage = null;
			}
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}
		}
	}
}
