using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignFive.Manager
{
    internal class MenyHelper
    {
        public static void PrintCenter(params string[] lines)
        {
            int verticalStart = (Console.WindowHeight - lines.Length) / 2;
            int verticalPosition = verticalStart;
            foreach (var line in lines)
            {

                int horizontalStart = (Console.WindowWidth - line.Length) / 2;

                Console.SetCursorPosition(horizontalStart, verticalPosition);

                Console.Write(line);

                ++verticalPosition;
            }
        }
    }
}
