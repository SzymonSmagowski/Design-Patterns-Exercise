using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskX22
{
    abstract class BetweenerComplex : IMachine
    {
        public Order o;
        abstract public void Handle(Order order, Product picture);
        static public int thickness;
        public static bool IsAlpha(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (!(c >= 'A' && c <= 'Z') && !(c >= 'a' && c <= 'z'))
                {
                    return false;
                }
            }
            return true;
        }
        public bool Validate(Order order)
        {
            if ((order.Text == null) || (order.Shape == string.Empty))
            {
                System.Console.WriteLine("Error! Invalid Order");
                return false;
            }
            if ((IsAlpha(order.Color) == false) || (IsAlpha(order.Shape) == false) ||
                (IsAlpha(order.Text) == false) || (IsAlpha(order.Operation) == false))
            {
                System.Console.WriteLine("Error! Invalid Order");
                return false;
            }
            return true;
        }
        public Product product;
        public string LeftFrame { get; set; }
        public string RightFrame { get; set; }
        public string Color { get; set; }
        public string Text { get; set; }
        public void Actioner()
        {

            if ((LeftFrame == "Error!") || (RightFrame == "Error!"))
            {
                System.Console.WriteLine("Error! Cannot create picture!");
                return;
            }

            product.Print();
        }
    }
    class ComponentLeftComplex : BetweenerComplex
    {
        static public List<ILeftFrame> leftFrames = new();

        public override void Handle(Order order, Product picture)
        {

            o = order;
            product = (Product)picture;
            if (o.Shape == "")
            {
                LeftFrame = "";
                picture.LeftFrame = "";
                return;
            }
            LeftFrame = "Error!";
            foreach (var l in leftFrames)
            {
                if (l.LeftFrameKey == o.Shape)
                {
                    l.thickness = thickness;
                    LeftFrame = l.LeftFrameAction();
                    picture.LeftFrame = l.LeftFrameAction();
                }
            }
        }
    }
    class ComponentRightComplex : BetweenerComplex
    {
        static public List<IRightFrame> rightFrames = new();

        public override void Handle(Order order, Product picture)
        {
            o = order;
            product = (Product)picture;
            RightFrame = "Error!";
            foreach (var l in rightFrames)
            {
                if (l.RightFrameKey == o.Shape)
                {
                    l.thickness = thickness;
                    RightFrame = l.RightFrameAction();
                    picture.RightFrame = l.RightFrameAction();
                }
            }
        }
    }
    class ComponentTextComplex : BetweenerComplex
    {
        static public List<ITextPattern> textPatterns = new();
        static public List<IColor> colors = new();

        public override void Handle(Order order, Product picture)
        {
            //thickness = 1;
            thickness = 2;
            o = order;
            product = picture;
            Text = o.Text;
            picture.Text = o.Text;
            foreach (var l in textPatterns)
            {
                thickness = 1;
                if (l.TextKey == o.Operation)
                {
                    Text = l.TextAction(o.Text);
                    picture.Text = l.TextAction(o.Text);
                }
            }
            Color = string.Empty;
            foreach (var l in colors)
            {
                if (l.ColorName == o.Color)
                {
                    Color = o.Color;
                    picture.Color = o.Color;
                }
            }
            if(Color == string.Empty)
            {
                thickness = 2;
            }
            if (o.Operation == "spacing")
            {
                thickness = 2;
            }
            if((Color == string.Empty) && (o.Operation == "spacing")&&(textPatterns.Count!=0))
            {
                thickness = 3;
            }
        }
    }
}
