using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> multiples = new List<int>();

        for (int i = 1; i <= 20; i++)
        {
            multiples.Add(i * 5);
        }

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                foreach (int multiple in multiples)
                {
                    var difference = multiple - grades[i];

                    if (difference > 0 && difference < 3)
                    {
                        grades[i] = multiple;
                        break;
                    }
                }
            }
        }

        return grades;

    }

}

class Solution
{
    public static void Main(string[] args)
    {       

        int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

    }
}
