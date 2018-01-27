using System;
using Chess.Clases;
using Chess.Interfaces;

namespace Chess.Classes.WeaponsBehaviors
{
    class AxeBehavior: IWeaponBehavior
    {

        public void UseWeapon()
        {
           Console.WriteLine("Usando AxeBehavior!");
        }
    }
}
