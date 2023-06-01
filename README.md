# Execution Time Testing In Loops
Good day everyone, I'm Ahmed and I decided to make this repository to test each variation of the loops available in C# .NET.
You can check my interview questions for .NET in which i referenced this work: https://github.com/xx7Ahmed7xx/dotNETRevision
## What is to be found here?
In this repository, you can find a C# project that contains 2 classes: 
- TestinClasses.cs : the actual testing code is here for the different loops
- Program.cs : the class with the main entry point to start testing (plus some old code for another purposes)
## How can you run the test?
Simply add "BenchmarkRunner.Run&lt;TestingClasses&gt;()" into the entry point of your project (incase you imported it into another one) and run the project in RELEASE mode.
## What type of loops can be found here?
I tried to include all that I could think of, feel free to add to it by forking and adding into your own repository and making a pull request here.
You can find the following:
1. For loop with Array
2. For loop with Span
3. Foreach with Array
4. Foreach with Span
5. Parallel Foreach with Array
6. Parallel LINQ with Array

## Example run on .NET 6:
![image](https://github.com/xx7Ahmed7xx/ExecutionTimeInLoops/assets/36636484/1164a622-a1e5-4dd6-ae17-0ca691d1f8a7)

### Don't forget to star and follow me ❤😎🥺
