using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.App;
using Android.Views;
using Android.Widget;
using MyContacts.Core.Models;

namespace MyContacts.Droid
{
    public class ContactAdapter : BaseAdapter<Contact>
    {
        private Activity _context;
        private List<Contact> _contacts;

        public ContactAdapter(Activity context, IEnumerable<Contact> data)
        {
            _context = context;
            _contacts = data.ToList();
        }
 
        public override int Count
        {
            get { return _contacts.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Contact this[int position]
        {
            get { return _contacts[position]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.ListItemRow, parent, false);

            var contact = _contacts[position];
            view.FindViewById<TextView>(Resource.Id.Name).Text = contact.Name;
            view.FindViewById<TextView>(Resource.Id.Email).Text = contact.Email;

            var resId = (int)typeof(Resource.Drawable).GetField(Path.GetFileNameWithoutExtension(contact.HeadshotUrl)).GetValue(null);
            view.FindViewById<ImageView>(Resource.Id.Headshot).SetImageResource(resId);
            
            return view;
        }
    }
}