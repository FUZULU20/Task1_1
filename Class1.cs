using System;
using static task1.Program

public class Class1
{
	public Class1()
	{

        string max = massiv[0];
        for (int i = 1; i < length; i++)
        {
            if (string.Compare(massiv[i], max) > 0)
            {
                max = massiv[i];
            }
        }

        Console.WriteLine("En büyük değer: " + max);



        string min = massiv[0];
        for (int i = 1; i < length; i++)
        {
            if (string.Compare(massiv[i], min) < 0)
            {
                min = massiv[i];
            }
        }

        Console.WriteLine("En küçük değer: " + min);
    }
}
