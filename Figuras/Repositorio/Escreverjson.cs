using System.Text.Json;

namespace Repositorio;

public class EscreverJson {

    public static void Execute(Figura figura) {

        List<Figura> figuras = JsonSerializer.Deserialize<List<Figura>>(File.ReadAllText("./Repositorio/Figura.json"));

        figuras.Add(figura);
            
        var identacaoJson = new JsonSerializerOptions{WriteIndented = true};
        string serializeJson = JsonSerializer.Serialize<List<Figura>>(figuras, identacaoJson);
        StreamWriter streamW = new StreamWriter("./Repositorio/Figura.json");
        streamW.WriteLine(serializeJson);
        streamW.Close();
    }
}