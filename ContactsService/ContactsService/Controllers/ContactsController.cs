using System.Collections.Generic;
using System.Web.Http;
using ContactsService.Models;

namespace ContactsService.Controllers
{
    public class ContactsController : ApiController
    {
        private readonly IList<Contact> _contacts;

        public ContactsController()
        {
            _contacts = new List<Contact>
            {
                new Contact { 
					Name = "Homer Simpson", 
					HeadshotUrl = "Homer.gif", 
					Email = "donutlover@aol.com"
				},

				new Contact {
					Name = "Marge Simpson",
					HeadshotUrl = "Marge.gif",
					Email = "mamma_marge@gmail.com"
				},

				new Contact { 
					Name = "Bart Simpson",
					HeadshotUrl = "Bart.gif",
					Email = "troublemaker@gmail.com"
				},

				new Contact { 
					Name = "Lisa Simpson",
					HeadshotUrl = "Lisa.gif",
					Email = "cooljazz@gmail.com"
				},

				new Contact { 
					Name = "Maggie Simpson",
					HeadshotUrl = "Maggie.gif",
					Email = "babysimpson@gmail.com"
				},

				new Contact { 
					Name = "Krusty the Clown",
					HeadshotUrl = "Krusty.gif",
					Email = "funnyguy@krustytheclown.com"
				},

				new Contact { 
					Name = "Apu Nahasapeemapetilon",
					HeadshotUrl = "Apu.gif",
					Email = "storekeeper@quikeemart.com"
				},

				new Contact { 
					Name = "Comic Book Guy",
					HeadshotUrl = "ComicBookGuy.gif",
					Email = "comics@nerd.com"
				},

				new Contact { 
					Name = "Milhouse van Houten",
					HeadshotUrl = "Milhouse.gif",
					Email = "iammilhouse@aol.com"
				},

				new Contact { 
					Name = "Moe Szyslak",
					HeadshotUrl = "MoeSzyslak.gif",
					Email = "moe@moesbar.com"
				},

				new Contact { 
					Name = "Mr. Burns",
					HeadshotUrl = "MrBurns.gif",
					Email = "theman@boss.com"
				},

				new Contact { 
					Name = "Sideshow Bob",
					HeadshotUrl = "SideshowBob.gif",
					Email = "secondfiddle@krustytheclown.com"
				},

				new Contact { 
					Name = "Waylon Smithers",
					HeadshotUrl = "WaylonSmithers.gif",
					Email = "lackey@boss.com"
				},
            };
        }

        // GET api/contacts
        public IEnumerable<Contact> Get()
        {
            return _contacts;
        }
    }
}
