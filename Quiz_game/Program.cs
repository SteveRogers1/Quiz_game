// See https://aka.ms/new-console-template for more information
string? Name; // Поч с прописной буквы локальная переменная?
char?  answer = null;
bool validity_flag = false;
int point = 0; // после этой строки должна быть пустая строка, что бы отделить визуально разные блоки кода... где пустые строки?
Console.WriteLine("What is your name?");
Name = Console.ReadLine();
Console.WriteLine("Hello, " + Name + "! Welcome to the quiz!");
Console.WriteLine("First question!");
Console.WriteLine("Whose national dish is borscht?");
Console.WriteLine("Answer options:");
Console.WriteLine("А:Russia");
Console.WriteLine("B:Ukraine");
Console.WriteLine("C:Belarus");
answer = Convert.ToChar(Console.ReadLine());
if (answer == 'B' || answer == 'b') { Console.WriteLine("Correctly!"); validity_flag = true; point++; } // не делай в одну линию - плохо читается
else Console.WriteLine("Wrong answer!"); validity_flag = false;

Console.WriteLine("Second question!");
Console.WriteLine("Whose national dish is cabbage soup?");
Console.WriteLine("Answer options:");
Console.WriteLine("А:Russia");
Console.WriteLine("B:Ukraine");
Console.WriteLine("C:Belarus");
answer = Convert.ToChar(Console.ReadLine());
if (answer == 'A' || answer == 'a') { Console.WriteLine("Correctly!"); validity_flag = true; point++; } // и вообще никогда не продолжай код на строке, где поставил ;
else Console.WriteLine("Wrong answer!"); validity_flag = false;

Console.WriteLine("Third question!");
Console.WriteLine("Whose national dish is Draniki?");
Console.WriteLine("Answer options:");
Console.WriteLine("А:Russia");
Console.WriteLine("B:Ukraine");
Console.WriteLine("C:Belarus");
answer = Convert.ToChar(Console.ReadLine());
if (answer == 'C' || answer == 'c') { Console.WriteLine("Correctly!"); validity_flag = true; point++; }
else Console.WriteLine("Wrong answer!"); validity_flag = false;
if (point == 3) { Console.WriteLine("Congratulations on the victory! "+ Name); }
else Console.WriteLine("Sorry you are dumb, close the game! "+ Name);

/*
  А-а-а, вот где они!
*/


