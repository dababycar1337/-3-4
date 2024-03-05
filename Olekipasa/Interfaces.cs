using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App34;
namespace App34
{
    public interface IPrinter
    {
        void Print();
    }

    public interface FunctionsForAllArrays : IPrinter
    {
        void AutoMaker();
        void UserMaker();
    }
}
