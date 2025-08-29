// See https://aka.ms/new-console-template for more information

using System.Globalization;

String[] students = ["Sophia", "Saroja", "Sujata", "Sanjev"];
Random mark = new Random();
int n = students.Length;

int[][] marks = new int[n][];
float[] overallScore = new float[n];

for (int i = 0; i < students.Length; i++)
{
    marks[i] = new int[5];
    for (int j = 0; j < 5; j++)
    {
        marks[i][j] = mark.Next(70, 101);
    }
}

for (int i = 0; i < n; i++)
{
    overallScore[i] = 0;
    for (int j = 0; j < 5; j++)
    {
        overallScore[i] += marks[i][j];
    }
    overallScore[i] /= 5;
}

int[] gradeRange = [97, 93, 90, 87, 83, 80, 77, 73, 70, 67, 63, 60];
string[] grades = ["A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F"];

Console.WriteLine("Student\t\tGrade\n");
for (int i = 0; i < n; i++)
{
    int j = 0;
    Console.Write($"{students[i]}:\t\t{overallScore[i]}");
    while (j < gradeRange.Length && overallScore[i] < gradeRange[j]) j++;
    Console.WriteLine($"\t{grades[j]}");
}

