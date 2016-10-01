using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{

    public class Program
    {
        private static void Main(string[] args)
        {
            QuickSort abcd = new QuickSort();
            Random rndm = new Random();

            int[] array = new int[Convert.ToInt32(Console.ReadLine())];
            for (int index = 0; index < array.Length; ++index)
                array[index] = rndm.Next(-1000, 1000);

            abcd.Sort(array, 0, array.Length - 1);

            for (int index = 0; index < array.Length; ++index)
                Console.Write("{0} ", (object)array[index]);

            Console.ReadKey();

        }
    }

    public class QuickSort
    {
        private IComparer comparer = (IComparer)new ClassCMP();

        public void Sort(int[] a, int left, int right)
        {
            int num = a[left + (right - left) / 2 + 1];
            int i = left;
            int j = right;
            int temp;
            while (i <= j)
            {
                while (comparer.Compare(a[i], num) == 1)
                    ++i;
                while (comparer.Compare(a[j], num) == -1)
                    --j;
                if (i <= j)
                {
                    Swap(ref a[i],ref a[j]);
                   
                    i++;
                    j--;
                }
            }

            if (comparer.Compare(i, right) == 1)
                Sort(a, i, right);
            if (comparer.Compare(left, j) == 1)
                Sort(a, left, j);
        }

        public void Swap (ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

    }


    public class ClassCMP : IComparer
    {
        int IComparer.Compare(object firstElement, object secondElement)
        {
            return new CaseInsensitiveComparer().Compare(secondElement, firstElement);
        }
    }

}