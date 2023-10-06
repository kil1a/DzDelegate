int Sum(int a, int b)
{
    return a + b;
}
void PrintUpperCase(string str)
{
    Console.WriteLine(str.ToUpper());
}
List<int> GetEvenNumbers(List<int> numbers)
{
    return numbers.Where(n => n % 2 == 0).ToList();
}
int TotalStringLength(List<string> strings)
{
    return strings.Sum(str => str.Length);
}
double CalculateAverage(List<int> numbers)
{
    return numbers.Average();
}
List<string> ModifyStrings(List<string> strings)
{
    return strings.Select(str => str.First().ToString().ToUpper() + str.Substring(1).ToLower()).ToList();
}
List<string> GetUppercaseWords(List<string> words)
{
    return words.Where(word => word.All(c => char.IsUpper(c))).ToList();
}

int result = Sum(3, 4);
Console.WriteLine(result);

//--------------------------------------------------------------

PrintUpperCase("hello");

//--------------------------------------------------------------

List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6 };
List<int> evenNumbers = GetEvenNumbers(numbers1);
foreach (int number in evenNumbers)
{
    Console.WriteLine(number);
}

//--------------------------------------------------------------

List<string> strings1 = new List<string> { "hello", "im sir", "!" };
int totalLength = TotalStringLength(strings1);
Console.WriteLine(totalLength);

//--------------------------------------------------------------

List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5 };
double average = CalculateAverage(numbers2);
Console.WriteLine(average);

//--------------------------------------------------------------

List<string> strings2 = new List<string> { "hELlo", "Im SiR", "!" };
List<string> modifiedStrings = ModifyStrings(strings2);
foreach (string str in modifiedStrings)
{
    Console.WriteLine(str);
}

//--------------------------------------------------------------

List<string> words = new List<string> { "STHSFG", "SGH", "12344" };
List<string> uppercaseWords = GetUppercaseWords(words);
foreach (string word in uppercaseWords)
{
    Console.WriteLine(word);
}