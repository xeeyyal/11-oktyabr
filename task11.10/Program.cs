namespace task11._10
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //TASK-1
            //Animal animal = new Animal("");

            //Console.WriteLine(animal.BirthDate);

            //Dog animal1 = new Dog("Qarabash", "Golden Retriever", "Erkek");

            //Console.WriteLine(animal1._breed);

            //TASK-2

            //Student student=new Student("Xeyal", "Huseynov", 20,true);
            //Console.WriteLine(student);
        }
    }

    //TASK-1
    //class Animal
    //{
    //    public string _gender { get; }
    //    private DateTime _birthDate;

    //    public DateTime BirthDate
    //    {
    //        get { return _birthDate; }
    //    }

    //    public Animal(string gender)
    //    {
    //        _gender = gender;
    //        _birthDate = DateTime.Now;

    //        _birthDate= DateTime.Now;
    //    }

    //}

    //class Dog:Animal
    //{
    //    public string _name { get; }
    //    public string _breed { get; }

    //    public Dog(string name, string breed, string gender) : base(gender)
    //    {
    //        _name = name;
    //        _breed = breed;

    //        _breed = "Golden Retriever";
    //    }
    //}


    //TASK-2
    //class Person
    //{
    //    //fields
    //    public string _name { get; }
    //    public string _surname { get; }
    //    public int _age { get; }

    //    public Person(string name, string surname, int age)
    //    {
    //        _name = name;
    //        _surname = surname;
    //        _age = age;
    //    }
    //}

    //class Student:Person 
    //{
    //    public bool _isonline { get; }

    //    public Student(string name, string surname, int age, bool isonline) : base(name, surname, age)
    //    {
    //        _isonline = isonline;
    //    }

    //    //Bu meethodu bilmedim student error verirdi alt+enter eledim duzeldi ve bu method yarandi.
    //    internal static void Add(Student student)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Group
    //{
    //    public string _groupname { get; }
    //    public List<Student> _students { get; }

    //    public Group(string groupname)
    //    {
    //        _groupname = groupname;
    //        _students = new List<Student>();
    //    }

    //    public void Add(Student student)
    //    {
    //        Student.Add(student);
    //    }

    //    public void GetAll(string name, string surname)
    //    {
    //        Console.WriteLine($"Qrupda oxuyan butun telebelerin: {name}, {surname}");
    //    }

    //    public void GetOnlineStudents(string name, string surname)
    //    {
    //        Console.WriteLine($"Online oxuyan telebeler {_groupname}:");
    //        foreach (var student in Student)
    //        {
    //            if (student.IsOnline)
    //            {
    //                Console.WriteLine($"{student.Name} {student.Surname}");
    //            }
    //        }
    //    }

    //    public void GetOfflineStudents(string name, string surname)
    //    {
    //        Console.WriteLine($"Offline oxuyan telebeler: {_groupname}");
    //        foreach (var student in Student)
    //        {
    //            if (!student.IsOnline)
    //            {
    //                Console.WriteLine($"{student.Name} {student.Surname}");
    //            }
    //        }
    //    }
    //}
}