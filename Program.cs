using System;
using Microsoft.Extensions.DependencyInjection;
using WCTC_Battle.Models;

namespace WCTC_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy();
            enemy.Name = "Pikachu";
            enemy.Leather.Defense = 5;
            enemy.Gun.Power = 5;
            enemy.Gun.Size="BIG!";

            // DEPENDENCY INJECTION
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IArmor, Leather>()
                .AddSingleton<IWeapon, Sword>()
                .AddSingleton<IWeapon, Gun>()
                .AddSingleton<ICombatant, Fighter>()
                .BuildServiceProvider();

            var fighter = serviceProvider.GetService<ICombatant>();
            
            fighter.Attack(enemy);

        }
    }
}
