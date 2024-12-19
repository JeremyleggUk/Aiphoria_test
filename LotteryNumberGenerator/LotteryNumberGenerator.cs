namespace LotteryNumberGenerator
{
    public static class LotteryNumberGenerator
    {
        public static List<int> GenerateRandomNumbersForLength(int min, int max, int length)
        {
            if (min >= max || length < 1)
            {
                throw new ArgumentException("Invalid min/max or length");
            }

            Random random = new Random();
            var randomNumbers = new List<int>();

            while (randomNumbers.Count < length)
            {
                var randomNumber = random.Next(min, max);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            randomNumbers.Sort();

            return randomNumbers;
        }
    }
}
