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

        //GetStatiscics jest z pętlą foreach, więc nie tworzyłem nowej metody GetStatisticsWithForeach();
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

        public Statiscics GetStatisticsWithfor()
        {
            var statistics = new Statiscics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int i = 0; i < this.grades.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[i]);
                statistics.Min = Math.Min(statistics.Min, grades[i]);
                statistics.Average += this.grades[i];
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statiscics GetStatisticsWithWhile()
        {
            var statistics = new Statiscics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int i = 0;
            while (i < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;
            }

            statistics.Average /= this.grades.Count;

            return statistics;
        }

        public Statiscics GetStatisticsWithDoWhile()
        {
            var statistics = new Statiscics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            int i = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[i]);
                statistics.Min = Math.Min(statistics.Min, this.grades[i]);
                statistics.Average += this.grades[i];
                i++;

            } while (i < this.grades.Count);

            statistics.Average /= this.grades.Count;

            return statistics;
        }
    }
}

