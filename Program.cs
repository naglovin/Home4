////  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)2, 4 -> 16
int Rich(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int worker = Rich(numberA, numberB);
  Console.WriteLine("Ответ: " + worker);

  // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11 82 -> 10 9012 -> 12
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int number)
  {
    
    int counter = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 6, 1, 33 -> [6, 1, 33]
int[] ArrayCreation(int Len)
{
int[] arr = new int [Len];
for(int i = 0; i < Len; i++)
{
    arr[i] = new Random(). Next(0, 100);
}
return arr;
}
void PrintArray (int[] arr)
{
    int Len = arr.Length;
    for(int i = 0; i < Len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
PrintArray(ArrayCreation(8));
Console.WriteLine("цифры вашего массива");
