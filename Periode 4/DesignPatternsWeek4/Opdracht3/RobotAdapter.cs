opdrachusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3
{
    class RobotAdapter : IAttacker
    {
        Robot robot = new Robot();
        public void AssignDriver()
        {
            robot.MoveByPerson(); 
        }

        public void DriveForward()
        {
            robot.WalkForward();
        }

        public void UseWeapon()
        {
            robot.BashWithHands();
        }
    }
}
