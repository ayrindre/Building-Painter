using System;

namespace BuildingPainter
{
    class Program
    {
        static void Main(string[] args)
        {
            naghash n =new naghash();
            System.Console.Write(" What kind of color do you want? (roghani or acrylic) : ");
            n.TypeColor=Console.ReadLine();
            
            System.Console.Write("Enter the shape of the place :(square or rectangle) : ");
            n.Shape=Console.ReadLine();

            n.paymanent();
            
            
        }
    }
    class naghash
    {
        private string typecolor;
        public static int PriceColor;
        private string shape;
        public static double Abbad;
        public string TypeColor
        {
            get{return typecolor;}
            set{
                while (value!="roghani" && value!="acrylic")
                {
                System.Console.Write("---------ERROR--------- >> roghani or acrylic :    ");
                value=Console.ReadLine();
                }
                System.Console.WriteLine("*******************************************************");
                if (value == "roghani")
                {
                    PriceColor = 13000;
                }else if (value=="acrylic")
                {
                     PriceColor=11000;
                }
            }
        }
        public string Shape 
        {
            get{return shape;}
            set{
                while (value!="square" && value!="rectangle")
                {
                    System.Console.Write("-------ERROR--------- >> square or rectangle :   "); 
                    value = Console.ReadLine();
                }
                System.Console.WriteLine("********************************************************");
                if (value == "square")
                {
                    System.Console.Write("Enter Length Room :  ");
                    double l =double.Parse(Console.ReadLine());
                    square s;
                    if (l>0)
                    {
                      s =new square(l);  
                    }
                    else l=0;
                    s =new square(l);
                    Abbad=s.area();
                }else if (value=="rectangle")
                {
                    rectangle r;
                    System.Console.Write("Enter Length Room :  ");
                    double l =double.Parse(Console.ReadLine());
                    System.Console.Write("Enter Width Room :  ");
                    double w =double.Parse(Console.ReadLine());
                    if (l>0 && w>0)
                    {
                      r =new rectangle(l,w);  
                    }
                    else{l=0 ; w=0;}
                    r =new rectangle(l,w);
                    Abbad=r.area();
                }
            }
        }
    
        public void paymanent()
        {
            double n= Abbad * 3 * PriceColor;
            System.Console.WriteLine("__________________________________________________");
            System.Console.WriteLine();
            Console.BackgroundColor=ConsoleColor.White;
            Console.ForegroundColor=ConsoleColor.Black;
            System.Console.WriteLine();
            System.Console.WriteLine("         pay manent is :       {0}   Toman              ",n.ToString("0,0"));
            System.Console.WriteLine();
            Console.ResetColor();
        }
    }
    class square :naghash
    {
        private double length;
        public square(double l)
        {
            length = l;
        }
        public double area()
        {
            return length*length;
        }
    }
    class rectangle : naghash
    {
        private double length;
        private double weigth;
        public rectangle(double l ,double w)
        {
            length=l;
            weigth=w;
        }
        public double area()
        {
            return length*weigth;
        }
    }
}
