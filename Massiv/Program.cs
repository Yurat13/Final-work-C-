
void FindWords (string[] words, int length)
{
    
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= length) Console.Write ($"{words[i]} ");
    }
}

string[] array = {"priv", "kak", "de"};
FindWords(array, 3);
