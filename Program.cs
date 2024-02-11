string [] CreateTextArray()  //This method create the array that I fill yourself. 
{
    Console.WriteLine("Input the number of elements");
    int numberOfElements = Convert.ToInt32(Console.ReadLine());
    string[] innerTextArray = new string[numberOfElements];
    int i = 0;
    while (i < numberOfElements)
    {
        Console.WriteLine($"Input the value of the {i + 1} element:");
        innerTextArray[i] = Console.ReadLine();
        i++;
    }
    return innerTextArray;
}
void PrintArray(string [] textArray)
{
    Console.Write("[" + string.Join(", ", textArray) + "]");  //Here I used Join method oupting value with 
}                                                                 //separator.

string [] FillFromTextArray(string [] array)
{

    var random  = new Random();
    int randomNumbersOfIndexes = Convert.ToInt32(random.Next(4));
    string[] innerArray = new string[randomNumbersOfIndexes];
    for (int i = 0; i < randomNumbersOfIndexes; i++)
    {
        string randomValueFromArray = array[Convert.ToInt32(random.Next(array.Length))];  
        if (innerArray.Contains(array[random.Next(array.Length)]))
        {
            i--;    
        }
        
        else { innerArray[i] = randomValueFromArray; }
    }
    return innerArray;
}

string [] array = CreateTextArray();

PrintArray(array);
Console.Write("-->");
string [] filledArray = FillFromTextArray(array);
PrintArray(filledArray);


