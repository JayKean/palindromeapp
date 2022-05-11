//Jayden Kean
//Palindrome project for Datacom HireVue process

/*A Palindrome is a word that is spelt the same backwards as it is forwards*/
/*some examples being words like "mum", "dad" or even "Racecar"*/
public class Palindrome
{
    static void Main(string[] args)
    {
        /*creates string variables to store 2 instances of the users word
        to be compared after input */
        string UserWord, RevWord = string.Empty;
    
        //prompts the user to input
        Console.Write("Enter Word: ");
        //stores user input in a string variable
        UserWord = Console.ReadLine();
        
        if (UserWord != null)
        {
            for (int i = UserWord.Length - 1; i >=0; i--)
            {
                RevWord += UserWord[i].ToString();
            }
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

