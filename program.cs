using System;

namespace Abstraction
{
    abstract class ListShapes{
        public abstract double area();
    }
    class circle : ListShapes{
        private double radius;
        public circle(double r){
            radius = r;
        }
        public override double area(){
            return (3.14 * radius * radius);
        }
    }
    class rectangle : ListShapes{
        private double SideLength;
        public rectangle(double s){
            SideLength = s;
        }
        public override double area(){
            return (SideLength * SideLength);
        }
    }
    class TriAngle : ListShapes{
        private double bases;
        private double Height;
        public TriAngle(double a, double t){
            bases = a;
            Height = t;
        }
        public override double area(){
            return (0.5 * bases * Height);
        }
    }
    class MainProgram{
        static void Main(string[] args){
            circle C = new circle(14.0);
            Console.WriteLine("Luas Lingkaran \t\t= {0}", C.area());
            rectangle K = new rectangle(18.0);
            Console.WriteLine("Luas Persegi \t\t= {0}", K.area());
            TriAngle S = new TriAngle(18.0, 5.0);
            Console.WriteLine("Luas Segitiga \t\t= {0}", S.area());
        }
    }
}