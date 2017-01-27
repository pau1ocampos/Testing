namespace Tests
{
    using System;
    public class DoesSomeStuffService
    {
        private string CookieMonstersMood = string.Empty;

        public double CalculateCookiesMean()
        {
            var cookieMeal = this.GenerateCookiesAndMonsters();

            Guard.Against<DivideByZeroException>(cookieMeal.CookieMonsters == 0, "There are no cookie monsters to eat the cookies! =(");
            var result = (double)(cookieMeal.TotalCookies / cookieMeal.CookieMonsters);
            return Math.Round(result, 2);
        }

        public double CalculatesCookiesForMonsters(int numberOfCookieMonsters)
        {
            Guard.Against<DivideByZeroException>(numberOfCookieMonsters == 0);
            var result = (double)(500 / numberOfCookieMonsters);

            this.CookieMonstersMood = "Dunno!";

            return Math.Round(result, 2);
        }

        public void CheckCookiePackageAmount(int minAmount, int maxAmount)
        {
            Guard.Against<IndexOutOfRangeException>(minAmount > 0 || maxAmount < 100, "This cookie package does not exist in real world... please feed the Cookie Monsters properly! Don't scam them, they are fluffy!");
            CookieMonstersMood = "Awesome!";
        }

        public void NullCookieMeal()
        {
            CookieMeal cookieMeal = null;
            this.CookieMonstersMood = "Sad!";
            Guard.Against<NullReferenceException>(cookieMeal == null, "There's no meal. :'( Cookie Monsters are sad!", new CookieMealException("Please, create a meal!"));
        }

        public string GetCookieMonsterMood()
        {
            return "The Cookie Monsters are " + this.CookieMonstersMood;
        }

        private CookieMeal GenerateCookiesAndMonsters()
        {
            var randomNumber = new Random();
            var totalCookies = randomNumber.Next(50, 100);
            var cookieMonsters = randomNumber.Next(0, 2);

            return new CookieMeal()
            {
                CookieMonsters = cookieMonsters,
                TotalCookies = totalCookies
            };
        }
    }
}
