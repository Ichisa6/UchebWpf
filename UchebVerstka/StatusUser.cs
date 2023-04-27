using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UchebVerstka
{
    internal class StatusUser
    {
        public StatusUser()
        {
        }

        public StatusUser(int id, string lName, string fName, int age, string city)
        {
            Id = id;
            LName = lName;
            FName = fName;
            Age = age;
            City = city;
        }

        public int Id { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


    }
}
