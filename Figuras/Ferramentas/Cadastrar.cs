using Repositorio;

namespace Ferramentas;
public class Cadastrar {
    public static void Execute() {

        Console.WriteLine("Olá, me diga qual o formato, cor e espessura da figura desejada.");
        Console.Write("Formato: ");
        string formato = Console.ReadLine();
        Console.Write("Cor: ");
        string cor = Console.ReadLine();
        Console.Write("Espessura: ");
        double espessura = double.Parse(Console.ReadLine());

        var figura = new Figura(formato, cor, espessura);

        EscreverJson.Execute(figura);
        
        PaginaInicial.Execute();
    }
}