using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCTC_Battle.Models
{
    public class Fighter : ICombatant
    {
        private readonly IArmor _armor;
        private readonly IWeapon _weapon;
        public string Name { get; set; }

        public Fighter(IArmor armor, IWeapon weapon)
        {
            _armor = armor;
            _weapon = weapon;
            weapon.Size ="BIG";
            Name = "Mark!!";
        }
        public void Attack(Enemy enemy)
        {
            if (_weapon.Power < enemy.Leather.Defense)
            {
                Console.WriteLine($"{this.Name} attacks {enemy.Name} with a {_weapon.Size} {_weapon.Name}");
            }
            else
            {
                Console.WriteLine($"{enemy.Name} blocks the attack by {this.Name} with his {_armor.Name}");
            }
        }
    }
}
