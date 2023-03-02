namespace View
{
    public class Cidade
    {
        public static void CadastrarCidade()
        {
            Console.WriteLine("Digite o id da cidade:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome da cidade:");
            string nome = Console.ReadLine();
            try {
                Controller.Cidade.CadastrarCidade(id, nome);
                Console.WriteLine("Cidade cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar cidade: {e.Message}");
            }
        }

        public static void AlterarCidade()
        {
            Console.WriteLine("Digite o id da cidade:");
            string id = Console.ReadLine();
            Console.WriteLine("Digite o nome da cidade:");
            string nome = Console.ReadLine();
            try {
                Controller.Cidade.AlterarCidade(id, nome);
                Console.WriteLine("Cidade alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar cidade: {e.Message}");
            }
        }

        public static void ExcluirCidade()
        {
            Console.WriteLine("Digite o id da cidade:");
            string id = Console.ReadLine();
            try {
                Controller.Cidade.ExcluirCidade(id);
                Console.WriteLine("Cidade excluída com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao excluir cidade: {e.Message}");
            }
        }

        public static void ListarCidades() {
            Console.WriteLine("Listar cidades");
            foreach (Model.Cidade cidade in Controller.Cidade.ListarCidades()) {
                Console.WriteLine(cidade);
            }
        }

        
    }
}