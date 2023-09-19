using System.Text.Json;
using System.Text.Json.Serialization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Dictionary<int,string> student = new Dictionary<int, string>{
        //     {1, "William"},
        //     {2, "Natalia"},
        //     {3, "Carlos"},
        //     {4, "Samir"},
        // };

        // string studentJson = JsonSerializer.Serialize(student);
        // Console.WriteLine(studentJson);

        // File.WriteAllText("student.json", studentJson);
        Dictionary<int,string> student = new Dictionary<int, string>();

        // COntrolando Error al intentar leer un archivo que no existe.
        Console.WriteLine("\n COntrolando Error al intentar leer un archivo que no existe: ");
        try
        {
            var studentsData = File.ReadAllText("students.json");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Error: {error.Message}");
            Console.WriteLine($"Type: {error.GetType()}");
        }
        Console.WriteLine("\n Lectura y deserialización de un archivo JSON: ");
        var studentJson = JsonSerializer.Deserialize<Dictionary<int,string>>(File.ReadAllText("student.json"));
        foreach (var item in studentJson)
        {   
            Console.WriteLine(item);
        }
        Console.WriteLine(studentJson);
        
    }
}