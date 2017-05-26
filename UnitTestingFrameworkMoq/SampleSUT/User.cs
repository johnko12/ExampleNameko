using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSUT
{
    public class User : IUser
    {
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }

        public int CalculateAge()
        {
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
}
