/* Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
 */  
    
Console.WriteLine("Введите текст, состоящий из любого количества любых символов"); 
string text = Console.ReadLine(); 
string [] words = text.Split(' '); 
string [] resultArray = new string[words.Length];       

void ConditionArray(string[] words, string[] resultArray) 
{
    int i = 0;
    foreach (var result in words)  
    {
        if (result.Length <= 3)
        {
            resultArray[i] = result;     
            i++;
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

ConditionArray(words, resultArray);
PrintArray(resultArray);     
      
