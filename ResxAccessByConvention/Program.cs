using System;

namespace ResxAccessByConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomErro(() => CustomErro.ErrorTwo);

            }
            catch(CustomErro error)
            {
                Console.WriteLine($"Code: {error.ErrorCode} | Message: {error.ErrorMessage}");
                Console.ReadLine();
            }

        }
    }
}
