using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using MyContacts.Core.Services;

namespace MyContacts.Droid
{
    [Activity(Label = "Contacts", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private readonly IContactService _contactService;

        public MainActivity()
        {
            _contactService = new ContactService();
        }

        protected override async void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            var contactList = FindViewById<ListView>(Resource.Id.contactListView);
            contactList.ItemClick += OnItemClick;

            var contacts = await _contactService.GetAllContacts();
            contactList.Adapter = new ContactAdapter(this, contacts);
        }

        void OnItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(ContactDetailActivity));
            intent.PutExtra("rowId", e.Position);
            StartActivity(intent);
        }
    }
}

