using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX22
{
    class CircleLeft : ILeftFrame
    {
        public string LeftFrameKey { get; set; }

        public int thickness { get; set; }
        public string LeftFrameAction()
        {
            string tmp = string.Empty;
            for(int i=0; i < thickness; i++)
            {
                tmp += "(";
            }
            return tmp;
        }
        public CircleLeft()
        {
            thickness = 2;
            LeftFrameKey = "circle";
        }
    }
    class CircleRight : IRightFrame
    {
        public int thickness { get; set; }
        public string RightFrameKey { get; set; }

        public string RightFrameAction()
        {
            string tmp = string.Empty;
            for (int i = 0; i < thickness; i++)
            {
                tmp += ")";
            }
            return tmp;
        }
        public CircleRight()
        {
            thickness = 2;
            RightFrameKey = "circle";
        }
    }
    class SquareLeft : ILeftFrame
    {
        public int thickness { get; set; }
        public string LeftFrameKey { get; set; }

        public string LeftFrameAction()
        {
            string tmp = string.Empty;
            for (int i = 0; i < thickness; i++)
            {
                tmp += "[";
            }
            return tmp; ;
        }
        public SquareLeft()
        {
            thickness = 2;
            LeftFrameKey = "square";
        }
    }
    class SquareRight : IRightFrame
    {
        public int thickness { get; set; }
        public string RightFrameKey { get; set; }
        public string RightFrameAction()
        {
            string tmp = string.Empty;
            for (int i = 0; i < thickness; i++)
            {
                tmp += "]";
            }
            return tmp; 
        }
        public SquareRight()
        {
            thickness = 2;
            RightFrameKey = "square";
        }
    }
    class TriangleRight : IRightFrame
    {
        public int thickness { get; set; }
        public string RightFrameKey { get; set; }
        public string RightFrameAction()
        {
            string tmp = string.Empty;
            for (int i = 0; i < thickness; i++)
            {
                tmp += ">";
            }
            return tmp; ;
        }
        public TriangleRight()
        {
            thickness = 2;
            RightFrameKey = "triangle";
        }
    }
    class TriangleLeft : ILeftFrame
    {
        public int thickness { get; set; }
        public string LeftFrameKey { get; set; }
        public string LeftFrameAction()
        {
            string tmp = string.Empty;
            for (int i = 0; i < thickness; i++)
            {
                tmp += "<";
            }
            return tmp; ;
        }
        public TriangleLeft()
        {
            thickness = 2;
            LeftFrameKey = "triangle";
        }
    }
}
