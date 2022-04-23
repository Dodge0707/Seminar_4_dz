Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = Stepen(a, b);
Console.WriteLine(result);


int Stepen(int x, int y)
{
      int vixod = 1;
    for (int i = 1; i <= y; i++)
    {
        
        vixod = vixod * x;
    }
    return vixod;
}


