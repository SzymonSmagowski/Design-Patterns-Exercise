using System;
using System.Collections.Generic;

namespace TaskX22
{
    class Program
    {
        private readonly static Order[] orders =
        {
            new Order("circle", "red", "Hello", "spacing"),
            new Order("square", "green", "HelloWorld", "spacing"),
            new Order("triangle", "blue", "ChainIsBeauty", "spacing"),

            new Order("circle", "red", "Hello", "uppercase"),
            new Order("square", "green", "HelloWorld", "uppercase"),
            new Order("triangle", "blue", "ChainIsBeauty", "uppercase"),

            new Order("circle", "red", "Hello", "lowercase"),
            new Order("square", "yellow", "HelloWorld", "lowercase"),
            new Order("hash", "red", "ChainIsBeauty", "uppercase"),

            new Order("", "green", "ChainIsBeauty", "uppercase"), //invalid order
            new Order("star", "1234", "ChainIsBeauty", "uppercase"), //invalid order
            new Order("star", "green", null, "uppercase"), //invalid order
        };

        
        static void ProducePicturesComplex(IEnumerable<Order> orders)
        {
            foreach (var o in orders)
            {
                Product tmpPic = new Product("", "", "", "");
                BetweenerComplex b1 = new ComponentTextComplex();
                b1.Handle(o, tmpPic);
                b1 = new ComponentLeftComplex();
                b1.Handle(o, tmpPic);
                b1 = new ComponentRightComplex();
                b1.Handle(o, tmpPic);
                if (b1.Validate(o) == false)
                {
                    continue;
                }
                b1.Actioner();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--- Simple Production Line ---");
            IColor red = new Red();
            ILeftFrame cl = new CircleLeft();
            IRightFrame cr = new CircleRight();
            ILeftFrame sl = new SquareLeft();
            IRightFrame sr = new SquareRight();
            
            ComponentRightComplex.rightFrames.Add(cr);
            ComponentRightComplex.rightFrames.Add(sr);
            ComponentLeftComplex.leftFrames.Add(cl);
            ComponentLeftComplex.leftFrames.Add(sl);
            ComponentTextComplex.colors.Add(red);
            ProducePicturesComplex(orders);

            //after 1st production

            BetweenerComplex.thickness = 1;

            ILeftFrame tl = new TriangleLeft();
            IRightFrame tr = new TriangleRight();
            IColor green = new Green();
            IColor blue = new Blue();
            ITextPattern spacing = new Spacing();
            ITextPattern upper = new Uppercase();

            ComponentRightComplex.rightFrames.Add(tr);
            ComponentLeftComplex.leftFrames.Add(tl);
            ComponentTextComplex.colors.Add(blue);
            ComponentTextComplex.colors.Add(green);
            ComponentTextComplex.textPatterns.Add(spacing);
            ComponentTextComplex.textPatterns.Add(upper);

            Console.WriteLine();

            Console.WriteLine("--- Complex Production Line ---");
            ProducePicturesComplex(orders);
        }
    }
}
