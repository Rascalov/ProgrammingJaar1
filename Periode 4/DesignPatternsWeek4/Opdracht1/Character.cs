using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht1
{
    abstract class Character
    {
        public IWeaponBehaviour Weapon { get { return weapon; } set { weapon = value; } }
        private IWeaponBehaviour weapon;
        
        public Character()
        {
            Weapon = new AxeBehaviour();//wordt nooit gebruikt
        }
        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
