// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
// Примеры:
// ["hello", "2", "world", -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []
// https://viewer.diagrams.net/?tags=%7B%7D&highlight=0000ff&edit=_blank&layers=1&nav=1&title=FJ%20%D0%B1%D0%BB%D0%BE%D0%BA%20%D1%81%D1%85%D0%B5%D0%BC%D0%B0.drawio#R7Rvbkps29Gs80z6sB8TF%2BNHXbdLNNu3m0s1LRzZamwYjB3DW7tdXQkJICBvwpXG2mdnRosPRkXTuR8Ida7Ta3sZwvXyDfRR2gOFvO9a4A4DneqSlgB0DmK5jMsgiDnwOKwAPwT%2BIAw0O3QQ%2BShTEFOMwDdYqcI6jCM1TBQbjGD%2BraE84VGddwwXSAA9zGOrQj4GfLvm%2BQK%2BA%2F4KCxTKf2XT77M0K5sh8J8kS%2BvhZAlmTjjWKMU7Z02o7QiFlXs6Xj692H8O7z%2B7t69%2BTL%2FD98Nd39x9uGLFpmyFiCzGK0qNJb8Ld69H2y1%2BvsGW96f326dPYn%2FAhxlcYbji%2FOsANySTDWUyeFvSpDWRNJRnChAnN%2FbKhzBmaxaNGogxI1jCizE53XIL5yCccpTdJpl8Dr%2Bus0wqiY6PT79F2aGStnT%2BbHS%2BHW4MOFR%2BbjbCLTagugoBnCtGxRHSatV5G1JQmAFk7qmAOH0XeMgqTrLUkCGtHeUvgVgeM6EIpZJCPYrOIZ0OafZoje1nbU7uMspNhsrH9HMJWImiaKrWRNIUpbZmRBfwtkBGAttNBjmBrix9JzDT4xoulgqbLqNj74fUI3rIlDaXhuayr5XhAFqQdZq2jLtvJyWbqQVuPwzmaPLvJafItyOoB1OUZlrTPkqSBtFtG3ejy2fpTicGGhi00XTIZToUtX2yF0e23FNFImsuVZpzkCEBqHVWMGTWx50PyGWps8zRLtRS5FRqxTxqZZlX7FmH6RklE2voNadJ8j8XGBVenmvzGqioJoxGWKi9eNmhDQgaypGSFkPAUxXMUdVXmFsjS4ipEIpOSzUe3DsZTzQNUOKUSd4Re9iS4zO5cPBWkBiop0YrVEmRXYbfstRSlESrVq7LxiaJPzHJktS7WNpK8mbCigTTLRDJOT9GkCkOV1beZM5c22JUC4rpdPgCUIA5ivIl8RFMREoGHz8sgRQ9rOKdvn0niSWDLdBWSnilG1%2BY7PC%2F6iuIUbaVsj%2Bc%2FtwivUBrvCAp%2F2%2BPpDs9lb%2Fq8%2F1wkho7NYUs5KbQ4EPJkdCFIFwkXeeA5V4v8y3Q0TiGf5K%2B8i%2BN0iRc4guGkgA5VXhY4dxivOQf%2FRmm648k43KRY5S%2FaBumfdHjX4b1H6c14yylnnV3eich%2BpUG0%2Byi%2FK4ZlvXwcTdumcBWEFPABxT6MIAfz9Zl2a5EneBPP0QG%2BWrzSgPECpQfwbIZHeX5QgWIUwjT4qtYU59cGT0vHH0ntVKUhd3BGCjVFqjAMFhF5nhMWopgAqGEEpBIa8BerwPeZAiGSR8NZRo%2FKaI2DKM024ww7zrhCPHukqEvtoJZrlirKPr4YpbKqsuAbo2s5tsvGNhYKJ%2FeWblNCwU9PCdGOstTErCcIsq8J8h5%2FS0s3JTsvrL7O0hU7L8z%2Bu7T03lVZurW37t5b%2F8pPRgijhfJ2cn%2Fz%2FmF%2FmU2FUFtVEwTTXm%2FLcz3BuToml602GzOvgKYbFN%2BoqqGAC1c03EezhP4LWDHOYDzVoOc%2BcGd271C0IHG5CY1h9idyFbbdunRFK%2F7LOcsSr2abpD5fUTT%2FXbCiPtu4R8%2Bk%2FQOvyAynWkHzFMcEVrfnKGmO7ehpjtkHXaci0eldLNFxG4e2Hy7xRJdoN3SJzlW5RLN3ZTHT%2BN8riHVuBcmGDqh3lxB49qnnablLM9WyzQOlg%2B4afMdySsrJVnDWjM9%2BkQGdBWJSFQSkLBDxuByws1hv1YTfFxlsLVXTenZFpPWqDhTcS8VZZ68etr6a4SrWXFtKGt9UpTMlA0TJ5sRzp7T%2BLOV3NZc1ew1sBuefF1k4uJnjEMfMIoIoSAMYloyCk8xUWdH6%2BpuiPdqunZdpgHMu%2FASZlXhtHA1i8muSi%2B9nZj3XVKRTjhmvyJNY%2FZIn8XRPIi6iZU%2FiXSxht79p7vViTybdb5V7naQNevUmh5Wa3OaYqHPhxOYCLjhJ44AEPHaCKoLIYYdXeSbRIp6clfOHv7x44pZC2SAfADdhA6hhw3cr8xZnSy9EvKzS4pHeyDxpm5heiijJEq7pI%2FGuMAxRiBcxXNG9o5iE4%2BwWQ333tnhRG92DLcq%2FR7uyaG8Ct%2Bt5SsAXd5NK6eB2QdUpnXGpoA%2Bqyof%2FPgtoGJmrkwWj69nu4YSBdCRFymBnjvK9hlG%2Bf1VRXj%2BBq3Ueij868hCjiQs%2FKjiw2d6SgJRmRz4%2FsWj0c9vqZI%2FX8vF8s8r0pc4XzZhF3M2usPSwLXEVkF8YeAIieyOn6iDDcC6ki%2FoN6tE17pSE8GS5V%2Bhl%2FxaGwTpBDQJMexlqV%2FSXE6oqUhdUhBe7Irb0L1ZPWj%2FqyUvUkyZoGGrcqwo1%2BbL32%2FeFq4EHwrD0GnzCxZJMRz1SElmj4gIqfPrFXACouiQpczryB%2FRXH9RJ0uommKsMVj3CSYniYS9wZjNtetcqf4pYIZscduynT1w3nNIVmbi4yEmw%2FfBRh%2B7agErIKX8pydySRqjtHaBjqPP0a%2B4AvZPQ849Am6JbCnrbC0bSLX5ExNCLn2JZk38B

string[] array1 = new string[5] {"TOMI", "ANN", "MARYA", "JOJIT", "PB"};
string[] array2 = new string[array1.Length];
void  FillArrayNumbers(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArrayNumbers(array1, array2);
PrintArray(array2);
