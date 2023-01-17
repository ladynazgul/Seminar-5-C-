// Написать программу масштабирования фигуры. Способ решения, который показал препод

int CountBlanks(string str) // Метод для подсчета пробелов в строке
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
        if (str[i] == ' ')
            count++;
    return count;
}

var str = Console.ReadLine() ?? "0";
int blanks = CountBlanks(str);

var strings = new string[blanks + 1];
int stringNumber = 0;
for (int i = 0; i < str.Length; i++)
{
    string point = "";
    while(str[i] != ' ')
        point += str[i];

}


