// initialize variables - graded assignments 
//int currentAssignments = 5;

//int sophia1 = 90;
//int sophia2 = 86;
//int sophia3 = 87;
//int sophia4 = 98;
//int sophia5 = 100;

//int andrew1 = 92;
//int andrew2 = 89;
//int andrew3 = 81;
//int andrew4 = 96;
//int andrew5 = 90;

//int emma1 = 90;
//int emma2 = 85;
//int emma3 = 87;
//int emma4 = 98;
//int emma5 = 68;

//int logan1 = 90;
//int logan2 = 95;
//int logan3 = 87;
//int logan4 = 88;
//int logan5 = 96;


//int sophiaSum = 0;
//int andrewSum = 0;
//int emmaSum = 0;
//int loganSum = 0;

//decimal sophiaScore;
//decimal andrewScore;
//decimal emmaScore;
//decimal loganScore;


//sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
//andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
//emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
//loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

//sophiaScore = (decimal)sophiaSum / currentAssignments;
//andrewScore = (decimal)andrewSum / currentAssignments;
//emmaScore = (decimal)emmaSum / currentAssignments;
//loganScore = (decimal)loganSum / currentAssignments;

//Console.WriteLine("Student\t\tGrade\n");
//Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
//Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
//Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
//Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

//// Student names
//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

//foreach (string item in studentNames)
//{
//    Console.WriteLine($"{item}");
//    // int sophiaSum = 0;
//}

//Console.WriteLine("Palindorom Word");

//Console.WriteLine("Enter a word");

//string input = Console.ReadLine();
//string reverse = new string(input.Reverse().ToArray());

//if (reverse == input)
//{
//    Console.WriteLine("Its palindorom");
//}
//else
//{
//    Console.WriteLine("Its not palindorom");

//}

//Console.WriteLine("Loop");

//for (int i = 1; i < 10001; i++)
//{
//    Console.WriteLine(i);
//}

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());



// Conditional Operator

Console.WriteLine("What is the conditional operator?\r\nThe conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred to as the ternary conditional operator.");

int sale = 1001;
int discount = sale > 1000 ? 100 : 50;

Console.WriteLine($"Discount : {discount}");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();