using Practice.Practice;
using Practice.Practice.Siemens;
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static Practice.Practice.Blocks;
using static Practice.Practice.MovingZerosToTheEnd;

/*Block b = new Block(new int[] { 2, 2, 2 });
Console.WriteLine(b.GetSurfaceArea());*/

//Console.WriteLine(Convert.ToInt32('A'));

//Multiples_of_3_or_5 a = new Multiples_of_3_or_5();
//Console.WriteLine(a.Solution(23));
/*
int[] arr = { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
MovingZerosToTheEnd mz = new MovingZerosToTheEnd();
int[] result = mz.MoveZeroes(arr);
Console.WriteLine(String.Join(",", result));*/

/*string word = "Success";
DuplicateEncoder a = new DuplicateEncoder();
Console.WriteLine(a.DuplicateEncode(word));*/

/*BouncingBalls a = new BouncingBalls();
Console.WriteLine(a.bouncingBall(3.0, 0.66, 1.5));*/

/*FindUnique a = new FindUnique();
Console.WriteLine(a.GetUnique(new[] { 1, 2, 2, 2 }));*/

/*Isograms a = new Isograms();
Console.WriteLine(a.IsIsogram("Isogram"));*/

/*DecendingOrder a = new DecendingOrder();
Console.WriteLine(a.DescendingOrder(145263));*/

/*AlphabetPosition a = new AlphabetPosition();
Console.WriteLine(a.GetAlphabetPosition("The sunset sets at twelve o' clock."));*/

/*CenturyFromYear a = new CenturyFromYear();
Console.WriteLine(a.centuryFromYear(1700));*/


/*shapeArea a = new shapeArea();
Console.WriteLine(a.solution(5));*/

/*MakeArrayConsecutive a = new MakeArrayConsecutive();
Console.WriteLine(a.solution(new[] { 6,2,3,8}));*/

/*AlmostIncreasingSequence a = new AlmostIncreasingSequence();
Console.WriteLine(a.solution(new[] { 10, 1, 2, 3, 4, 5}));*/

/*MatricElementsSum a = new MatricElementsSum();
int result = a.solution(new int[][]
            {
                new int[] {0, 1, 1, 2},
                new int[] {0, 5, 0, 0},
                new int[] {2, 0, 3, 3}
            });*/

/*GimmeIndex a = new GimmeIndex();
Console.WriteLine(a.solution(new[] { 2, 5, 3, 9, 7 }));*/

/*XorLogicalOperator a = new XorLogicalOperator();
Console.WriteLine(a.solution(false, false));*/

/*NameInitials a = new NameInitials();
Console.WriteLine(a.solution("chad smith"));*/

/*ExpandedNumbers a = new ExpandedNumbers();
Console.WriteLine(a.solution(70304));*/

/*StringReverse a  = new StringReverse();
Console.WriteLine(a.solution("FirstWord"));*/

/*ClimbingStairs a = new ClimbingStairs();
Console.WriteLine(a.solution(new List<int> { 1,2,1,3 }));*/

/*IntegersInStrings a = new IntegersInStrings("1,99,3");
foreach (var num in a.Integers())
{
    Console.WriteLine(num);
}*/
/*Palindrome2 a = new Palindrome2();
Console.WriteLine(a.solution("level"));*/

/*List<List<int>> arr = new List<List<int>>()
        {
            new List<int> {1, 1, 1, 0, 0, 0},
            new List<int> {0, 1, 0, 0, 0, 0},
            new List<int> {1, 1, 1, 0, 0, 0},
            new List<int> {0, 0, 2, 4, 4, 0},
            new List<int> {0, 0, 0, 2, 0, 0},
            new List<int> {0, 0, 1, 2, 4, 0}
        };

int maxHourglassSum = _2dArrayMax.hourglassSum(arr);
Console.WriteLine("Maximum hourglass sum: " + maxHourglassSum);*/

CountChars countChars = new CountChars();

// Input string
string s = "aba";

// Call the Count method to get the dictionary of character counts
Dictionary<char, int> d = CountChars.Count(s);

// Print the character counts
foreach (var pair in d)
{
    Console.WriteLine($"Character: {pair.Key}, Count: {pair.Value}");
}