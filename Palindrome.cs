//Jayden Kean
//Palindrome project for Datacom HireVue process

/*A Palindrome is a word that is spelt the same backwards as it is forwards*/
/*some examples being words like "mum", "dad" or even "Racecar"*/
public class Palindrome
{
    static void Main(string[] args)
    {
        /*creates string variables to store 2 instances of the users input
        to be compared later*/
        string UserWord, RevWord = string.Empty;
    
        //prompts the user to input and stores it in a string variable
        Console.Write("Enter Word: ");
        UserWord = Console.ReadLine();
        
        //only runs palindrome checker if user has inputted accepted value
        if (UserWord != null)
        {
            //simple loop that reverses the inputted word and stores to revWord variable
            for (int i = UserWord.Length - 1; i >=0; i--)
            {
                RevWord += UserWord[i].ToString();
            }

            /*compares the reversed word to the original word
            if they are equal then the word is a palindrome 
            returns a response to the user*/
            if (RevWord == UserWord)
            {
                Console.WriteLine("The Word {0} is a Palindrome!!!", UserWord);
                Console.WriteLine("Inputted Word: {0} Reverse of word: {1}", UserWord, RevWord);
            }
            else
            {
                Console.WriteLine("The Word {0} is NOT a Palindrome!!!", UserWord);
                Console.WriteLine("Inputted Word: {0} Reverse of word: {1}", UserWord, RevWord);
            }
        }   
       
    }
}

