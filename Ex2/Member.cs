using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Member
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime DateJoined { get; set; }



        public override string ToString()
        {
            return $"{Name} {Type} on {DateJoined.ToShortDateString()} ";
        }
    }
}
