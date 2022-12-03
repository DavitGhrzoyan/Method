using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the length of Array:\t "); // mutq enq anum Array-i chap@ (erkarutyun@)
            int elementsCount = int.Parse(Console.ReadLine());
            int[] myArray = new int[elementsCount];
            Random rnd = new Random();

            for (int i = 0; i < elementsCount; i++)
            {
                myArray[i] = rnd.Next(-100, 100);
            }

            Meth("Davit ", 26);
            Meth("Zero", null);
            Console.WriteLine(xndir211(myArray));
            Console.WriteLine(xndir212(myArray));
            Console.WriteLine(xndir213(myArray));
            Console.WriteLine(xndir214(myArray));
            Console.WriteLine(xndir215(myArray));
            Console.WriteLine(xndir216(myArray));
            Console.WriteLine(xndir217(myArray));
            Console.WriteLine(xndir218(myArray));
            Console.WriteLine(xndir219(myArray, 2));

            arrPrint(xndir220(myArray));
            Console.WriteLine(xndir221(myArray, 2, 6));

            Matric(10, 15);

            CalcInt(2000);
            Console.WriteLine();
            Console.WriteLine("___________________________________________________");
            arrPrint(myArray);
            
        }
        static void arrPrint(int[] myArray)
        {
            Console.Write("| ");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + "| "); // tpum enq Array@
            }

        }
        static double xndir211(int[] myArray)
        {
            double sum1 = 0;
            double sum2 = 0;
            double result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]); // tpum enq Array@

                if (myArray[i] > 0)  // Stugum enq drakan tver@
                {
                    sum2++;
                    sum1 = sum1 + myArray[i];
                    result = sum1 / sum2;
                }

            }
            return result;
        }
        static double xndir212(int[] myArray)
        {
            double sum1 = 0;
            double sum2 = 0;
            double result = 0;


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]); // tpum enq Array@

                if (myArray[i] > 0)  // Stugum enq drakan tver@
                {
                    double temp = myArray[i] * myArray[i];

                    sum2++;
                    sum1 = sum1 + temp;
                    result = sum1 / sum2;
                }
            }
            return result;
        }
        static double xndir213(int[] myArray)
        {
            double sum1 = 0;
            double sum2 = 0;
            double result = 0;


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]); // tpum enq Array@

                if (myArray[i] < 0)  // Stugum enq bacasakan tver@
                {
                    double temp = myArray[i] * myArray[i];

                    sum2++;
                    sum1 = sum1 + temp;
                    result = sum1 / sum2;
                }

            }
            return result;
        }
        static double xndir214(int[] myArray)
        {
            double sum1 = 0;
            double sum2 = 0;
            double result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]); // tpum enq Array@

                if (myArray[i] > 0)  // Stugum enq drakan tver@
                {
                    sum2++;
                    sum1 = sum1 + myArray[i];
                    result = sum1 / sum2;
                }

            }
            return result;

        }

        static double xndir215(int[] myArray)
        {
            double result = 0;

            for (int i = 2; i < myArray.Length; i += 2)
            {
                result = result + myArray[i];
            }
            return result;

        }

        static int xndir216(int[] myArray)
        {
            int result = 1;
            for (int i = 2; i < myArray.Length; i += 2)
            {
                result = result * myArray[i];
            }



            return result;
        }

        static long xndir217(int[] myArray)
        {
          long result  = 0;

            for (int i = 1; i < myArray.Length; i+=2)
            {
                result = result + (myArray[i] * myArray[i]);
            }
            return result;
        }

        static int xndir218(int[] myArray)
        {
            int result = 0;

            for (int i = 1; i < myArray.Length; i+=2)
            {
                result = result + Math.Abs(myArray[i]);
            }


            return result;
        }

        static int xndir219(int[] myArray, int k)
        {
            int result = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                if (i % k == 0)
                {
                    result += 1;
                }
            }
            return result;
        }

        static int[] xndir220(int[] myArray)
        {
            int[] resultArr = {0,0};

            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] >= 0)
                {
                    resultArr[0] += 1;
                }
                else
                {
                    resultArr[1] += 1;
                }
            }
            return resultArr;
        }

        static int xndir221(int[] myArray, int a, int b)
        {
            int result = 0;

            if (a <= 0 || b > myArray.Length)
            {
                return 1;
            }
              
            for (int i = a; i <= b; i++)
            {
                result = result + myArray[i];
            }

            return result;
        }
        public static string Meth (string s, int?t)
        {
            if(t > 0)
            {
                return "Hellow" + s;
            }
            return s;
        }


        static void Matric(int n, int m)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Random rnd = new Random();
                    
                    Console.Write(rnd.Next(1, 9) + " ");
                }
                Console.WriteLine("\t");
            }

















        }

        
        
        static long  CalcInt(int n)
        {
            long sum = 0;
            sum = n + CalcInt(n);
            return sum;
        }
        




















    }
}
