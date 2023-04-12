// Написать программу масштабирования фигуры. Способ решения, который показал препод

int CountBlanks(string str) // Метод для подсчета пробелов в строке
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
        if (str[i] == ' ')
            count++;
    return count;
}

int[] ParseInts(string str)
{
    int[] coordinates = new int[2];
    string first = " ";
    int i = 0;
    while (str[i] != ',')
    {
        first += str[i];
        i++;
    }
    coordinates[0] = int.Parse(first);
    i++;
    string second = "";
    for (; i < str.Length; i++) // переменная i уже объявлена, поэтому в данной строке ее еще раз не пишем
        second += str[i];
    coordinates[1] = int.Parse(second);
    return coordinates;
}

var str = Console.ReadLine() ?? "0";
int blanks = CountBlanks(str);

var strings = new string[blanks + 1];
int stringNumber = 0;
for (int i = 0; i < str.Length; i++)
{
    string point = "";
    while (i < str.Length && str[i] != ' ')
    {
        if(str[i] == '(' || str[i] == ')')
        {
            i++;
            continue;
        }   
        point += str[i];
        i++;
    }
        
    strings[stringNumber] = point; 
    stringNumber++;
}

for (int i = 0; i < strings.Length; i++)
{
    int[] coordinates = ParseInts(strings[i]);
    Console.WriteLine($"{coordinates[0]} {coordinates[1]}");
}

// Задание не доделано, потом может, допишу. Хотя я так и не поняла, зачем парсить эти координаты, в решении с гитхаба было сделано проще.


