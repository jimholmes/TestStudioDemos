using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingWithLocators
{
    public class Contacts
    {
        public IList<Contact> ContactList()
        {
            IList<Contact> contacts = CreateListOfContacts();

            //var shuffled = contacts.OrderBy(a => Guid.NewGuid());
            //IList<Contact> newList = new List<Contact>();
            //foreach (var item in shuffled)
            //{
            //    newList.Add(item);
            //}
            //return newList;
            return contacts;
        }
  
        private IList<Contact> CreateListOfContacts()
        {
            IList<Contact> contacts = new List<Contact>()
            {
                new Contact
                {
                    Id = 12,
                    FirstName = "Jayne",
                    LastName = "Cobb",
                    Company = "Blue Sun",
                    Region = "New Earth"
                },
                
                new Contact
                {
                    Id = 1,
                    FirstName = "Jim",
                    LastName = "Holmes",
                    Company = "Telerik",
                    Region = "Midwest"
                },
                
                new Contact
                {
                    Id = 3,
                    FirstName = "Katy",
                    LastName = "McGillicuddy",
                    Company = "Tip Top Software",
                    Region = "Midwest"
                },
                new Contact
                {
                    Id = 7,
                    FirstName = "Malcom",
                    LastName = "Reynolds",
                    Company = "Serenity, Inc.",
                    Region = "New Earth"
                },
                new Contact
                {
                    Id = 4,
                    FirstName = "Robin",
                    LastName = "Knight",
                    Company = "Bravely Bravely, LLC",
                    Region = "Scotland"
                },
                new Contact
                {
                    Id = 5,
                    FirstName = "Guinevere",
                    LastName = "Leodegrance",
                    Company = "Round Table Hotels",
                    Region = "Scotland"
                },
                new Contact
                {
                    Id = 8,
                    FirstName = "Albert",
                    LastName = "Einstein",
                    Company = "Relativity Inc",
                    Region = "Eastern"
                },
                new Contact
                {
                    Id = 6,
                    FirstName = "Sarah",
                    LastName = "Merwin",
                    Company = "Merwin Consulting Ltd",
                    Region = "Western"
                },
                new Contact
                {
                    Id = 9,
                    FirstName = "Ludwig",
                    LastName = "Beethoven",
                    Company = "Top Notch Music Academy",
                    Region = "Europe"
                }
            };
            return contacts;
        }
    }

    public class Contact
    {
        int id;
        string firstName;
        string lastName;
        string company;
        string region;

        public string Region
        {
            get
            {
                return this.region;
            }
            set
            {
                this.region = value;
            }
        }

        public string Company
        {
            get
            {
                return this.company;
            }
            set
            {
                this.company = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
    }
}