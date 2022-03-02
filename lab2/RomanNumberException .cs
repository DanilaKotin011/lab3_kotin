using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class RomanNumberException : Exception
    {
        //Overriding the Message property
        public override string Message
        {
            get
            {
                return "false number";
            }
        }
    }
}
