// Pig Latin Lab

// Intro and promting user to enter a word


Console.WriteLine("Welcome to the Pig Latin traanslator\n");


bool runProgram = true;
while (runProgram)
{

    Console.WriteLine("Enter a word to translate...");
    string input = Console.ReadLine().ToLower().Trim();
    //string[] words = input.Split(' ').ToArray();     <--- not there yet

    // vowels part

    if (VowelStart(input))      // *NEW* implemented vowel method here
    {
        Console.WriteLine($"{input}way");
    }


    // consonant part


    else if (ConsStart(input) >= 0)  // *NEW* consonant method here
            {
                string half1 = input.Substring(0, ConsStart(input)).ToLower().Trim();  
                string half2 = input.Substring(ConsStart(input)).ToLower().Trim();

                Console.WriteLine($"{half2}{half1}ay");
                break;
            }



    // ask to keep going

    while (true)
    {

        Console.WriteLine("\nAnother word? y/n");
        string choice = Console.ReadLine().ToLower().Trim();

        if (choice == "n")
        {
            runProgram = false;
            Console.WriteLine("Have a nice day!");
            break;
        }
        else if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else
        {
            Console.WriteLine("invalid response");
        }
    }
}




// methods

static bool VowelStart(string input)
{
    if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u')
    {
        return true;
    }
    else
    {
        return false;
    }
}


static int ConsStart(string input)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
        {
            return i;
        }
    }
    return -1;
}
