
// Value Type Example
int number1 = 10;
int number2 = 60;
number1 = number2;
number2 = 50;

Console.WriteLine(number1);

// Referance Type Example
int[] numbers1 = new int[3] {77,54,89};
int[] numbers2 = new int[3] { 37,44, 59 };
numbers1 = numbers2;
numbers2[0] = 12;

Console.WriteLine(numbers1[0]);
