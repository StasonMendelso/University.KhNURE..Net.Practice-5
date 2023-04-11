using System.Text;
using System.Text.Json.Serialization;

namespace Practice5.entity;
[Serializable]
public class Student
{
    [JsonPropertyName("FirstName")] public string Name { get; set; }
    public int Age { get; set; }
    [JsonIgnore] public Dictionary<string, float> Marks { get; set; }

    public Student(string name, int age, Dictionary<string, float> marks)
    {
        Name = name;
        Age = age;
        Marks = marks;
    }

    public void DisplayInfo()
    {
        Console.Write($"Student{{ name = {Name}, age = {Age}, marks = ");
        StringBuilder stringBuilder = new StringBuilder("{");
        if (Marks != null)
        {
            int count = Marks.Count;
            foreach (KeyValuePair<string, float> keyValuePair in Marks)
            {
                if (--count == 0)
                {
                    stringBuilder.Append($"{keyValuePair.Key} = {keyValuePair.Value}");
                }
                else
                {
                    stringBuilder.Append($"{keyValuePair.Key} = {keyValuePair.Value}, ");
                }
            }
        }

        Console.WriteLine(stringBuilder.ToString() + "} }");
    }
}