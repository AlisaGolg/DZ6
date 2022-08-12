/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array=new int [n];
int count=0;
for (int i=0; i<n; i++)
{
    array[i]=new Random().Next(-99, 101);
    if (array[i]>=0)
    count++;
}    
Console.WriteLine("("+string.Join(", ", array)+ ")");
Console.Write("Кол-во чисел больше 0: ");
Console.Write(count);

