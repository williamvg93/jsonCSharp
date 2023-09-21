using System.Text.Json;
using System.Text.Json.Serialization;
using JsonCSharp.entities;
using Newtonsoft;
using Newtonsoft.Json;

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
        // Dictionary<int,string> student = new Dictionary<int, string>();

        // COntrolando Error al intentar leer un archivo que no existe.
        // Console.WriteLine("\n COntrolando Error al intentar leer un archivo que no existe: ");
        // try
        // {
        //     var studentsData = File.ReadAllText("students.json");
        // }
        // catch (Exception error)
        // {
        //     Console.WriteLine($"Error: {error.Message}");
        //     Console.WriteLine($"Type: {error.GetType()}");
        // }
        // Console.WriteLine("\n Lectura y deserialización de un archivo JSON: ");
        // var productJson = JsonSerializer.Deserialize<Dictionary<int,string>>(File.ReadAllText("product.json"));
        // foreach (var item in productJson)
        // {   
        //     Console.WriteLine(item);
        // }
        
        // Console.WriteLine("\n");
        // var studentName = student.Select(s => s.Value);
        // foreach (var name in studentName)
        // {
        //     Console.WriteLine(name);
        // }

        var products = CreateProduct();
        foreach (var product in products)
        {
            Console.WriteLine(product.Code);
        }
        ConvertirArchivoJson(products);
    }

    public static void ConvertirArchivoJson(List<Product>productos){
        string productsJson = System.Text.Json.JsonSerializer.Serialize(productos);
        Console.WriteLine(productsJson);

        string prodJsonNew = JsonConvert.SerializeObject(productos.ToArray(), Formatting.Indented);
        Console.WriteLine(prodJsonNew);
    }

    public static List<Product> CreateProduct(){
        List<Product> product = new List<Product>{
            new Product {
                Code = 100001,
                Name = "Leche",
                Description = "Leche entera marca freskaleche",
                Price = 3.500f
            },
            new Product {
                Code = 100002,
                Name = "Cerveza",
                Description = "Cerveza marca Aguila",
                Price = 2.500f
            }
        };

        return product;
    }
}