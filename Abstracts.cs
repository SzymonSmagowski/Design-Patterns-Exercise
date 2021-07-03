using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX22
{
    interface ILeftFrame
    {
        public string LeftFrameKey { get; set; }

        public int thickness { get; set; }
        public string LeftFrameAction();
    }
    interface IRightFrame
    {
        public string RightFrameKey { get; set; }
        public int thickness { get; set; }

        public string RightFrameAction();
    }
    interface ITextPattern
    {
        public string TextKey { get; set; }
        public string TextAction(string s);
    }
    interface IColor
    {
        public string ColorName { get; set; }
    }
    
    interface IMachine
    {
        void Handle(Order order, Product picture);
        string LeftFrame { get; set; }
        string RightFrame { get; set; }
        string Color { get; set; }
        string Text { get; set; }
        
    }
}
