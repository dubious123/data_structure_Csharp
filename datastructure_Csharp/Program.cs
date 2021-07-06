using System;

namespace Array
{
    class Program
    {
        static int GetHighestScore(int[] scores)
        {
            int highest = 0;
            foreach (int i in scores)
            {
                if (highest < i)
                {
                    highest = i;
                }
            }


            return highest;
        }

        static float GetAverageScore(int[] scores)
        {
            if (scores.Length == 0) { return 0; } // 예외처리
            float Sum = 0;
            float average = 0;
            foreach (int i in scores)
            {
                Sum += i;
            }
            average = Sum / scores.Length;
            return average;
        }
        static int[] GetIndexOf(int[] scores, int value)
        {
            int[] indexes = new int[scores.Length];
            int top = -1;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[i] == value)
                {
                    indexes[++top] = i;
                }
            }
            int[] result = new int[top + 1];

            for (int i = 0; i <= top; i++)
            {
                result[i] = indexes[i];
            }
            return result;
        }

        static void Sort(int[] scores)
        {
            int temp = 0;
            for (int i = scores.Length - 1; 0 < i; i--)
            {
                for (int t = 0; t < i; t++)
                {
                    if (scores[t] > scores[i])
                    {
                        temp = scores[t];
                        scores[t] = scores[i];
                        scores[i] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            int[] scores = new int[] { 1, 3, 4, 2, 5, 6, 3, 8, 3, 4, -1 };
            Console.WriteLine($"{GetHighestScore(scores)}");
            Console.WriteLine($"{GetAverageScore(scores)}");
            foreach (int i in GetIndexOf(scores, 3))
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
            Sort(scores);
            foreach (int i in scores)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");


             


        }
    }
}
