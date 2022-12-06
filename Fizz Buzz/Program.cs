Console.WriteLine("Hello, World!");

Console.WriteLine("Welcome to the Fizz Buzz Program");

Console.Write("Enter the value: ");
int n = int.Parse(Console.ReadLine());
FizzBuzz(n);
void FizzBuzz (int n) {
   

    for(int i = 1; i <= n; i++) {
        if ((i % 3 == 0) && (i % 5 == 0))
        {
            Console.WriteLine("Fizz Buzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else {
            Console.WriteLine($"{i}");
        }
        
    }
}


