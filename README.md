## LAB OF COLLEGE

### Projects

1. **FirstQuestionFibonacciSeries**  
   This project generates the Fibonacci series up to a specified number of terms.

   ```csharp
   int a = 0, b = 1, c, n = 10;
   Console.Write($"{a} {b} ");
   for (int i = 2; i < n; i++) {
    c = a + b;
    Console.Write($"{c} ");
    a = b;
    b = c;
   }
   ```

````


2. **QuestionEighteenSingleInheritance**
Demonstrates single inheritance where a child class inherits from a parent class.

  ```csharp
class Parent {
   public void Display() => Console.WriteLine("Parent class method");
}
class Child : Parent {
   public void Show() => Console.WriteLine("Child class method");
}
````

3. **QuestionEightNumberToCharacter**  
   Converts a number to its corresponding ASCII character.

   ```csharp
   int number = 65;
   char character = (char)number;
   Console.WriteLine($"Character: {character}");
   ```

````


4. **QuestionElevenCascadedMethod**
Shows method chaining by returning the current instance from methods.

  ```csharp
class Example {
   public Example Method1() {
      Console.WriteLine("Method1");
      return this;
   }
   public Example Method2() {
      Console.WriteLine("Method2");
      return this;
   }
}
````

5. **QuestionFifteenMethodReturningObject**  
   Demonstrates a method that returns an object of the same class.

```csharp
class Example {
   public Example GetObject() => new Example();
}
```

6. **QuestionFiveSwapNumbers**  
   Swaps two numbers using tuple deconstruction.

   ```csharp
   int a = 5, b = 10;
   (a, b) = (b, a);
   Console.WriteLine($"a: {a}, b: {b}");
   ```

````

7. **QuestionFourSumOfDigits**
Calculates the sum of the digits of a given number.

  ```csharp
int number = 123, sum = 0;
while (number > 0) {
   sum += number % 10;
   number /= 10;
}
Console.WriteLine($"Sum of digits: {sum}");
````

8. **QuestionFourteenObjectAsArgument**  
   Passes an object as an argument to a method.

   ```csharp
   class Example {
     public void Display(Example obj) => Console.WriteLine("Object passed as argument");
   }
   ```

````

9. **QuestionNineClassAndObject**
Demonstrates the creation of a class and its object.

  ```csharp
class Example {
   public void Display() => Console.WriteLine("Hello, World!");
}
````

10. **QuestionNineteenMultilevelInheritance**  
    Illustrates multilevel inheritance where a class inherits from another derived class.

    ```csharp
    class Grandparent {
     public void Display() => Console.WriteLine("Grandparent class");
    }
    class Parent : Grandparent {}
    class Child : Parent {}
    ```

````

11. **QuestionSevenNumberTriangle**
Prints a triangle of numbers using nested loops.

  ```csharp
for (int i = 1; i <= 5; i++) {
   for (int j = 1; j <= i; j++) {
     Console.Write(j + " ");
   }
   Console.WriteLine();
}
````

12. **QuestionSeventeenBoxing**  
    Explains boxing and unboxing in C#.

    ```csharp
    int num = 10;
    object obj = num; // Boxing
    int unboxed = (int)obj; // Unboxing
    ```

````

13. **QuestionSisteenSealedClass**
Demonstrates the use of a sealed class to prevent inheritance.

   ```csharp
sealed class Example {
   public void Display() => Console.WriteLine("Sealed class");
}
````

14. **QuestionSixDecimalToBinary**  
    Converts a decimal number to its binary representation.

    ```csharp
    int number = 10;
    string binary = Convert.ToString(number, 2);
    Console.WriteLine($"Binary: {binary}");
    ```

````

15. **QuestionTenThisReference**
Shows the use of the `this` reference in a class.

   ```csharp
class Example {
   public void Display() => Console.WriteLine(this);
}
````

16. **QuestionThirteenNonTrailingArguments**  
    Demonstrates the use of optional parameters in a method.

    ```csharp
    void Display(int a, int b = 10) => Console.WriteLine($"a: {a}, b: {b}");
    ```

````

17. **QuestionTwelvePolymorphism**
Explains polymorphism using method overriding.

   ```csharp
class Parent {
   public virtual void Display() => Console.WriteLine("Parent class");
}
class Child : Parent {
   public override void Display() => Console.WriteLine("Child class");
}
````

18. **QuestionTwentyInterfaceImplementation**  
    Implements an interface in a class.

    ```csharp
    interface IExample {
    void Display();
    }
    class Example : IExample {
    public void Display() => Console.WriteLine("Interface implemented");
    }
    ```

````

19. **QuestionThreePrimeNumberCheck**
Checks whether a given number is prime.

   ```csharp
int number = 7;
bool isPrime = true;
for (int i = 2; i <= Math.Sqrt(number); i++) {
   if (number % i == 0) {
     isPrime = false;
     break;
   }
}
Console.WriteLine(isPrime ? "Prime" : "Not Prime");
````

20. **QuestionTwoFactorialCalculation**  
    Calculates the factorial of a given number.

    ```csharp
    int number = 5, factorial = 1;
    for (int i = 1; i <= number; i++) {
      factorial *= i;
    }
    Console.WriteLine($"Factorial: {factorial}");
    ```

````

21. **QuestionTwentyOneAbstractClass**
Demonstrates the use of an abstract class and its implementation.

   ```csharp
abstract class Example {
   public abstract void Display();
}
class Derived : Example {
   public override void Display() => Console.WriteLine("Abstract class implemented");
}
````

22. **QuestionTwentyTwoExceptionHandling**  
    Handles exceptions using a try-catch block.

    ```csharp
    try {
    int result = 10 / 0;
    } catch (DivideByZeroException ex) {
    Console.WriteLine($"Exception: {ex.Message}");
    }
    ```

````

23. **QuestionTwentyThreeFileHandling**
Demonstrates basic file handling operations like writing and reading a file.

   ```csharp
File.WriteAllText("example.txt", "Hello, File!");
string content = File.ReadAllText("example.txt");
Console.WriteLine(content);
````

24. **QuestionTwentyFourDelegates**  
    Explains the use of delegates for method references.

    ```csharp
    delegate void DisplayDelegate(string message);
    DisplayDelegate display = message => Console.WriteLine(message);
    display("Hello, Delegate!");
    ```

````

25. **QuestionTwentyFiveEvents**
Demonstrates the use of events in C#.

   ```csharp
class Example {
   public event Action OnEvent;
   public void Trigger() => OnEvent?.Invoke();
}
````

26. **QuestionTwentySixGenerics**  
    Shows the use of generics to create type-safe classes.

    ```csharp
    class Example<T> {
    public void Display(T value) => Console.WriteLine(value);
    }
    ```

````

27. **QuestionTwentySevenLINQQueries**
Demonstrates the use of LINQ queries to filter and process data.

   ```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(n => n % 2 == 0);
Console.WriteLine(string.Join(", ", evenNumbers));
````
