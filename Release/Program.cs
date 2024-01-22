

string[] words = {"Hey", "NewYear", "Best", "Battery", "Car", "System", "HardRock"};
string[] wordsforfhree = new string[words.Length];



void  FindLenght(string[] massiv_1, string[] massiv_2)

{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length <= 3)
        {
            wordsforfhree[count] = words[i];
            count++;
        }
    }
    
}
FindLenght(words, wordsforfhree);

Console.WriteLine(string.Join(" ", wordsforfhree));



