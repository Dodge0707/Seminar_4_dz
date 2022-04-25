Console.WriteLine("Введите значения массива через запятую");

string array = Console.ReadLine();

int index = 0;
while(index<array.Length)
{
    Console.Write( array[index]+ " ");
    index+=2 ;
}