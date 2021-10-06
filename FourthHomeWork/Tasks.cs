using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthHomeWork
{
    class Tasks
    {
        //Найти минимальный элемент массива
        public static string Еxercise1(int[] array)
        {
            
            int i = 0;
            int minValue = array[i];
            string message = "";

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            message = $"Минимальный элемент массива равен {minValue}";

            return message;
        }

        //Найти максимальный элемент массива
        public static string Еxercise2(int[] array)
        {
            int i = 0;
            int maxValue = array[i];
            string message = "";

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            message = $"Максимальный элемент массива равен {maxValue}";

            return message;
        }

        //Найти индекс минимального элемента массива
        public static string Еxercise3(int[] array)
        {
            int i = 0;
            int minIndex = 0;
            int minValue = array[i];
            string message = "";

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            message = $" Индекс минимального элемента массива равен {minIndex}";

            return message;
        }

        //Найти индекс максимального элемента массива
        public static string Еxercise4(int[] array)
        {
            int i = 0;
            int maxIndex = 0;
            int maxValue = array[i];
            string message = "";

            for (i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            message = $" Индекс максимальный элемент массива равен {maxIndex}";

            return message;
        }

        //Посчитать сумму элементов массива с нечетными индексами
        public static string Еxercise5(int[] array)
        {
            string message = "";
            int sum = 0;
            int i = 0;

            for ( i = 0 ; i < array.Length ; i++ )
            {
                if ( i % 2 != 0 )
                {
                    sum += array[i];
                }
            }

            message = ($" Cумма элементов массива с нечетными индексами равна {sum}");

            return message;
        }

        //Сделать реверс массива (массив в обратном направлении)
        public static int[] Еxercise6(int[] array)
        {
            int tmp = 0;
            int j = array.Length - 1;

            for (int i = 0; i < array.Length / 2; i++)
            {
                tmp = array[i];
                array[i] = array[j - i];
                array[j - i] = tmp;
            }

            return array;
        }

        //Посчитать количество нечетных элементов массива
        public static string Еxercise7(int[] array)
        {
            string message = "";
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    j++;
                }
            }

            message = $" Количество нечетных элементов массива равно {j}";

            return message;
        }

        //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public static int[] Еxercise8(int[] array)
        {
            int tmp = 0;
            int j = array.Length / 2;
            int c = array.Length % 2;

            for (int i = 0; i < j ; i ++)
            {
                tmp = array[i];
                array[i] = array[j + i + c];
                array[j + i + c] = tmp;
            }

            return array;
        }

        //Отсортировать массив по возрастанию одним из способов:
        //пузырьком(Bubble), выбором(Select) или вставками(Insert)) 
        public static int[] Еxercise9(int[] array)
        {
            int minIndex = 0;
            int minValue = 0;
            
            //index
            int i = 0;
            int j = 0;

            for ( i = 0 ; i < array.Length - 1 ; i++ )
            {
                minIndex = i;
                minValue = array[i];

                for ( j = i + 1 ; j < array.Length ; j++ )
                {
                    if ( array[j] < minValue )
                    {
                        minValue = array[j];
                        minIndex = j;
                    }
                }

                minValue = array[i];
                array[i] = array[minIndex];
                array[minIndex] = minValue;

            }
            
            return array;
        }

        //Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :
        //пузырьком(Bubble), выбором(Select) или вставками(Insert))
        public static int[] Еxercise0(int[] array)
        {
            int tmp = 0;
            int j = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                j = i;
                while (j < array.Length - 1 && array[j] < array[j + 1])
                {
                    tmp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tmp;
                    
                    j++;
                }
            }

            return array;
        }

    }
}
