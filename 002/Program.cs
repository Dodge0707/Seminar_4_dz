// 1. Решил математическим методом:

/*Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int x = 0;
int result = 0;
while (number >= 1)
{
    x = number%10;
    result = result + x;
    number = number/10;
}
Console.WriteLine(result); */
// 2. Так же решил интовым методом, но с использованием функции


/*int numberA = InputNumber("x");
int otvet = Summa(numberA);
Console.WriteLine(otvet);

int InputNumber(string number)
{
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
return x;
}

int Summa(int number)
{
    int x = 0;
    int result = 0;
while (number >= 1)
{
    x = number%10;
    result = result + x;
    number = number/10;
}
return result;
} */

// 3.  Вот сделал через строку. 

string x = InputNumber("x");
int length = x.Length;
int result = 0;
for(int index = 0; index < length; index++)
{
    result += Convert.ToInt32(x[index]);
}

Console.WriteLine(result);

string InputNumber(string number)
{
Console.WriteLine("Введите число: ");
string x = Console.ReadLine();
return x;
}

