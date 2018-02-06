using System;
using Chess.Interfaces;

namespace Chess.Classes
{
    class Character
    {
        public IWeaponBehavior WeaponBehavior;

        public void SetWeapon(IWeaponBehavior weaponBehavior)
        {
            this.WeaponBehavior = weaponBehavior;
        }

        public void Fight()
        {
            Console.WriteLine("Ya estoy peleando");
        }
    }
}
