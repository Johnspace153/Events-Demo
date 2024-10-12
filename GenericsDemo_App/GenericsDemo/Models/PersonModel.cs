using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public DateTime BirthDate { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            {
                int output;
                DateTime today = DateTime.Now;
                
                output = today.Year - BirthDate.Year;
                if (BirthDate.Date > today.AddYears(-output)) output--;

                _age = output; 
            }
        }



    }
}
