using System.Globalization;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                    Console.WriteLine($"Successfully added: {grade}");
                }
            }
            else
            {
                throw new Exception("Invalid grade value! Try again.");
            }
            
        }

        public override void AddGrade(string grade)
        {

            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    this.AddGrade(95);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "5+":
                case "+5":
                    this.AddGrade(85);
                    break;
                case "5-":
                case "-5":
                    this.AddGrade(75);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "4+":
                case "+4":
                    this.AddGrade(65);
                    break;
                case "4-":
                case "-4":
                    this.AddGrade(55);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "3+":
                case "+3":
                    this.AddGrade(45);
                    break;
                case "3-":
                case "-3":
                    this.AddGrade(35);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "2+":
                case "+2":
                    this.AddGrade(25);
                    break;
                case "2-":
                case "-2":
                    this.AddGrade(15);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                case "1+":
                case "+1":
                    this.AddGrade(5);
                    break;
                default:
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
                        throw new Exception("String is not any of the correct data types");
                    }
                    break;
            }
        }

        public override void AddGrade(int grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(long grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(double grade)
        {
            float result = (float)Math.Round(grade, 2);
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong letter");
            }
        }

        public override Statiscics GetStatiscics()
        {
            var statistic = new Statiscics();

            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    int counter = 0;

                    while (line != null)
                    {
                        var number = float.Parse(line);

                        statistic.Min = Math.Min(statistic.Min, number);
                        statistic.Max = Math.Max(statistic.Max, number);
                        statistic.Average += number;
                        counter++;
                        
                        line = reader.ReadLine();
                    }

                    if (counter > 0)
                    {
                        statistic.Average /= counter;
                    }
                }
            }

            switch (statistic.Average)
            {
                case var average when average >= 80:
                    statistic.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistic.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistic.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistic.AverageLetter = 'D';
                    break;
                default:
                    statistic.AverageLetter = 'E';
                    break;
            }

            return statistic;
        }
    }
}

//Zadanie domowe
// - dokończyć implementacje tej klasy czyli walidacje, które ominęliśmy, żeby każda jedna ocena zapisywała się do pliku i żeby można było też ten plik odczytywać
// w program.cs zapisał kilka wartości, zobaczył czy się wszystko zapisuje i działa bez interfacu