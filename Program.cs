Console.Write("Введите строку:");
string text = Console.ReadLine();

char[] mas = text.ToCharArray();

int k1 = 0;
int k2 = 0;

for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] == '(' | mas[i] == ')') k1++;
    if (mas[i] == '[' | mas[i] == ']') k2++;
}

Console.WriteLine("Круглых скобок: " + k1);
Console.WriteLine("Квадратных скобок: " + k2);
