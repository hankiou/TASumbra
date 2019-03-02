using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;

namespace TASumbra
{
    class Mouse
    {
        private InputSimulator simulator;

        public Mouse(InputSimulator simulator)
        {
            this.simulator = simulator;
        }

        /*
         * Moves the mouse by a quantity in the given direction for the given duration
         * 
         * angle: float, (in degrees) defines in which direction the crosshair shoud move, (right is 0°)
         * amount: int, how many distance units should the crosshair travel (distance unit has't been defned yet)
         * frameCount: int, defines move duration, how many frames will it take to complete
         */
        public void move(double angle, int amount, int frameCount)
        {
            double rad = angle * Math.PI / 180;
            double dirX = amount * Math.Cos(rad);
            double dirY = amount * Math.Sin(rad);
            

            for (int frame = 0; frame < frameCount; frame++)
            {
                simulator.Mouse.MoveMouseBy((int)dirX, (int)-dirY);
                MainP.NOP(16667);
            }
            
        }
    }
}