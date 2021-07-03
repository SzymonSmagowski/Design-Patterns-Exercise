namespace TaskX22
{
    class Product : IPicture
    {
        public string LeftFrame { get; set; }

        public string RightFrame { get; set; }

        public string Color { get; set; }

        public string Text { get; set; }

        public Product(string left, string right, string color, string text)
        {
            LeftFrame = left;
            RightFrame = right;
            Color = color;
            Text = text;
        }
        public void Print()
        {
            System.Console.WriteLine(LeftFrame+Color+RightFrame+Text+ LeftFrame + Color + RightFrame);
        }
    }
}
