// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void ArraySelection(string[] incomingArray)
{
    var result = new string[incomingArray.Length];
    int count = 0;
    foreach (var value in incomingArray)
    {
        if (value.Length <= 3)
        {
            result[count] = value;
            count++;
        }
    }
    Console.Write(string.Join(Environment.NewLine, result));
}

Console.Write("Введите массив строк через пробел: ");
string line = Console.ReadLine();
string[] TextArray = line.Split(' ');
ArraySelection(TextArray);