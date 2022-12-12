/*Задача: 
Написать программу, которая из имеющегося массива строк
 формирует новый массив из строк, 
 длина которых меньше, либо равна 3 символам.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

void MethodArray (string [] array)
{
     string[] newarr = new string[array.Length];
    
     for (int i=0; i<array.Length; i++)
        {      
            if(array[i].Length<=3)
            {
                newarr[i]=array[i]+",";
                Console.Write(newarr[i]); 
            }
        } 
}
        

string [] arr = {"1234", "156", "-2", "computer science"};

MethodArray(arr);



