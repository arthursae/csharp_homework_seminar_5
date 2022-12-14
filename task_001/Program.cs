// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

const int min = 100, max = 999; // three digits number range

void OutputTheCounter(int[] numbersArray, int counter)
{

    Console.Write("Количество чётных чисел в массиве ");
    Console.WriteLine("[{0}]", string.Join(", ", numbersArray));
    Console.Write(" -> " + counter);
    Console.WriteLine(); // removes the percent sign from your terminal output

}

int CountNumberOfEvenNumbersInArray(int[] numbers)
{
    int counter = 0;

    foreach (int num in numbers) 
    {

        if (num % 2 == 0) counter++;

    }

    return counter;

}

string GetUserInputData(string msg)
{

    Console.Write(msg);
    string userInput = Console.ReadLine();
    return userInput;

}

int[] BuildArrayOfPRGNs(int numOfElements)
{

    int[] numbers = new int[numOfElements];

    for (int i = 0; i < numOfElements; i++)
    {

        int prgn = new Random().Next(min, max + 1);
        numbers[i] = prgn;

    }

    return numbers;

}

bool IsValidNumber(string strToCheck)
{

    int x = 0;
    return Int32.TryParse(strToCheck, out x);

}

int GetNumberOfElementsInArray(string message)
{

    string userInput = GetUserInputData(message);

    if (IsValidNumber(userInput))
    {
        
        int numOfElements = Math.Abs(Convert.ToInt32(userInput));
        return numOfElements > 0 ? numOfElements : GetNumberOfElementsInArray(message);
    
    } 

    else
    {

        return GetNumberOfElementsInArray(message);

    }

}

Console.Clear();

int numOfElements = GetNumberOfElementsInArray("Введите количество элементов в массиве: ");
int[] numbersArray = BuildArrayOfPRGNs(numOfElements);
int counter = CountNumberOfEvenNumbersInArray(numbersArray);
OutputTheCounter(numbersArray, counter);
