using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleSUT
{
    //this class will consume IUser
    public class ConsumerOfIUser
    {
        public int Consume(IUser user)
        {
            return user.CalculateAge() + 10;
        }
    }
}
