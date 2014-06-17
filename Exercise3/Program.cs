using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    class Program {
        static void Main(string[] args)
        {
            var list1 = new List<Address>();
            var list2 = new List<Person>();
            var StreetNameList = new List<String>();

            list1.Add(new Address()
            {
                DooNo = 1,
                City = "New York",
                PhoneNo = 123456,
                State = "NY",
                StreetName = "Wall Street"
            });


            list1.Add(new Address()
            {
                DooNo = 2,
                City = "Los Angeles",
                PhoneNo = 234567,
                State = "California",
                StreetName = "Rose Ave"
            });

             
            
            list1.Add(new Address()
            {
                DooNo = 4,
                City = "Chicago",
                PhoneNo = 345678,
                State = "Illinois",
                StreetName = "Lincoln Ave"
            });


            list2.Add( new Person
            {
                Age = 23,
                City = "San Francisco",
                Gender = "Female",
                FirstName = "Donna",
                LastName = "Summer",
                Prefix = "Miss"
            });
            
            list2.Add( new Person
            {
                Age = 28,
                City = "San Francisco",
                Gender = "Male",
                FirstName = "Ben",
                LastName = "Johnson",
                Prefix = "Mr"
            });

            list2.Add( new Person
            {
                Age = 38,
                City = "New York",
                Gender = "Female",
                FirstName = "Kate",
                LastName = "Hudson",
                Prefix = "Mrs"
            });

            foreach (Address address in list1)
            {
                StreetNameList.Add(address.StreetName);
                //Console.WriteLine(address.StreetName);
            }

            var query = from c in list1
                join dist in list2 on c.City equals dist.City
        
                select dist.City;

            foreach (var city in query)
            {
                 Console.WriteLine(city);
            }
            Console.ReadLine();

        } 

        }
    }
