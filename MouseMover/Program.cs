using System;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;

namespace MouseMover
{
    class Program
    {

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(out Point lpPoint);

        static void Main(string[] args)
        {
            MoveCursor();
        }

        private static void MoveCursor()
        {
            bool left = true;
            Point point;

            while(true)
            {
                GetCursorPos(out point);

                if (left)
                    SetCursorPos(point.X - 1, point.Y);
                else
                    SetCursorPos(point.X + 1, point.Y);

                left = !left;

                Console.WriteLine("Mouse Moved!");
                Thread.Sleep(2 * 60000);
            }
            
        }
    }
}
