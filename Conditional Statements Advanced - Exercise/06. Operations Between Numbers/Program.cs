int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
char operators = char.Parse(Console.ReadLine());

double result = 0;
string eOrO = "";

if(num2 == 0)
{
    Console.WriteLine($"Cannot divide {num1} by zero");
}
else
{
    if (operators == '+')
    {
        result = num1 + num2;
    }
    else if (operators == '-')
    {
        result = num1 - num2;
    }
    else if (operators == '*')
    {
        result = num1 * num2;
    }
    else if (operators == '/')
    {
        result = (double)num1 / num2;
    }
    else if (operators == '%')
    {
        result = num1 % num2;
    }

    bool isEven = result % 2 == 0;

    switch (operators)
    {
        case '+':
        case '-':
        case '*':
            switch (isEven)
            {
                case true:
                    eOrO = "even";
                    break;
                case false:
                    eOrO = "odd";
                    break;
            }
            Console.WriteLine($"{num1} {operators} {num2} = {result} - {eOrO}");
            break;
        case '/':
            Console.WriteLine($"{num1} {operators} {num2} = {result:f2}");
            break;
        case '%':
            Console.WriteLine($"{num1} {operators} {num2} = {result}");
            break;
    }
}