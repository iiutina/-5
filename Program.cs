/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int [] FillArray (int size_array, int minval, int maxval)
{
    int [] array= new int[size_array];
    for (int i=0;i< size_array; i++)
       {
        array[i]= new Random().Next (minval,maxval+1);
       }
       return array;
      
}

void PrintArray (int [] array01)
{
    for (int i=0; i < array01.Length; i++)
         Console.Write (array01[i] + " ");
}

int DigitArray(int [] array01)
{
    int count = 0;
    for (int i=0; i < array01.Length; i++)
    {
      if (array01[i] %2==0)
      {
          count= count+ 1;
      }
    }
    return count;
}    

 int sizeArray=5;
 int minValue=100; 
 int maxValue=999;


int [] array02 = FillArray (sizeArray,minValue, maxValue);
PrintArray (array02);
int array03 = DigitArray(array02);

 
Console.WriteLine ($" even number {array03} ");
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*int [] NewArray (int size_array)
{
    int [] array= new int[size_array];
    for (int i=0;i< size_array; i++)
       {
        array[i]= new Random().Next (-7,6);
       }
       return array;
      
}

void PrintArray (int [] array01)
{
    for (int i=0; i < array01.Length; i++)
         Console.Write (array01[i] + " ");
}

int DigitArray(int [] array01)
{
    int sum = 0;
    for (int i=0; i < array01.Length; i++)
    {
      if (i %2!=0)
      {
          sum= sum+ array01[i];
      }
    }
    return sum;
}    
int [] array02 = NewArray (6);
PrintArray (array02);
int array03 = DigitArray(array02);

Console.WriteLine ($" summa of elements on odd position {array03} ");

*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. Math.Min Math.Max не использовать
[3.0 7.1 22.5 2.7 78.8] -> 76.1
*/

/*System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");// нашла вариант преобразования с "," на "." 
double [] NewArray (int size_array)
{
    double [] array= new double  [size_array];
    for (int i=0;i< size_array; i++)
       {
        array[i]=(Math.Round((new Random().NextDouble()*100-50),1));
       
       }
       return array;
      
}

void PrintArray (double [] array01)
{
    for (int i=0; i < array01.Length; i++)
         Console.Write (array01[i] + " ");
}

double DigitArray(double [] array01)
{
    double max = array01[0];
    double min = array01[0];
    double res = 0;
    for (int i=0; i < array01.Length; i++)
    {
        if (array01[i] < min )
            {
             min=array01[i];
            }
            else if (array01[i]> max)
            {
                max=array01[i];
            }
            
    }  
    if (min<0)
    {
        min=min*(-1);
    } 
    res= max-min;
   res = Math.Round(res,(1));
    return res;                    

}
double [] array02 = NewArray (6);
PrintArray (array02);
double array03 = DigitArray(array02);

Console.WriteLine ($"number {array03}");
*/

// Задачи на Семинаре 5
//для себя оставила задачу с int 
/*int [] NewArray (int size_array)
{
    int [] array= new int[size_array];
    for (int i=0;i< size_array; i++)
       {
        array[i]= new Random().Next ( );
       }
       return array;
      
}

void PrintArray (int [] array01)
{
    for (int i=0; i < array01.Length; i++)
         Console.Write (array01[i] + " ");
}

int DigitArray(int [] array01)
{
    int max = array01[0];
    int min = array01[0];
    int res = 0;
    for (int i=0; i < array01.Length; i++)
    {
        if (array01[i] < min )
            {
             min=array01[i];
            }
            else if (array01[i]> max)
            {
                max=array01[i];
            }
            
    }  
    if (min<0)
    {
        min=min*(-1);
    } 
    res= max-min;
    return res;                    

}
*/        



/*int [] array02 = NewArray (6);// количество элементов
PrintArray (array02);
int array03 = DigitArray(array02);

Console.WriteLine ($"  number {array03} ");
*/