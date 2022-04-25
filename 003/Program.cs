/*Console.WriteLine("Введите значения массива через запятую");

string array = Console.ReadLine();

int index = 0;
while(index<array.Length)
{
    Console.Write( array[index]+ " ");
    index+=2 ;
}*/

int[] numbers = new int[8];
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}