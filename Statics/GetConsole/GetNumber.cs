
namespace ExaminationSystemOOP.Statics.GetConsole
{
    internal static class GetNumber
    {
        #region GetIntegerValue
        public static int GetIntegerValue()
        {
            int number = 0;

            bool Validation = false;

            while (!Validation)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > 0)
                        Validation = true;
                    else
                    {
                        Console.WriteLine("Zero Value Not Accepted! \nThe number must be greater that 0");
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong Format! \nPlease Enter a Correct Format");
                }
            }

            Console.Clear();
            return number;
        }
        #endregion

        #region GetIntegerRange
        public static int GetIntegerValue(int min, int max)
        {
            int number = 0;

            bool Validation = false;

            while (!Validation)
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());

                    if (number >= min && number <= max)
                        Validation = true;
                    else
                        Console.WriteLine($"Please Enter a Number between {min} ~ {max}");
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Format! \nPlease Enter a Correct Format");
                }
            }

            Console.Clear();
            return number;
        } 
        #endregion
    }
}
