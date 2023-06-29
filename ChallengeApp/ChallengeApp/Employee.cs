using System.Globalization;
using System.Net.NetworkInformation;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)

        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float resultFloat))
            {
                this.AddGrade(resultFloat);
            }
            else if (double.TryParse(grade, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double resultDouble))
            {
                this.AddGrade(resultDouble);
            }
            else
            {
                Console.WriteLine("String is not any of the correct data types");
            }
        }

        public void AddGrade(double grade)
        {
            float result = (float)Math.Round(grade, 2);
            this.AddGrade(result);
        }

        public void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public void AddGrade(char grade)
        {
            string result = grade.ToString();
            this.AddGrade(result);
        }

        public Statiscics GetStatiscics()
        {
            var statistics = new Statiscics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}

