﻿namespace ChallengeApp
{
    public class Supervisor : Employee, IEmployee
    {
        public Supervisor(string name, string surname)
            : base(name, surname)
        {
        }

        //public string Name => "Dominik";

        //public string Surname => "Wisniewski";

        //public void AddGrade(float grade)
        //{
        //    if (grade >= 0 && grade <= 100)
        //    {
        //        grades.Add(grade);
        //    }
        //    else
        //    {
        //        throw new Exception("Invalid grade value");
        //    }
        //}

        public void AddGrade(string gradeAsString)
        {
            switch (gradeAsString)
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
                    throw new Exception("Give the number from the range of 1 to 6.");
            }
        }

        //public void AddGrade(int grade)
        //{
        //    float result = (float)grade;
        //    this.AddGrade(result);
        //}

        //public void AddGrade(long grade)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddGrade(double grade)
        //{
        //    throw new NotImplementedException();
        //}

        //public void AddGrade(char grade)
        //{
        //    throw new NotImplementedException();
        //}

        //public Statiscics GetStatiscics()
        //{
        //    return new Statiscics();
        //}
    }
}
