using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App34;
namespace App34
{
    class Program
    {
        static void Main()
        {
            IPrinter[] arrays = new IPrinter[2];
            arrays[0] = new OnedimensionalArray<int>(3, false);
            arrays[1] = new TwoDimensionalArray<bool>(3, 3, false);

            arrays[0].Print();
            arrays[1].Print();
        }
    }
}