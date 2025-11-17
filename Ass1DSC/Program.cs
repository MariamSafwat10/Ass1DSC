






#region Q1
//Console.WriteLine("Enter radius :");
//double r;
//r = double.Parse(Console.ReadLine());
//const double pi = 3.141592653;
//double area = pi * r * r;
//Console.WriteLine("Area = {0:F9}",area);
#endregion

#region Q2
//Console.WriteLine("Enter two numbers :");
//int n1, n2;
//n1 = int.Parse(Console.ReadLine());
//n2 = int.Parse(Console.ReadLine());
//Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
//Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
//Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
#endregion

#region Q3
//Console.WriteLine("Enter two numbers : ");
//int n1, n2; 
//n1 = int.Parse(Console.ReadLine());
//n2 = int.Parse(Console.ReadLine());
//if(n1 % n2 == 0 || n2 % n1 == 0)
//    Console.WriteLine("{0} and {1} are multiples", n1, n2);
//else
//    Console.WriteLine("{0} and {1} are not multiples", n1, n2);
#endregion

#region
//Console.WriteLine("Enter three numbers : ");
//int n1, n2, n3, max, min;
//n1 = int.Parse(Console.ReadLine());
//n2 = int.Parse(Console.ReadLine());
//n3 = int.Parse(Console.ReadLine());

//if(n1 >= n2 && n1 >= n3)
//{
//    max = n2;
//}
//if(n2 >= n1 && n2 >= n3)
//{
//    max = n2;
//}
//else
//{
//    max = n3;
//}
//if (n1 <= n2 && n1 <= n3)
//{
//    min = n1;
//}
//else if (n2 <= n1 && n2 <= n3)
//{
//    min = n2;
//}
//else
//{
//    min = n3;
//}
//Console.WriteLine("{0} {1}",min,max);
#endregion

#region Q5
//Console.WriteLine("Input : ");
//char c = char.Parse(Console.ReadLine());
//int ascii = (int)c;
//if (ascii>=65 && ascii <= 90)
//{
//    Console.WriteLine("Alpha \nIs capital");
//}
//else if(ascii >= 97 && ascii <= 122)
//{
//    Console.WriteLine("Alpha \nIs small");
//}
//else
//{
//    Console.WriteLine("Is digit");
//}
#endregion

#region Q6
//int a, b, c;
//char s, q;
//Console.WriteLine("Input : ");
//a = int.Parse(Console.ReadLine());
//s = char.Parse(Console.ReadLine());
//b = int.Parse(Console.ReadLine());
//q = char.Parse(Console.ReadLine());
//c = int.Parse(Console.ReadLine());
//switch (s)
//{
//    case '+':
//        if(c == a+b)
//            Console.WriteLine("Output : Yes");
//        else
//            Console.WriteLine("Output : No");
//        break;
//    case '-':
//        if (c == a - b)
//            Console.WriteLine("Output : Yes");
//        else
//            Console.WriteLine("Output : No");
//        break;
//    case '*':
//        if (c == a * b)
//            Console.WriteLine("Output : Yes");
//        else
//            Console.WriteLine("Output : No");
//        break;
//}
#endregion

#region Q7
//Console.WriteLine("Input : ");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());
//int d = int.Parse(Console.ReadLine());

//int res = a * b * c * d;
//Console.WriteLine(res);

//int num = res; 

//for (int i = 0; i < 1; i++)
//{
//    Console.Write(num % 100);
//    num /= 10;
//}

#endregion

#region Q8
//Console.WriteLine("Input : ");
//double a = int.Parse(Console.ReadLine());
//double b = int.Parse(Console.ReadLine());
//double c = int.Parse(Console.ReadLine());
//double d = int.Parse(Console.ReadLine());
//if (Math.Pow(a, b) > Math.Pow(c, d))
//{
//    Console.WriteLine("Yes");
//}
//else
//{

//    Console.WriteLine("No");

//}
#endregion

#region Q9
//Console.WriteLine("Enter number : ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine("Number = {0}",n);
#endregion

#region Q10
//string s = "ABC123";
//string digits=" ";
//foreach (char c in s)
//{
//    if (char.IsDigit(c))
//    {
//        digits += c;
//    }
//}
//int integer = int.Parse(digits);
//Console.WriteLine($"Integer numbers in string is {digits}");
#endregion

#region Q11
//Console.WriteLine("Enter string : ");
//string s = Console.ReadLine();
//int a, b;
//Console.WriteLine("Enter the beginning and length of your substring:");
//a = int.Parse(Console.ReadLine());
//b = int.Parse(Console.ReadLine());

//Console.WriteLine($"Substring = {s.Substring(a, b)} ");
#endregion

#region Q12
//Console.WriteLine("Enter first string : ");
//string s1 = Console.ReadLine();
//Console.WriteLine("Enter second string : ");
//string s2 = Console.ReadLine();
//string s3 = s1 + s2;
//Console.WriteLine($"One variable string is ({s3})");
#endregion

#region Q13
//Console.WriteLine("Enter Principal amount : ");
//double p = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter Rate of interest : ");
//double r = double.Parse(Console.ReadLine());
//Console.WriteLine("Enter Time : ");
//double t = double.Parse(Console.ReadLine());
//double sInterest = (p * r * t) / 100;
//Console.WriteLine($"Simple Interest = {sInterest}");
#endregion

#region Q14
//Console.WriteLine("Enter Temperature : ");
//double t = double.Parse(Console.ReadLine());
//string result = t < 10 ? "Iust Cold" : t > 30 ? "Just Hot" : "Just Good";
//Console.WriteLine(result);
#endregion

#region Q15
//Console.WriteLine("Input : ");
//int n = int.Parse(Console.ReadLine());
//if (n % 3 == 0 && n % 4 == 0)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}
#endregion

#region Q16
//Console.WriteLine("Input : ");
//int n = int.Parse(Console.ReadLine());
//if (n % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}
#endregion

#region Q17
//Console.WriteLine("Input : ");
//char c = char.Parse(Console.ReadLine());
//switch (c)
//{
//    case 'i':
//    case 'I':
//    case 'a':
//    case 'A':
//    case 'e':
//    case 'E':
//    case 'O':
//    case 'o':
//    case 'u':
//    case 'U':
//        Console.WriteLine("Output : Vowel");
//        break;
//    default:
//        Console.WriteLine("Output : Constant");
//        break;

//}
#endregion