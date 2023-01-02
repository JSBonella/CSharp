using System.Text.Json;

namespace Ferramentas;
public class Remover {
    public static void Execute(){

        List<Figura> figuras = JsonSerializer.Deserialize<List<Figura>>(File.ReadAllText("./Repositorio/Figura.json"));

        tryagain:

        Console.WriteLine("As figuras que foram arquivadas no nosso sistema são:");
            
            foreach (var figura in figuras) {
                Console.WriteLine(figura.Formato);
            }
        
        Console.WriteLine("Escolha qual dessas figuras você deseja remover.");
        
        var escolha = Console.ReadLine();
        var figuraEscolhida = figuras.FirstOrDefault(f => f.Formato == escolha);

            if (figuraEscolhida == null) {
                Console.WriteLine("Figura escolhida não encontrada, verifique o nome e tente novamente.");
                goto tryagain;
            } else {
                Console.WriteLine("A seguinte figura e seus detalhes serão excluidos da nossa lista, tem certeza disso?");
                Console.WriteLine($"Formato: {figuraEscolhida.Formato}");
                Console.WriteLine($"Cor: {figuraEscolhida.Cor}");
                Console.WriteLine($"Espessura: {figuraEscolhida.Espessura}");
                Console.WriteLine("Sim, pode excluir.");
                Console.WriteLine("Não, selecionei a figura errada.");
                
                naosim:
                var simnao = Console.ReadLine();

                switch(simnao) {

                    case "Sim":

                        figuras.Remove(figuraEscolhida);

                        Console.WriteLine("A figura selecionada foi excluida. Você será  redirecionado para a pagina inicial.");
                        
                        var identacaoJson = new JsonSerializerOptions{WriteIndented = true};
                        string serializeJson = JsonSerializer.Serialize<List<Figura>>(figuras, identacaoJson);
                        StreamWriter streamW = new StreamWriter("./Repositorio/Figura.json");
                        streamW.WriteLine(serializeJson);
                        streamW.Close();
                        
                        PaginaInicial.Execute();

                    break;

                    case "Nao":

                        Console.WriteLine("Você escolheu a figura errada ou não deseja mais apagar a figura selecionada, você será redirecionado para a pagina inicial.");
                        PaginaInicial.Execute();
                        
                    break;

                    default:

                        Console.WriteLine(" A resposta deve ser 'sim' ou 'nao' apenas.");
                        goto naosim;

                    break;
                }
            }
    }
}