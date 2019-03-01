using System;
using System.Diagnostics;
using WindowsInput;
using System.Windows.Forms;

namespace TASumbra
{
    class MainP
    {
        [STAThread]
        static void Main(string[] args)
        {
            InputSimulator i = new InputSimulator();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppGUI());
            //Application.Exit();
            /*
            NOP(3.0);
            i.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            i.Keyboard.KeyDown(VirtualKeyCode.VK_Z).Sleep(1000).KeyUp(VirtualKeyCode.VK_Z);
            i.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
            for (int no = 0; no < 13; no++)
            {
                i.Mouse.MoveMouseBy(30, 0);
                NOP(16667);
            }*/
        }

        /// <summary>
        /// pause during n seconds
        /// </summary>
        /// <param name="durationSeconds"></param>
        private static void NOP(double durationSeconds)
        {
            var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }

        /// <summary>
        /// pause during n microseconds
        /// </summary>
        /// <param name="microsecs"></param>
        private static void NOP(int microsecs)
        {
            double durationSeconds = ((double)microsecs) / 1000000;
            var durationTicks = Math.Round(durationSeconds * Stopwatch.Frequency);
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }
    }
}