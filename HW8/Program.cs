using System;
using static System.Math;
namespace HW8
{
    //task 1
    struct Vector
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public int z { get; set; } = 0;

        public Vector() { }
        public Vector(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public void Multiplay(int a)
        {
            x *= a;
            y *= a;
            z *= a;
        }

        public void AddVect(Vector i)
        {
            x += i.x;
            y += i.y;
            z += i.z;
        }

        public void Dell(Vector i)
        {
            x -= i.x;
            y -= i.y;
            z -= i.z;
        }
    }

    //Task 2

    struct TenthNumber
    {
        public int Value { get; set; } = 0;
        public TenthNumber() { }
        public TenthNumber(int val) { Value = val; }

        public void GetBinaryNumber()
        {
            string num = "";
            int tmp = Abs(Value);
            for (int i = 0; tmp != 0; i++)
            {
                num += Convert.ToInt32(tmp % 2);
                tmp /= 2;
            }

            Console.WriteLine(num);
        }

        public void GetOctalSystem()
        {
            string num = "";
            int tmp = Abs(Value);
            for (int i = 0; tmp != 0; i++)
            {
                num += Convert.ToInt32(tmp % 8);
                tmp /= 8;
            }

            Console.WriteLine(num);
        }

        public void GetHexSystem()
        {
            string num = "";
            int tmp = Abs(Value);
            for (int i = 0; tmp != 0; i++)
            {
                if (tmp % 16 == 10)
                {
                    num += "a";
                }
                else if (tmp % 16 == 11)
                {
                    num += "b";
                }
                else if (tmp % 16 == 12)
                {
                    num += "c";
                }
                else if (tmp % 16 == 13)
                {
                    num += "d";
                }
                else if (tmp % 16 == 14)
                {
                    num += "e";
                }
                else if (tmp % 16 == 15)
                {
                    num += "f";
                }
                else
                {
                    num += Convert.ToInt32(tmp % 16);
                }
                tmp /= 16;
            }
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            num = new string(arr);
            Console.WriteLine(num);
        }
    }

    //Task 3
    struct RGB
    {
        public float r { get; set; } = 0;
        public float g { get; set; } = 0;
        public float b { get; set; } = 0;

        public RGB() { }
        public RGB(int R, int G, int B)
        {
            if (R >= 0 && G >= 0 && B >= 0 && R < 256 && G < 256 && B < 256)
            {
                r = R;
                g = G;
                b = B;
            }
            else
            {
                throw new ArgumentException("uncorrect Value");
            }
        }

        public void ToHex()
        {
            string num = "";
            for (int i = 0; r != 0; i++)
            {
                if (r % 16 == 10)
                {
                    num += "a";
                }
                else if (r % 16 == 11)
                {
                    num += "b";
                }
                else if (r % 16 == 12)
                {
                    num += "c";
                }
                else if (r % 16 == 13)
                {
                    num += "d";
                }
                else if (r % 16 == 14)
                {
                    num += "e";
                }
                else if (r % 16 == 15)
                {
                    num += "f";
                }
                else
                {
                    num += Convert.ToInt32(r % 16);
                }
                r /= 16;
            }
            char[] arr = num.ToCharArray();
            Array.Reverse(arr);
            num = new string(arr);
            Console.WriteLine(num);
            num = "";
            for (int i = 0; g != 0; i++)
            {
                if (g % 16 == 10)
                {
                    num += "a";
                }
                else if (g % 16 == 11)
                {
                    num += "b";
                }
                else if (g % 16 == 12)
                {
                    num += "c";
                }
                else if (g % 16 == 13)
                {
                    num += "d";
                }
                else if (g % 16 == 14)
                {
                    num += "e";
                }
                else if (g % 16 == 15)
                {
                    num += "f";
                }
                else
                {
                    num += Convert.ToInt32(g % 16);
                }
                g /= 16;
            }
            arr = num.ToCharArray();
            Array.Reverse(arr);
            num = new string(arr);
            Console.WriteLine(num);
            num = "";
            for (int i = 0; b != 0; i++)
            {
                if (b % 16 == 10)
                {
                    num += "a";
                }
                else if (b % 16 == 11)
                {
                    num += "b";
                }
                else if (b % 16 == 12)
                {
                    num += "c";
                }
                else if (b % 16 == 13)
                {
                    num += "d";
                }
                else if (b % 16 == 14)
                {
                    num += "e";
                }
                else if (b % 16 == 15)
                {
                    num += "f";
                }
                else
                {
                    num += Convert.ToInt32(b % 16);
                }
                b /= 16;
            }
            arr = num.ToCharArray();
            Array.Reverse(arr);
            num = new string(arr);
            Console.WriteLine(num);
        }

        public void ToHSl()
        {
            float R, G, B;
            R = r / 255;
            G = g / 255;
            B = b / 255;
            float cmin = Min (Min(R, G), B);
            float cmax = Max (Max(R, B), G);
            float delta = cmax - cmin;
            float h;
            if (delta == 0)
                h = 0;
            else if (cmax == R)
                h = ((G - B) / delta) % 6;
            else if (cmax == G)
                h = (B - R) / delta + 2;
            else
                h = (R - G) / delta + 4;
            h = h * 60;
            float s;
            if (delta == 0)
                s = 0; 
            else 
                s = delta / (1 - Abs(2 * cmax - 1));
            float l = (cmax + cmin) / 2;
            if (h < 0)
                h = h + 360;


            Console.WriteLine("H: " + h + "\nS: " + s + "\nL: " + l);
        }

        public void ToCMYK()
        {
            float R, G, B, K, C, M, Y;
            R = r / 255;
            G = g / 255;
            B = b / 255;

            K = Min(Min(1 - R, 1 - G), 1 - B);
            C = (1 - R - K) / (1 - K);
            M = (1 - G - K) / (1 - K);
            Y = (1 - B - K) / (1 - K);
            Console.WriteLine("K: " + K + "\nC: " + C + "\nM: " + M + "\nY: " + Y);
        }
    }
}



