using System.Collections.Generic;
using System.Threading.Tasks;
using MyContacts.Core.Models;

namespace MyContacts.Core.Services
{
    public interface IContactService
    {
        Task<IList<Contact>> GetAllContacts();
    }
}
