//To try an exercise, just delete comment and run, then to go to next exercise, put back comment on past exercises

/* Exercise 1
 
Console.WriteLine("Hello, World!");


for (int i = 1; i <= 10; i++)

{
    for (int j = 1; j <= 10; j++)
    {
        int result = i * j;
        if (result%2!=0)
        {
            Console.WriteLine(i + " x " + j + " = " + i * j);
        }

    }
}

//Last question starts here

int choice = AskUserForParameter();
for (int i = 1; i <= 10 ; i++)
{
    Console.WriteLine(i + " x " + choice + " = " + choice * i);
}

static int AskUserForParameter()
{
    Console.WriteLine("Please write a number and press enter :");
    int.TryParse(Console.ReadLine(), out var result);
    return result;
}

*/

/* Exercise 2.1
 
 
all1000prime();

void all1000prime()
{
    for (int i = 1; i < 1000; i++)
    {
        is_prime(i);
    }
}

void is_prime(int n)
{
    if(n<=1)
    {
        return;
    }
    else
    {
        for (int i = 2; i < n; i++)
        {
            if (n%i==0)
            {
                return;
            }
        }
        Console.WriteLine(n);
    }
    return;
}

*/

/* Exercise 2.2
 
for (int i = 0; i < 15; i++)
{
    Console.WriteLine(fib(i));
}

int fib(int n)
{
    int a = 1;
    int b = 1;
    // In N steps compute Fibonacci sequence iteratively.
    for (int i = 0; i < n; i++)
    {
        int temp = a;
        a = b;
        b = temp + b;
    }
    return a;
}

*/


/* Exercise 2.3
 
for (int i = 0; i < 15; i++)
{
    Console.WriteLine(facto(i));
}
int facto(int n)
{
    int result = n;
    for (int i = 1; i < n; i++)
    {
        result *= i;
    }
    return result;
}
*/



/* Exercise3
 
 int PowerFunction(int x)
{
    return (int)(Math.Pow(x, 2) - 4);
}
while (true) {
    int x = 0;
    do
    {
        Console.WriteLine("Enter a number to be processed between 3 and -3");
        x = Convert.ToInt32(Console.ReadLine());
    } while (x < -3 || x > 3);

    try
    {
        int result = PowerFunction(x);
        Console.WriteLine("Processing");
        Console.WriteLine(result);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Attempted divide by zero. {0}", ex.Message); //I don't know why but no exception is ever raised so the catch doesnt catch, as he should catch
        throw;
    }
}

*/


/* Exercise 4
 
int n = 0;
int m = 0;
do
{
    Console.WriteLine("if a rectangle is a n x m matrice, choose n");
    n = Convert.ToInt32(Console.ReadLine());
} while (n < 1 || n > 1000);

do
{
    Console.WriteLine("if a rectangle is a n x m matrice, choose m");
    m = Convert.ToInt32(Console.ReadLine());
} while (m < 1 || m > 1000);

rectangle(n, m);

static void rectangle(int n, int m)
{
    string current;
    for (int i = 0; i < n; i++)
    {
        if (i == 0 || i == n - 1)
        {
            current = "_";
            Console.Write("0"); //use write so we don't skip a line
        }
        else
        {
            current = " ";
            Console.Write("|");//use write so we don't skip a line
        }

        for (int j = 1; j < m - 1; j++)
            Console.Write(current); //use write so we don't skip a line

        if (i == 0 || i == n - 1)
            Console.Write("0"); //use write so we don't skip a line
        else
            Console.Write("|"); //use write so we don't skip a line
        Console.WriteLine();
    }
}

*/


/* Exercise 5
int marges = 111;
int asterisqueetperils = 11;
for (int i = 0; i < marges; i++)
{
    for (int j = 0; j < marges; j++)
    {
        Console.Write(" ");
    }
    for (int j = 0; j < marges; j++)
    {
        Console.Write("* ");
    }
    Console.WriteLine();
    marges--;
    asterisqueetperils++;
}
Console.WriteLine("        |   |       "); //result isn't great but fun

 */