using System.IO;
using Android.App;
using Android.OS;
using Android.Widget;
using MyContacts.Core.Services;

namespace MyContacts.Droid
{
    [Activity(Label = "Details")]
    public class ContactDetailActivity : Activity
    {
        private readonly IContactService _contactService;

        public ContactDetailActivity()
        {
            _contactService = new ContactService();
        }

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.ContactDetail);

            var rowId = Intent.GetIntExtra("rowId", 0);
            
            var contacts = await _contactService.GetAllContacts();

            var contact = contacts[rowId];
            FindViewById<TextView>(Resource.Id.NameDetail).Text = contact.Name;
            FindViewById<TextView>(Resource.Id.EmailDetail).Text = contact.Email;

            var resId = (int)typeof(Resource.Drawable).GetField(Path.GetFileNameWithoutExtension(contact.HeadshotUrl)).GetValue(null);
            FindViewById<ImageView>(Resource.Id.HeadshotDetail).SetImageResource(resId);
        }
    }
}