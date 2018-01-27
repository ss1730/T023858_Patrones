using System;
using Chess.Clases;
using Chess.Interfaces;

namespace Chess.Classes.WeaponsBehaviors
{
    class KnifeBehavior: IWeaponBehavior
    {
      
        public void UseWeapon()
        {
            Console.WriteLine("Usando KnifeBehavior!");
        }
    }
}
