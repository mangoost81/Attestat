

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
// System.Console.WriteLine(words.Count());
// System.Console.WriteLine(words[0].Length);

// int lenght = words.Length;

//     for(int i = 0; i < lenght; i++)
//     {
//         if(words[i].Count() > 3)
//             {
//             System.Console.WriteLine(words[i]);
//             }

//     }