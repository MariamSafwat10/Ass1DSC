namespace Ass1DSC
{
    internal class Program
    {
        #region Q1
        //public static void sum(int a , int b)
        //{
        //    Console.WriteLine("Sum = "+(a+b));
        //}
        #endregion

        #region Q2
        //public static void print(int limit)
        //{
        //    for(int i = 1; i <= limit; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region Q3
        //public static void swap(ref int a , ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        #endregion

        #region Q4
        //public static void min_max(int [] arr)
        //{
        //    int min = arr[0];
        //    int  max = arr[0];
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        else if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //    Console.WriteLine("Max -> "+max +"\nMin -> "+min);
        //}
        #endregion
        #region Q5
        //public static void isPrime(int a)
        //{
        //    int count = 0;
        //    for (int i = 1; i <= a; i++)
        //    {
        //        if(a % i == 0)
        //        {
        //            count++;
        //        }
        //    }
        //    if (count == 2)
        //    {
        //        Console.WriteLine("Prime");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Not Prime");
        //    }
        //}
        #endregion
        #region Q6
        //public static int fac(int a)
        //{
        //    int fac = 1;
        //    for(int i = 1; i <= a; i++)
        //    {
        //        fac *= i;
        //    }
        //    return fac;
        //}
        #endregion
        #region Q7
        //public static void sumIndi(int n)
        //{
        //    int sum = 0;
        //    while(n != 0)
        //    {
        //        sum += n % 10;
        //        n /= 10;
        //    }
        //    Console.WriteLine("Sum of individual digits = "+sum);
        //}
        #endregion
        #region Q8
        //public static void palindrome(string num)
        //{
        //     int r = num.Length - 1;
        //     int l = 0;
        //     while(l < r)
        //     {
        //         if (num[l] != num[r])
        //         {
        //             Console.WriteLine("Not palindrome ");
        //             return;
        //         }
        //         l++;
        //         r--;
        //     }
        //     Console.WriteLine("Palindrome");
        //}
        #endregion
        #region Q9
        //public static void shiftingZerosRight(int[] arr, int n)
        //{
        //    List<int> zeros = new List<int>();
        //    List<int> nonZeros = new List<int>();
        //    int count = 0;
        //    for (int i = 0; i < n; i++)
        //    {
        //        if (arr[i] != 0)
        //            nonZeros.Add(arr[i]);
        //        else
        //           zeros.Add(arr[i]);
        //    }
        //    nonZeros.AddRange(zeros);

        //    foreach (int x in nonZeros)
        //        Console.Write(x);
        //}

        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    string [] input = Console.ReadLine().Split();
        //    int[] arr = new int[n];
        //    for (int i = 0; i < n; i++)
        //    {
        //        arr[i] = int.Parse(input[i]);
        //    }
        //    shiftingZerosRight(arr, n);
        //}
        #endregion
        #region Q10
        //public static void swap(int[,]arr ,int n , int x , int y)
        //{
        //    x--;
        //    y--;

        //    for(int i = 0; i < n; i++)
        //    {
        //        int temp = arr[x,i];
        //        arr[x, i] = arr[y, i];
        //        arr[y, i] = temp;

        //    }
        //    for(int i = 0; i < n; i++)
        //    {
        //        int temp = arr[i, x];
        //        arr[i, x] = arr[i, y];
        //        arr[i, y] = temp;
        //    }

        //    for(int i = 0; i < n; i++)
        //    {
        //        for(int j = 0; j < n; j++)
        //        {
        //            Console.Write(arr[i,j]+" ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //static void Main(string[] args)
        //{

        //    string[] input = Console.ReadLine().Split();
        //    int n = int.Parse(input[0]);
        //    int x = int.Parse(input[1]);
        //    int y = int.Parse(input[2]);

        //    int[,] arr = new int[n,n];
        //    for(int i = 0; i < n; i++)
        //    {
        //        string [] elements = Console.ReadLine().Split();
        //        for(int j = 0; j < n; j++)
        //        {
        //            arr [i,j] = int.Parse(elements[j]);
        //        }
        //    }
        //    swap(arr , n , x , y);

        //}
        //#endregion
        //#region Q12
        //public static void harryPoter(int n)
        //{
        //    if ((n%10)%2 == 0)
        //    {
        //        Console.WriteLine("AvadaKedavra");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Expectopatronum");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    int n = int.Parse(Console.ReadLine());
        //    harryPoter(n);
        //}
        #endregion 
    }
}
