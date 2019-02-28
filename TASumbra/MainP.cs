using System;
using System.Diagnostics;
using System.Threading;
using WindowsInput;
using WindowsInput.Native;

namespace ConsoleApp1
{
    class MainP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World !");
            InputSimulator i = new InputSimulator();
            // Simulate each key stroke

            //i.Keyboard.KeyDown(VirtualKeyCode.SHIFT);
            NOP(3.0);
            i.Keyboard.KeyDown(VirtualKeyCode.LSHIFT);
            i.Keyboard.KeyDown(VirtualKeyCode.VK_Z).Sleep(1000).KeyUp(VirtualKeyCode.VK_Z);
            i.Keyboard.KeyUp(VirtualKeyCode.LSHIFT);
            return;
            for (int no = 0; no < 13; no++)
            {
                i.Mouse.MoveMouseBy(30, 0);
                NOP(16667);
            }
            Console.ReadLine();

        }
        /// <summary>
        /// pause pendant n secondes
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
        /// pause pendant n microsecondes
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