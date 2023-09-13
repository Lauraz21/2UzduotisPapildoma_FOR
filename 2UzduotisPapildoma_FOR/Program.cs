namespace _2UzduotisPapildoma_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 100; i++)
            {
                
                bool skaiciusPirminis = true;
                int liek = 0;


                for (int j = 2; j < i; j++)
                {
                    liek = i % j; 


                    if (liek == 0)
                    {
                        skaiciusPirminis = false;
                    }

                }
                if (skaiciusPirminis)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}   