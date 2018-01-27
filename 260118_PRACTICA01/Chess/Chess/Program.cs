using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Clases;
using Chess.Classes.Characters;
using Chess.Classes.WeaponsBehaviors;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SuperTipo ");
            King king = new King();
            king.SetWeapon(new AxeBehavior());
            king.WeaponBehavior.UseWeapon();
            king.Fight();

            Queen queen = new Queen();
            queen.SetWeapon(new KnifeBehavior());
            queen.WeaponBehavior.UseWeapon();
            queen.Fight();
            
            Troll troll = new Troll();
            troll.SetWeapon(new SwordBehavior());
            troll.WeaponBehavior.UseWeapon();
            troll.Fight();

            Console.ReadKey();

        }
    }
}
