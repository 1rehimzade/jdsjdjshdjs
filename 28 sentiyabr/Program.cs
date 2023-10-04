
static void Main()
{
   
    double[] ededler = { 1.5, 2.7, 3.1, 4.8, 5.2 };

   
    double cem = 0;

    for (int i = 0; i < ededler.Length; i++)
    {
        cem += ededler[i];
    }

   
    Console.WriteLine("Array elementlərinin cəmi: " + cem);
}