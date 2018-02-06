using System;
using Chess.Clases;
using Chess.Interfaces;

namespace Chess.Classes.WeaponsBehaviors
{
    class SwordBehavior: IWeaponBehavior
    {
       

        public void UseWeapon()
        {
            Console.WriteLine("Usando SwordBehavior!");
        }
    }
}
