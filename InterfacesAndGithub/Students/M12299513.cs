using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Interface Assignment
* Eric Davin
* davinec@mail.uc.edu
* Contmporary Programing 
* Impliment the interface
* Due: 11/20/19 3:30
* Citations: nicomp42's code
*/

namespace InterfacesAndGithub
{
    class M12299513 : Student, IStudent
    {
        public M12299513(string MNumber) : base(MNumber)
        {
            
        }
        /// <summary>
        /// Computes the largest Prime Factor is checked by the isPrime method
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public override long ComputeLargestPrimeFactor(long num)
        {

            long i = 2;
            while(i * i <= num)
            {
                if (num % i == 0 && isPrime(i)) num /= i;

                else ++i;                                    
            }
            return num;
        }
        /// <summary>
        /// Checks if a number is prime
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool isPrime(long num)
        {
            
            if (num <= 1) return false;

            else
            {   
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }
        }
    }
}
