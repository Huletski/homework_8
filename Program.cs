//task 1 Найти произведение двух матриц

/*
Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] matrixOne = new int[m, n];
CreateArray(matrixOne);
Console.WriteLine($"Первая матрица:");
WriteArray(matrixOne);

int[,] matrixSecond = new int[n, p];
CreateArray(matrixSecond);
Console.WriteLine($"Вторая матрица:");
WriteArray(matrixSecond);

int[,] resultOfMatrix = new int[m,p];

MultiplyMatrix(matrixOne, matrixSecond, resultOfMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultOfMatrix);

void MultiplyMatrix(int[,] matrixOne, int[,] matrixSecond, int[,] resultOfMatrix)
{
  for (int i = 0; i < resultOfMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultOfMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrixOne.GetLength(1); k++)
      {
        sum += matrixOne[i,k] * matrixSecond[k,j];
      }
      resultOfMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
 
 */





 //task 2 В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


/*


Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int[,] positionSmallElement = new int[1, 2];
positionSmallElement = FindPositionSmallElement(array, positionSmallElement);
Console.Write($"Позиция элемента: \n");
WriteArray(positionSmallElement);

int[,] arrayWithoutLines = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
DeleteLines(array, positionSmallElement, arrayWithoutLines);
Console.WriteLine($"\nПолучившийся массив:");
WriteArray(arrayWithoutLines);


int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int[,] FindPositionSmallElement(int[,] array, int[,] position)
{
  int temp = array[0, 0];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] <= temp)
      {
        position[0, 0] = i;
        position[0, 1] = j;
        temp = array[i, j];
      }
    }
  }
  Console.WriteLine($"\nMинимальный элемент: {temp}");
  return position;
}

void DeleteLines(int[,] array, int[,] positionSmallElement, int[,] arrayWithoutLines)
{
  int k = 0, l = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (positionSmallElement[0, 0] != i && positionSmallElement[0, 1] != j)
      {
        arrayWithoutLines[k, l] = array[i, j];
        l++;
      }
    }
    l = 0;
    if (positionSmallElement[0, 0] != i)
    {
      k++;
    }
  }
}
 
 */


 
 
 
 // Task 3 Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
 
 /*

 int[,,] CreateArr()
{
    int[,,] array = new int[2, 2, 2];
    int[] randomNumbers = NoRepeatNumbers(array.GetLength(0) * array.GetLength(1) * array.GetLength(2));

    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = randomNumbers[count];
                count++;
            }
        }
    }

    return array;
}

int[] NoRepeatNumbers(int length)
{
    Random random = new Random();
    int[] randNumbrs = new int[length];
    int randomNumber = 0;
    bool flag = false;
   
    for (int i = 0; i < randNumbrs.Length; i++)
    {
        randomNumber = random.Next(10, 100);

        for (int j = 0; j < randNumbrs.Length; j++)
        {
            if (randomNumber == randNumbrs[j] || flag) flag = true;
        }
        if (!flag) randNumbrs[i] = randomNumber;
        else i--;
        flag = false;
    }

    return randNumbrs;
}

void OutputArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
OutputArray(CreateArr());
 
 */
 







 //task 4 Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника       


/*

Console.Clear();
            
System.Console.Write("введите количество рядов в треугольнике Паскаля: ");
            
string input = System.Console.ReadLine();
 
        
int n = Convert.ToInt32(input);
 
 
for (int y = 0; y < n; y++)
{
 int c = 1;

for (int q = 0; q < n - y; q++)
{
System.Console.Write("   ");
}
 
for (int x = 0; x <= y; x++)
{
 System.Console.Write("   {0:D} ", c);
 c = c * (y - x) / (x + 1);
}

System.Console.WriteLine();
System.Console.WriteLine();
}
System.Console.WriteLine();
  

*/ 