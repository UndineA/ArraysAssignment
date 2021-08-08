using System;

namespace ArrayAssignment
{
    class ArrayAssignment
    {
        static void Main(string[] args)
        {
            int[] elements = {10, 4, -4, 7, 0, 9, 1, 3, 7, -5};
            Console.WriteLine("Negative numbers in the array: ");
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < 0)
                Console.Write(elements[i] + "\t");       
            }
            
            Console.WriteLine("\nOdd numbers in the array: ");
            for (int i = 0; i < elements.Length; i++)
            {
            if (elements[i]%2 != 0) 
            Console.Write(elements[i] + "\t");
            }
            
            int oddNumbers = 0;
            Console.WriteLine("\nCount of odd numbers in the array: ");
            for (int i = 0; i < elements.Length; i++)
            {
            if (elements[i]%2 != 0) 
                oddNumbers++;
            }
            Console.Write(oddNumbers);


            Console.WriteLine("\nEach second element in the array: ");
            for (int i = 1; i < elements.Length; i += 2)
            {
                Console.Write(elements[i] + "\t");
            }

            int sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            float averageNum = (float)sum / elements.Length;
            Console.WriteLine("\nAverage of array elements: \n" + averageNum);

            Console.WriteLine("Elements what are smaller than the average value: ");
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < averageNum)
                Console.Write(elements[i] + "\t");
            }

    
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (elements[i] == elements[j])
                    {
                        Console.WriteLine("\nNumber " + elements[i] + " is repeated");
                        break;
                    }
                }
            }
        }
    }
}