using System.Xml.XPath;

string name = Console.ReadLine();

int result = 0;
int value = 0;
string letter = "";

for (int i = 0; i < name.Length; i++)
{
    char sliced = name[i];
    switch (sliced)
    {
        case 'a':
            value = 1;
            result += value;
            break;
        case 'e':
            value = 2;
            result += value;
            break;
        case 'i':
            value = 3;
            result += value;
            break;
        case 'o':
            value = 4;
            result += value;
            break;
        case 'u':
            value = 5;
            result += value;
            break;
    }
}

Console.WriteLine(result);