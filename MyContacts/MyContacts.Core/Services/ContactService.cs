using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MyContacts.Core.Models;
using Newtonsoft.Json;

namespace MyContacts.Core.Services
{
    public class ContactService : IContactService
    {
        private const string ServiceUrl = "http://contactsservice.azurewebsites.net/api/contacts";
        private static IList<Contact> _contacts;

        public async Task<IList<Contact>> GetAllContacts()
        {
            if (_contacts == null)
            {
                using (var client = new HttpClient())
                {
                    var json = await client.GetStringAsync(ServiceUrl);
                    _contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                }
            }

            return _contacts;
        }
    }
}
