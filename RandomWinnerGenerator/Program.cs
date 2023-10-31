namespace RandomWinnerGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Total number of winners
            int totalWinners = 10;

            // Number of winners to recieve a prize
            int prizeWinnersCount = 5;

            // List of winners
            string[] winners =
            {
                "Kathy",
                "Brittany",
                "Lee",
                "Khai",
                "Colton",
                "Katie",
                "Madison",
                "Megan",
                "Callie",
                "Koda"
            };

            // Random number generator
            Random random = new Random();

            // Create an array to store the prize winners
            string[] prizeWinners = new string[prizeWinnersCount];

            // Select the winners
            for (int i = 0; i < prizeWinnersCount; i++)
            {
                int randomIndex;
                do
                {
                    randomIndex=random.Next(totalWinners);
                } while (prizeWinners.Contains(winners[randomIndex]));

                prizeWinners[i] = winners[randomIndex];
            }

            // Display the winners
            Console.WriteLine("Prize Winners");
            foreach (string winner in prizeWinners)
            {
                Console.WriteLine(winner);
            }

        }
    }
}