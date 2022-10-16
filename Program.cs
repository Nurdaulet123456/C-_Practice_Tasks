using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    class Program
    {
static void Main(string[] args)
        {
            Fraction a = new Fraction();
            a.num = 6;
            a.den = 7;
            Fraction b = new Fraction(3, 2);
            Fraction c = new Fraction(3, 2);
            Vector3 v1 = new Vector3(1,2,3);
            Vector3 v2 = new Vector3(4,3,2);
            double asa = Vector3.DistanseBettween(v1, v2);
            int s = 5;

            Console.WriteLine(b != c);
            Console.WriteLine(asa);
            Console.ReadKey();
            
        }

        // Fraction
        class Fraction {
            public int num;
            public int den;
            public Fraction()
            {
                den = 1;
            }
            public Fraction(int num, int den = 1)
            {
                this.num = num;
                this.den = den;
            }
            public override string ToString()
            {
                return num + "/" + den;
            }
            //F(x), Sum(a, b) 
            // a+b = 
            // a>b = 
            public static Fraction operator +(Fraction a, Fraction b)
            {
                Fraction c = new Fraction();
                c.num = a.num * b.den + b.num * a.den;
                c.den = a.den * b.den;
                return c;
            }
            public static Fraction operator -(Fraction a, Fraction b)
            {
                Fraction c = new Fraction();
                c.num = a.num * b.den - b.num * a.den;
                c.den = a.den * b.den;
                return c;
            }
            public static bool operator >(Fraction a, Fraction b)
            {
                return a.num * b.den > b.num * a.den;
            }
            public static bool operator <(Fraction a, Fraction b)
            {
                return true;
            }

            public static bool operator >=(Fraction a, Fraction b)
            {
                return a.num * b.den >= b.num * a.den;
            }

            public static bool operator <=(Fraction a, Fraction b)
            {
                return true;
            }

            public static bool operator ==(Fraction a, Fraction b)
            {
                return a.num * b.den == b.num * a.den;
            }

            public static bool operator !=(Fraction a, Fraction b)
            {
                return a.num * b.den != b.num * a.den;
            }
        }

        // Vector3

        class Vector3
        {
            public float x;
            public float y;
            public float z;

            public Vector3()
            {
                this.x = 1;
                this.y = 1;
                this.z = 1;
            }


            public Vector3(float x, float y, float z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public static Vector3 operator +(Vector3 a, Vector3 b)
            {
                float resX = a.x + b.x;
                float resY = a.y + b.y;
                float resZ = a.z + b.z;

                Vector3 vec = new Vector3(resX, resY, resZ);

                return vec;
            }

            public static Vector3 operator -(Vector3 a, Vector3 b)
            {
                float resX = a.x - b.x;
                float resY = a.y - b.y;
                float resZ = a.z - b.z;

                Vector3 vec = new Vector3(resX, resY, resZ);

                return vec;
            }

            public static Vector3 operator *(Vector3 a, int b)
            {
                float resX = a.x * b;
                float resY = a.y * b;
                float resZ = a.z * b;

                Vector3 vec = new Vector3(resX, resY, resZ);

                return vec;
            }

            public static Vector3 operator /(Vector3 a, int b)
            {
                float resX = a.x / b;
                float resY = a.y / b;
                float resZ = a.z / b;

                Vector3 vec = new Vector3(resX, resY, resZ);

                return vec;
            }

            public static double DistanseBettween(Vector3 a, Vector3 b)
            {
                double res = Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2) + Math.Pow((b.z - a.z), 2));

                return res;
            }

            public override string ToString()
            {
                return "(" + x + ", " + y + ", " + z + ")";
            }
        }
    }

}