using System.ComponentModel.Design.Serialization;
using System.Numerics;
using System.Xml;
using System.Xml.Linq;

namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;
            // code here
            if (a > 0 && b > 0) answer = true;
            else if (a < 0 && b < 0) answer = true;
                // end

                return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            int d2 = Convert.ToInt32(d);
            if (d2 != d) answer = true;
            Console.WriteLine(d + "\n" + d2);

            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (b == 0) return answer;
            double c = a / b;
            if ((c * b) == a) answer = true;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            double dM = System.Math.Abs(d);
            double fM = System.Math.Abs(f);
            double gM = System.Math.Abs(g);
            List<double> listM = new List<double> { dM, fM, gM };
            List<double> list = new List<double> { d, f, g };

            //Console.WriteLine(listM.IndexOf(listM.Max()));
            answer = list[listM.IndexOf(listM.Max())];
            

            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) answer = 0;
            if (x > -1 && x <= 0) answer = (x + 1);
            if (x > 0) answer = 1;
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double D = (System.Math.Sqrt(circleS / 3.14))*2;
            if (System.Math.Sqrt(squareS) >= D) answer = true;
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (System.Math.Abs(d) < System.Math.Abs(f))
            {
                if (d > 0) answer = -1;
            }
            else
            {
                if (f > 0) answer = 1;
            }

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(ans);

            int mx = (a/2 + b/2 + c/2);
            List <int> lx = new List<int> { a, b, c };
            int m3 = Convert.ToInt32((mx / 3));
            if (m3 <= lx.Min())
            {
                if (mx % 3 != 1) answer = true;
            }
            if (mx < 2) answer = false;
            //Console.WriteLine(answer);
            // end

            return answer;
        }
    }
}
