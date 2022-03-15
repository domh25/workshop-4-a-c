using System;

namespace wkshop_4_algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            static int Raise_1(int abase, int exp, int counter1)
            {
                
                int result = 1;
                int i;
                for (i = 1; i <= exp; i++)
                {
                    result *= abase;
                    counter1 = counter1 + 1;
                }
                Console.WriteLine(counter1);
                return result;
                

            }
            static int Raise_2(int abase, int exp, int counter)
            {
                counter += 1;
                if (exp == 0)
                {
                    return 1;
                }
                else
                {
                    Console.WriteLine(counter);
                    return abase * Raise_2(abase, exp - 1, counter);
                    
                }
                
            }
            
            static int Raise_3(int abase, int exp, int counter)
            {
                counter += 1;
                if (exp == 0)
                {
                    return 1;
                }
                else
                {
                    int half = Raise_3(abase, exp / 2, counter);
                    if (exp % 2 == 0)
                    {
                        Console.WriteLine(counter);
                        return half * half;
                    }
                    else
                    {
                        Console.WriteLine(counter);
                        return abase * half * half;
                    }
                    
                }
            }
            //Console.WriteLine(Raise_1(2, 4, counter1));
            //Console.WriteLine(Raise_2(2, 4, counter2));
            //Console.WriteLine(Raise_3(2, 4, counter3));

            static int BinarySearch_R(int key, int[] array, int low, int high)
            {
                int counter5 = 0;
                if (low > high) return -1;
                int mid = (low + high) / 2;
                if (key == array[mid])
                {
                    counter5+=1;
                    Console.WriteLine(counter5);
                    return mid;
                }
                if (key < array[mid])
                {
                    counter5+=1;
                    return BinarySearch_R(key, array, low, mid - 1);
                }             
                else
                {
                    counter5+=1;
                    return BinarySearch_R(key, array, mid + 1, high);
                }
            }


            static int BinarySearch(int K, int[] A, int L, int R)
            {
                int midpoint;
                int counter4 = 0;
                while (L <= R)
                {
                    
                    midpoint = (L + R) / 2;
                    if (K == A[midpoint])
                    {
                        counter4+=1;
                        Console.WriteLine(counter4);
                        return midpoint;
                    }
                    else if (K > A[midpoint])
                    {
                        counter4+=1;
                        L = midpoint + 1;
                    }
                    else
                    {
                        counter4+=1;
                        R = midpoint - 1;
                    }
                }
                
                return -1;
            }
            int[] array1= {-5, 6, 7, 8, 9, 10, 12, 13, 14, 23, 25, 26, 27, 44, 66, 78};
            Console.WriteLine(BinarySearch_R(25, array1, 0, 15));
            Console.WriteLine(BinarySearch(25, array1, 0, 15));
        }
    }
}
