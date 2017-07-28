namespace Tests
{
    using System;
    public class DoesSomeStuffService
    {
        private string _cookieMonstersMood = string.Empty;

        public double CalculateCookiesMean()
        {
            var cookieMeal = this.GenerateCookiesAndMonsters();

            Guard.Evaluate<DivideByZeroException>(cookieMeal.CookieMonsters == 0, "There are no cookie monsters to eat the cookies! =(");
            var result = (double)(cookieMeal.TotalCookies / cookieMeal.CookieMonsters);
            return Math.Round(result, 2);
        }

        public double CalculatesCookiesForMonsters(int numberOfCookieMonsters)
        {
            Guard.Evaluate<DivideByZeroException>(numberOfCookieMonsters == 0);
            var result = (double)(500 / numberOfCookieMonsters);

            this._cookieMonstersMood = "Dunno!";

            return Math.Round(result, 2);
        }

        public void CheckCookiePackageAmount(int minAmount, int maxAmount)
        {
            Guard.Evaluate<IndexOutOfRangeException>(minAmount > 0 || maxAmount < 100, "This cookie package does not exist in real world... please feed the Cookie Monsters properly! Don't scam them, they are fluffy!");
            _cookieMonstersMood = "Awesome!";
        }

        public void NullCookieMeal()
        {
            CookieMeal cookieMeal = null;
            this._cookieMonstersMood = "Sad!";
            Guard.Evaluate<NullReferenceException>(cookieMeal == null, "There's no meal. :'( Cookie Monsters are sad!", new CookieMealException("Please, create a meal!"));
        }

        public string GetCookieMonsterMood()
        {
            return "The Cookie Monsters are " + this._cookieMonstersMood;
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
