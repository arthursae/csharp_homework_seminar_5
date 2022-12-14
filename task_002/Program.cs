// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

const int min = -100, max = 100; // Set the MIN and MAX range for PRG-numbers

void OutputTheResultOfCalculation(int[] numbersArray, int sum)
{

    Console.Write("Cумма элементов, стоящих на нечётных позициях в массиве ");
    Console.WriteLine("[{0}]", string.Join(", ", numbersArray));
    Console.Write(" -> " + sum);
    Console.WriteLine(); // removes percent sign from console output

}

int CalculateSumOfAllNumbersInOddIndices(int[] numbers)
{

    int sum = 0;

    for (int i = 1; i < numbers.Length; i += 2)
    {

        sum += numbers[i];

    }

    return sum;

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

        int prgn = new Random().Next(min, max);
        numbers[i] = prgn;

    }

    return numbers;

}

bool IsValidNumber(string strToCheck)
{

    int x = 0;

    if (Int32.TryParse(strToCheck, out x))
    {

        return true;

    }

    return false;

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
int sum = CalculateSumOfAllNumbersInOddIndices(numbersArray);
OutputTheResultOfCalculation(numbersArray, sum);
