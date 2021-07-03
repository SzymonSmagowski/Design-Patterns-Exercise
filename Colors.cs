using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX22
{
    class Red : IColor
    {
        public string ColorName { get; set; }
        public Red()
        {
            ColorName = "red";
        }
    }
    class Green : IColor
    {
        public string ColorName { get; set; }
        public Green()
        {
            ColorName = "green";
        }
    }
    class Blue : IColor
    {
        public string ColorName { get; set; }
        public Blue()
        {
            ColorName = "blue";
        }
    }
}
