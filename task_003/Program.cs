// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

const double min = -100.0; // Set the MIN of real (double) numbers range
const double max = 100.0; // Set the MAX of real (double) numbers range
const int roundTo = 4; // Set number of fractional digits for better to read result output

void OutputTheResultOfSubtraction(double[] numbersArray, int roundTo)
{
    int length = numbersArray.Length;
    double[] numbersArrayRounded = new double[length];
    double min = numbersArray[0];
    double max = numbersArray[0];

    for (int i = 0; i < length; i++)
    {
        
        if (numbersArray[i] < min)
        {

            min = numbersArray[i];

        }

        else if (numbersArray[i] > max)
        {

            max = numbersArray[i];

        }



    }

    double diff = max - min;
    double diffRounded = Math.Round(diff, roundTo);

    for (int i = 0; i < length; i++)
    {

        numbersArrayRounded[i] = Math.Round(numbersArray[i], roundTo);

    }

    Console.WriteLine("[{0}]", string.Join(", ", numbersArrayRounded));
    Console.WriteLine("Разница между максимальным " + Math.Round(max, roundTo) + " и минимальным " + Math.Round(min, roundTo) + " равна = " + diffRounded);
    Console.WriteLine(); // removes percent sign from console output

}

string GetUserInputData(string msg)
{

    Console.Write(msg);
    string userInput = Console.ReadLine();
    return userInput;

}

double GetPseudoRandomlyGeneratedRealNumber(double min, double max)
{

    double prgnNumber = new Random().NextDouble() * (max - min) + min;
    return prgnNumber;

}

double[] BuildArrayOfPRGNs(int numOfElements)
{

    double[] numbers = new double[numOfElements];

    for (int i = 0; i < numOfElements; i++)
    {

        double prgn = GetPseudoRandomlyGeneratedRealNumber(min, max);
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

int GetNumberOfElementsInArray(string msg)
{

    string userInput = GetUserInputData(msg);

    if (IsValidNumber(userInput))
    {
        
        int numOfElements = Math.Abs(Convert.ToInt32(userInput));
        return numOfElements > 1 ? numOfElements : GetNumberOfElementsInArray(msg);
    
    } 

    else
    {

        return GetNumberOfElementsInArray(msg);

    }

}

Console.Clear();

int numOfElements = GetNumberOfElementsInArray("Введите количество элементов в массиве: ");
double[] numbersArray = BuildArrayOfPRGNs(numOfElements);
OutputTheResultOfSubtraction(numbersArray, roundTo);
