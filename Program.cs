// int a= int.Parse(Console.ReadLine());
// void PrintFromNumberToOne(int number)
// {
//     for(int i=a; i>0; i--)
//     {
//         System.Console.WriteLine(i);
//     }
// }

// PrintFromNumberToOne(a);


// Task2
// void sum(int a, int b, int c, int d)
// {
//     int sum = 0;
//     sum = a + b + c + d;
//     System.Console.WriteLine(sum);
// }

// int a=int.Parse(Console.ReadLine());
// int b=int.Parse(Console.ReadLine());
// int c=int.Parse(Console.ReadLine());
// int d=int.Parse(Console.ReadLine());

// sum(a,b,c,d);


// Task3
// int a = int.Parse(Console.ReadLine());
//      void ReverseNumber(int num)
//     {
//         int rev = 0;
//         for(int i=a; i>0;  i /= 10) 
//         {
//             rev = rev * 10 + i % 10;

//         }
//         Console.WriteLine(rev);
//     }
// ReverseNumber(a);


// Task4-1
// int a=int.Parse(Console.ReadLine());
// void star(int a)
// {
//     for(int i=a; i>0; i--)
//     {
//         System.Console.Write('*');
//     }
// }
// star(a);

// 2
// int a = int.Parse(Console.ReadLine());
// void star(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < a; j++)
//         {
//             System.Console.Write('*');
//         }
//         System.Console.WriteLine();
//     }
// }
// star(a);


// 3
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// void star(int a, int b)
// {
//     for (int i = 0; i < b; i++)
//     {
//         for (int j = 0; j < a; j++)
//         {
//             System.Console.Write('*');
//         }
//         System.Console.WriteLine();
//     }
// }
// star(a, b);


// 4
// int a = int.Parse(Console.ReadLine());
// void star(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j <= i; j++)
//         {
//             System.Console.Write('*');
//         }
//         System.Console.WriteLine();
//     }
// }
// star(a);


// Task5
// int a = int.Parse(Console.ReadLine());
// void PrintSpaces(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         System.Console.Write(" ");
//     }
// }

// // PrintSpaces(3);

// void PrintStars(int a)
// {
//     for (int j = 0; j < a; j++)
//     {
//         System.Console.Write("*");
//     }
// }

// // PrintStars(3);

// void PrintTree(int a)
// {
//     for (int i = 1; i <= a; i++)
//     {
//         PrintSpaces(a - i);
//         PrintStars(i);
//         System.Console.WriteLine();
//     }
// }
// PrintTree(a);


// 2
// int a = int.Parse(Console.ReadLine());
// void PrintSpaces(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         System.Console.Write(" ");
//     }
// }

// // PrintSpaces(3);

// void PrintStars(int a)
// {
//     for (int j = 0; j < a * 2 - 1; j++)
//     {
//         System.Console.Write("*");
//     }
// }

// // PrintStars(3);

// void PrintTree(int a)
// {
//     for (int i = 1; i <= a; i++)
//     {
//         PrintSpaces(a - i);
//         PrintStars(i);
//         System.Console.WriteLine();
//     }
//     poya(a);
// }
// void poya(int b)
// {
//     for (int i = 0; i < 2; i++)
//     {
//         PrintSpaces(b - 2);
//         for (int g = 0; g < 3; g++)
//         {
//             System.Console.Write("*");
//         }
//         System.Console.WriteLine();
//     }

// }
// PrintTree(a);



// Home-Task2
int a = int.Parse(Console.ReadLine());
void func(int a)
{
    int ev = 0;
    int od = 0;
    int cnt = 0;
    int sum = 0;

    for (int i = a; i > 0; i/=10)
    {
        int r = i % 10;
        if (r % 2 == 0)
        {
            ev++;
        }
        else
        {
            od++;
        }

        cnt++;
        sum+=r;
    }

    System.Console.WriteLine($"Even:{ev}");
    System.Console.WriteLine($"Odd:{od}");
    System.Console.WriteLine($"Digit:{cnt}");
    System.Console.WriteLine($"Sum:{sum}");
}
func(a);