// 74. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
//Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита
string text = "аисв";
int n = 1;
void AllWords(string text, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i < text.Length; i++)
    {
        word[length] = text[i];
        AllWords(text, word, length + 1);
    }

}
AllWords("аисв", new char[2]);