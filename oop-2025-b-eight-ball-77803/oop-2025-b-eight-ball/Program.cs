


// Ask the user to enter a question
using oop_2025_b_eight_ball;

Console.WriteLine("Ask the Magic Eight Ball a question:");
string question = Console.ReadLine();

string answer = MagicEightBall.GetEightBallReponse();   

// Show the answer
Console.WriteLine("\nMagic Eight Ball says: " + answer);