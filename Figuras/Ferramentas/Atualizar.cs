using System.Text.Json;

namespace Ferramentas;
public class Atualizar {
    
    public static void Execute() {

        List<Figura> figuras = JsonSerializer.Deserialize<List<Figura>>(File.ReadAllText("./Repositorio/Figura.json"));

        tryagain:

        Console.WriteLine("As figuras que foram arquivadas no nosso sistema são:");
            
            foreach (var figura in figuras) {
                Console.WriteLine(figura.Formato);
            }
        
        Console.WriteLine("Escolha qual dessas figuras você deseja atualizar alguma informção.");
        
        var escolha = Console.ReadLine();
        var figuraEscolhida = figuras.FirstOrDefault(f => f.Formato == escolha);

            if (figuraEscolhida == null) {
                Console.WriteLine("Figura escolhida não encontrada, verifique o nome e tente novamente.");
                goto tryagain;
            } 

                Console.WriteLine("Estas são todas as informações sobre a figura selecionada.");
                Console.WriteLine($"Formato: {figuraEscolhida.Formato}");
                Console.WriteLine($"Cor: {figuraEscolhida.Cor}");
                Console.WriteLine($"Espessura: {figuraEscolhida.Espessura}");

                Console.Write("O que você deseja alterar? ");
                var alterar = Console.ReadLine();

                switch(alterar) {

                    case "Formato":
                        
                        Console.WriteLine("Qual é o novo formato?");
                        string novoFormato = Console.ReadLine();
                        figuraEscolhida.Formato = novoFormato;

                    break;

                    case "Cor":

                        Console.WriteLine("Qual é a nova cor?");
                        string novaCor = Console.ReadLine();
                        figuraEscolhida.Cor = novaCor;

                    break;

                    case "Espessura":

                        Console.WriteLine("Qual é a nova espessura?");
                        double novaEspessura = double.Parse(Console.ReadLine());
                        figuraEscolhida.Espessura = novaEspessura;

                    break;

                    default:
                        Console.WriteLine("Não foi identificado a sua escolha de troca, tente novamente.");
                        Execute();
                    break;
                }

                var identacaoJson = new JsonSerializerOptions{WriteIndented = true};
                string escreverJson = JsonSerializer.Serialize<List<Figura>>(figuras, identacaoJson);
                StreamWriter streamW = new StreamWriter("./Repositorio/Figura.json");
                streamW.WriteLine(escreverJson);
                streamW.Close();

                PaginaInicial.Execute();
    }
}