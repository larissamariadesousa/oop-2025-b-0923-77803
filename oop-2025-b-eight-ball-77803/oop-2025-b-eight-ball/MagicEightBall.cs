using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_eight_ball
{
    internal class MagicEightBall
    {
        public static string GetEightBallReponse()
        {
            List<string> responses = new List<string>()
        {
            "It is certain.",
            "Without a doubt.",
            "You may rely on it.",
            "Yes – definitely.",
            "Most likely.",
            "Ask again later.",
            "Cannot predict now.",
            "Don't count on it.",
            "My sources say no.",
            "Very doubtful."
        };

            // Create a Random object
            Random random = new Random();

            // Select a random response
            int index = random.Next(responses.Count);
            string answer = responses[index];

            return answer;

        }
    }
}
