using System.Text.Json;
using Practice5.entity;

namespace Practice5;

public class Demo
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Default;
        Console.WriteLine("Task №1");

        string[] disciplines = { "Mathematics", "Philosophy", "English" };
        int numberOfStudents = 15;
        List<Student> students = GetStudents(disciplines, numberOfStudents);

        PrintStudents(students);

        Console.WriteLine("Task №2");
        Console.WriteLine(
            "Всі студенти для яких довжина ім'я більше ніж 4 символи та вік менше 20 у відсортованому за ім'ям в зворотному порядку:");
        List<Student> studentsForSubtask1 = new List<Student>(from student in students
            where student.Name.Length > 4 && student.Age < 20
            orderby student.Name descending
            select student);
        PrintStudents(studentsForSubtask1);
        Console.WriteLine(
            "Всі студенти відсортовані за оцінкою по математиці:");
        List<Student> studentsForSubtask2 = new List<Student>(from student in students
            orderby student.Marks[disciplines[0]]
            select student);
        PrintStudents(studentsForSubtask2);
        int countOfStudentWithUnpassedExams = (from student in students
            where student.Marks.Any(pair => pair.Value < 60)
            select student).Count();
        Console.WriteLine(
            "Кількість студентів, які не склали хоча б один іспит дорівнює {0}", countOfStudentWithUnpassedExams);
        Console.WriteLine(
            "Середній бал по кожному з предметів наступний: ");
        var resultsForSubtask4 = from student in students
            from mark in student.Marks
            group mark.Value by mark.Key
            into g
            select new
            {
                discipline = g.Key,
                average = g.Average()
            };
        foreach (var result in resultsForSubtask4)
        {
            Console.WriteLine($"{result.discipline}: {result.average}");
        }

        Console.WriteLine(
            "Є наступні вікові групи студентів та кількість студентів в них: ");
        var resultsForSubtask5 = from student in students
            group student by student.Age
            into g
            select new
            {
                age = g.Key,
                count = g.Count()
            };
        foreach (var result in resultsForSubtask5)
        {
            Console.WriteLine($"{result.age}: {result.count}");
        }

        Console.WriteLine("Task №3");
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
        string json = JsonSerializer.Serialize(students, options);
        File.WriteAllText("students.json", json);

        string jsonFromFile = File.ReadAllText("students.json");
        List<Student> deserializedStudents = JsonSerializer.Deserialize<List<Student>>(jsonFromFile, options);
        PrintStudents(deserializedStudents);
    }


    private static void PrintStudents(List<Student> students)
    {
        foreach (Student student in students)
        {
            student.DisplayInfo();
        }
    }

    private static List<Student> GetStudents(string[] disciplines, int numberOfStudents)
    {
        List<Student> students = new List<Student>();
        Random random = new Random();
        for (int i = 1; i <= numberOfStudents; i++)
        {
            Dictionary<string, float> marks = new Dictionary<string, float>();
            foreach (string discipline in disciplines)
            {
                marks.Add(discipline, random.Next(1, 100) + random.Next(1, 11) / 10f);
            }

            students.Add(new Student($"Name {i}", random.Next(17, 26), marks));
        }

        return students;
    }
}