using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndGithub
{
    class M12299513 : Student, IStudent
    {
        public M12299513(string MNumber) : base(MNumber)
        {
            
        }

        public override long ComputeLargestPrimeFactor(long num)
        {

            long i = 2;
            while(i * i <= num)
            {
                if (num % i == 0) num /= i;

                else ++i;                                    
            }
            return num;
        }
    }
}
