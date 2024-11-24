using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        bool isRunning = true;
        string userInput;
        Reference alma = new Reference("Alma", 7, 11, 13);
        Scripture scripture = new Scripture(
            alma,
            "7 For behold, I say unto you there be many things to come; and behold, there is one thing which is of more importance than they all—for behold, the time is not far distant that the Redeemer liveth and cometh among his people. \n\n8 Behold, I do not say that he will come among us at the time of his dwelling in his mortal tabernacle; for behold, the Spirit hath not said unto me that this should be the case. Now as to this thing I do not know; but this much I do know, that the Lord God hath power to do all things which are according to his word. \n\n9 But behold, the Spirit hath said this much unto me, saying: Cry unto this people, saying—Repent ye, and prepare the way of the Lord, and walk in his paths, which are straight; for behold, the kingdom of heaven is at hand, and the Son of God cometh upon the face of the earth."
        );

        while(isRunning)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("(Press 'Enter' to continue, or type 'quit'): ");
            userInput = Console.ReadLine();

            if(userInput.ToLower() == "q" || userInput.ToLower() == "quit")
            {
                isRunning = false;
            }
            else if(scripture.IsCompletelyHidden())
            {
                isRunning = false;
            }
            else
            {
                scripture.HideRandomWords(5);
            }
        }
        Console.Clear();
    }
}