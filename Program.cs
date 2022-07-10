/* Zadacha 27 
int Summa( int number)
{
int sum = 0;
int N = 0;
int number1 = number;
while (number1>0)
{
    number1 = number1 / 10;
    N++;
}
while (number>0)
{
    int a = 0;
    a = number % 10;
    number = number / 10;
    sum = sum + a;
}
    return sum;
}
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Summa(a);
Console.WriteLine("Сумма цифр числа = " + result);
*/
/* Zadacha 29 
void Massiv()
{
    int N = 8;
    int[] array = new int[N];
    Random rand = new Random();
    Console.WriteLine("Массив чисел: ");
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next();
        Console.Write(" " + array[i]);
    }
} 
Massiv(); */