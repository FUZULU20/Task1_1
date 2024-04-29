using System;


class Program
{
    static void Main()
    {
        int length = 1;
        bool okeylength = false;

        while (!okeylength)
        {
            Console.WriteLine("Massivin uzunluğunu girin:");
            string lengthEntry = Console.ReadLine();

            if (int.TryParse(lengthEntry, out length))
            {
                okeylength = true;
            }
            else
            {
                Console.WriteLine("Reqem tipli dəyər daxil edin");
            }
        }

        string[] massiv = new string[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            massiv[i] = random.Next(1000).ToString();
            Console.WriteLine(massiv[i]);
        }
        
    }
}
