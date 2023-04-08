


internal class Student
{
    public string Name;
    public string Surname;
    public string Group;
    public double Point;
    public string IsGraduated;

    public Student(string Name, string Surname, string Group, double Point, string IsGraduated)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Group = Group;
        this.Point = Point;
        this.IsGraduated = IsGraduated;
        }

    public void GetFullName()
    {
        Console.WriteLine(Name+" "+Surname);

    }

    public void GetFullInfo()
    {
        Console.WriteLine($"{"Name:" + this.Name},{"Surname:" + this.Surname},{"Group:" + this.Group},{"Point:" + this.Point},{this.IsGraduated}");
        if (IsGraduated == "mezun")
        {
            Console.WriteLine("Congratulations, you graduated");
        }
        else if  (IsGraduated == "mezun deyil")
        {
            Console.WriteLine("I'm sorry you didn't graduate");
        }
        if (Point >= 80)
        {
            Console.WriteLine("you can enter the second exam");
        }
        else if (Point <= 80 && Point >= 0)
        {
            Console.WriteLine("you cannot enter the second exam");
        }
       
    }
         
    }
    


