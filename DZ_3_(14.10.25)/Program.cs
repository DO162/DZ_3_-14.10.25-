namespace classes
{
    class Student
    {
        string name = "Dima";
        string secondname = "Antonov";
        string fathername = "Kiril";

        //---------------------------------------
        DateTime birthday;
        List<string> address = new List<string>();
        List<int> exams = new List<int>();
        List<int> homeworks = new List<int>();
        List<int> lessons = new List<int>();

        string numberPhone = "123456789";
        //---------------------------------------

        public void SetName(string name)
        {
            this.name = name;
        }
        //-------------------
        public string GetName()
        {
            return name!;
        }
        //---------------------------------------

        public void SetSecondName(string secondname)
        {
            this.secondname = secondname;
        }
        //-------------------
        public string GetSecondName()
        {
            return secondname!;
        }
        //---------------------------------------

        public void SetFathername(string fathername)
        {
            this.fathername = fathername;
        }
        //-------------------
        public string GetFathername()
        {
            return fathername!;
        }
        //---------------------------------------

        public void SetBirthday(int day, int month, int year)
        {
            birthday = new DateTime(year, month, day);
        }
        //-------------------
        public string GetBirthday()
        {
            return birthday.ToString("dd.MM.yyyy");
        }
        //---------------------------------------

        public void SetAddress(string street, string house)
        {
            address.Clear();
            address.Add(street);
            address.Add(house);
        }
        //-------------------
        public string GetAddress() //
        {
            if (address.Count >= 2)
                return $"{address[0]}, {address[1]}";
            return "";
        }
        //---------------------------------------

        public void SetNumberPhone(string numberPhone)
        {
            this.numberPhone = numberPhone;
        }
        //-------------------
        public string GetNumberPhone()
        {
            return numberPhone!;
        }
        //---------------------------------------

        public void SetExam(int exam)
        {
            exams.Add(exam);
        }
        //-------------------
        public int GetExam()
        {
            foreach (int number in exams)
            {
                return number;
            }
            return 0;
        }
        //---------------------------------------

        public void SetHomework(int homework)
        {
            homeworks.Add(homework);
        }
        //-------------------
        public int GetHomework()
        {
            foreach (int number in homeworks)
            {
                return number;
            }
            return 0;
        }
        //---------------------------------------

        public void SetLesson(int lesson)
        {
            lessons.Add(lesson);
        }
        //-------------------
        public int GetLesson()
        {
            foreach (int number in lessons)
            {
                return number;
            }
            return 0;
        }
        //---------------------------------------------------------------------

        public Student(string name, string secondname, string father, int day, int month, int year, string street, string house, string numberPhone, 
            int count_lesson, int count_homework, int count_exam, int lesson, int exam, int homework)
        {
            SetName(name);
            SetSecondName(secondname);
            SetFathername(father);
            SetBirthday(day, month, year);
            SetAddress(street, house);
            SetNumberPhone(numberPhone);

            for (int i = 0; i < count_lesson; i++)
            {
                SetLesson(lesson);
            }
            for (int i = 0; i < count_homework; i++)
            {
                SetHomework(homework);
            }
            for (int i = 0; i < count_exam; i++)
            {
                SetExam(exam);
            }
        }
        //---------------------------------------
        public Student(int count_lesson, int count_homework, int count_exam, int lesson, int exam, int homework)
        {
            for (int i = 0; i < count_lesson; i++)
            {
                SetLesson(lesson);
            }
            for (int i = 0; i < count_homework; i++)
            {
                SetHomework(homework);
            }
            for (int i = 0; i < count_exam; i++)
            {
                SetExam(exam);
            }
        }
        //---------------------------------------
        public Student() : this("Dima", "John", "Snow", 10, 8, 2005, "Abrikosova", "18B", "05151515151", 5, 5, 3, 1, 85, 90)
        {
        }
        //---------------------------------------------------------------------

        public void PrintAllFields()
        {
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Second Name: " + GetSecondName());
            Console.WriteLine("Father: " + GetFathername());
            Console.WriteLine("Birthday: " + GetBirthday());
            Console.WriteLine("Address: " + GetAddress());
            Console.WriteLine("Phone: " + GetNumberPhone());
            Console.WriteLine("Exam: " + (exams.Count > 0 ? string.Join(", ", exams) : "No exams"));
            Console.WriteLine("Homework: " + (homeworks.Count > 0 ? string.Join(", ", homeworks) : "No homeworks"));
            Console.WriteLine("Lesson: " + (lessons.Count > 0 ? string.Join(", ", lessons) : "No lessons"));
        }

        }
    internal class Program
    {
        static void Main()
        {
            Student student1 = new Student("John", "Doe", "Smith", 15, 6, 2002, "Main St", "123A", "6598584864648", 5, 5, 3, 7, 85, 90);
            Student student2 = new Student(5, 10, 3, 1, 90, 85);
            Student student3 = new Student();
            //-----------------------------------
            student1.PrintAllFields();
            Console.WriteLine("\n");
            student2.PrintAllFields();
            Console.WriteLine("\n");
            student3.PrintAllFields();
        }
    }
}