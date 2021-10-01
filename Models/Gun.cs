using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class Gun : IWeapon
    {
        public Gun()
        {
            Name = "Gun";
        }

        public string Name { get; set; }
        public int Power { get; set; }
        public string Size {get;set;}
    }
}