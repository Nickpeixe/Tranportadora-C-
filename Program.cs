namespace Principal
{
    public class Programa
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Rastreio de Caminhões: ");
            int opcao = 0;
            do {
                Console.WriteLine("1 - Cadastrar Rota");
                Console.WriteLine("2 - Alterar Rota");
                Console.WriteLine("3 - Excluir Rota");
                Console.WriteLine("4 - Listar Rotas");
                Console.WriteLine("5 - Cadastrar Caminhão");
                Console.WriteLine("6 - Alterar Caminhão");
                Console.WriteLine("7 - Excluir Caminhão");
                Console.WriteLine("8 - Listar Caminhões");
                Console.WriteLine("9 - Cadastrar Cidade");
                Console.WriteLine("10 - Alterar Cidade");
                Console.WriteLine("11 - Excluir Cidade");
                Console.WriteLine("12 - Listar Cidades");
                Console.WriteLine("13 - Total de Rotas em Caminhão");
                Console.WriteLine("14 - Total (R$) de Rotas em Caminhão");
                Console.WriteLine("15 - Média (AVG) de Rotas em Rota");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Opção:");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    case 1:
                        View.Rota.CadastrarRota();
                        break;
                    case 2:
                        View.Rota.AlterarRota();
                        break;
                    case 3:
                        View.Rota.ExcluirRota();
                        break;
                    case 4:
                        View.Rota.ListarRotas();
                        break;
                    case 5:
                        View.Caminhao.CadastrarCaminhao();
                        break;
                    case 6:
                        View.Caminhao.AlterarCaminhao();
                        break;
                    case 7:
                        View.Caminhao.ExcluirCaminhao();
                        break;
                    case 8:
                        View.Caminhao.ListarCaminhoes();
                        break;
                    case 9:
                        View.Cidade.CadastrarCidade();
                        break;
                    case 10:
                        View.Cidade.AlterarCidade();
                        break;
                    case 11:
                        View.Cidade.ExcluirCidade();
                        break;
                    case 12:
                        View.Cidade.ListarCidades();
                        break;
                    case 13:
                        View.Rota.TotalRotasCaminhao();
                        break;
                    case 14:
                        View.Rota.TotalValorCaminhao();
                        break;
                    case 15:
                         View.Rota.AvgValor();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (opcao != 0);
        }
    }
}