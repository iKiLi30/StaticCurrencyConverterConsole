namespace StaticCurrencyConverterConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Its a simple currency converter, convert YOUR currency in MY currency");
            Console.WriteLine("Input number and press Enter");
            Program program = new Program();
            program.Converter();

        }
        void Converter()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int myNumber = number * 2;
            Console.WriteLine($"By our exchange rate {number} YOUR currency is {myNumber} MY currency");
        }
    }
}
