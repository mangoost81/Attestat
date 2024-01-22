

string[] words = {"Hey", "NewYear", "Best", "Battery", "Car", "System", "HardRock"};


void  FindLenght(string[] massiv )

{
    int lenght = massiv.Length;

    for(int i = 0; i < lenght; i++)
    {
        if(massiv[i].Length > 3)
            {
            System.Console.WriteLine(massiv[i]);
            }

    }
}
FindLenght(words);

// int lenght = words.Length;


