using System.Text.Json;

namespace Ferramentas;
public class Localizar {
    public static void Execute() {

        List<Figura> figuras = JsonSerializer.Deserialize<List<Figura>>(File.ReadAllText("./Repositorio/Figura.json"));

        Console.WriteLine("As figuras que foram arquivadas no nosso sistema são:");
            
            foreach (var figura in figuras) {
                Console.WriteLine(figura.Formato);
            }
        
        Console.WriteLine("Escolha qual dessas figuras você deseja ver os detalhes.");
        
        var escolha = Console.ReadLine();
        var figuraEscolhida = figuras.FirstOrDefault(f => f.Formato == escolha);

        Console.WriteLine("Está é a figura que você escolheu.");
        Console.WriteLine($"Formato: {figuraEscolhida.Formato}");
        Console.WriteLine($"Cor: {figuraEscolhida.Cor}");
        Console.WriteLine($"Espessura: {figuraEscolhida.Espessura}");

        Console.WriteLine("Obrigado pela participação, volte sempre!!!");
        Console.ReadKey();
        PaginaInicial.Execute();
    }
}