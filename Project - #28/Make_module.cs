using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;

namespace ConsoleApplication1
{
    class myArr
    {
        int[] arr;         
        public int Length;
        public myArr(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }
        // Простой индексатор         
        public int this[int index]
        {
            set   	// Устанавливаем массим элементов
            {
                arr[index] = value;
            }             
            get             
            {
                return arr[index];
            }
        }
    }
    class Program
    {
        static void Main()
        {
            myArr h = new myArr(10);                        
        // Инициализируем каждый индекс экземпляра класса arr1 for (int i = 0; i < i.Length; i++)
            {
                i[i] = i * 2;
                Console.Write("{0} ", i[i]);
            }
         }
    }
}