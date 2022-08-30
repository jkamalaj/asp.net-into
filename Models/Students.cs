namespace FirstLesson_BackEnd.Models
{
    public class Student
    {
        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
