using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX22
{
    interface IPicture
    {
        string LeftFrame { get; }
        string RightFrame { get; }
        string Color { get; }
        string Text { get; }

        void Print();
    }
}
