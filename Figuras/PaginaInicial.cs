using Ferramentas;

public class PaginaInicial {

    public static void Execute() {

        Console.WriteLine("Bem vindo ao nosso sistema, aqui você pode salvar, alterar e remover qualquer figura, sinta-se a vontade e use a imaginação.");
        Console.WriteLine("Diga-me o que você deseja fazer.");
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Localizar");
        Console.WriteLine("3 - Alterar");
        Console.WriteLine("4 - Remover");

        var selecao = Console.ReadLine();

        switch (selecao) {

            case "1":
                Cadastrar.Execute();
            break;

            case "2":
                Localizar.Execute();
            break;

            case "3":
                Atualizar.Execute();
            break;

            case "4":
                Remover.Execute();
            break;

            default:
                Console.WriteLine("Opção escolhida não encontrada, tente novamente.");
                Execute();
            break;
        }
    }
}