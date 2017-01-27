using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DoesSomeStuffService();

            CalculateCookiesMean(service);
            CalculateCookiesForMonsters(service);
            CheckCookiePackageAmount(service);
            NullCookieMeal(service);
            Console.ReadKey();
        }

        private static void CalculateCookiesMean(DoesSomeStuffService service)
        {
            try
            {
                service.CalculateCookiesMean();
                Console.WriteLine(service.GetCookieMonsterMood());
            }
            catch (Exception e)
            {
                Log(e);
            }
        }


        private static void CalculateCookiesForMonsters(DoesSomeStuffService service)
        {
            try
            {
                service.CalculatesCookiesForMonsters(0);
                Console.WriteLine(service.GetCookieMonsterMood());
            }
            catch (Exception e)
            {
                Log(e);
            }
        }

        private static void CheckCookiePackageAmount(DoesSomeStuffService service)
        {
            try
            {
                service.CheckCookiePackageAmount(-1, 10);
                Console.WriteLine(service.GetCookieMonsterMood());
            }
            catch (Exception e)
            {
                Log(e);
            }
        }

        private static void NullCookieMeal(DoesSomeStuffService service)
        {
            try
            {
                service.NullCookieMeal();
                Console.WriteLine(service.GetCookieMonsterMood());
            }
            catch (Exception e)
            {
                Log(e);
            }
        }

        private static void Log(Exception exception)
        {
            var message = exception.Message;
            var innerException = exception.InnerException;

            Console.WriteLine(message);
            Console.WriteLine(innerException?.Message);
        }
    }
}
