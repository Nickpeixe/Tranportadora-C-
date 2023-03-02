namespace View
{
    public class Caminhao
    {
        public static void CadastrarCaminhao()
        {
            Console.WriteLine("Cadastrar caminhão");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Motorista:");
            string motorista = Console.ReadLine();
            try {
                Controller.Caminhao.CadastrarCaminhao(id, placa, motorista);
                Console.WriteLine("Caminhão cadastrado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao cadastrar caminhão: {e.Message}");
            }
        }

        public static void AlterarCaminhao()
        {
            Console.WriteLine("Alterar caminhão");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Placa:");
            string placa = Console.ReadLine();
            Console.WriteLine("Motorista:");
            string motorista = Console.ReadLine();
            try {
                Controller.Caminhao.AlterarCaminhao(id, placa, motorista);
                Console.WriteLine("Caminhão alterado com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao alterar caminhão: {e.Message}");
            }
        }

        public static void ExcluirCaminhao()
        {
            Console.WriteLine("Excluir caminhão");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            try {
                Controller.Caminhao.ExcluirCaminhao(id);
                Console.WriteLine("Caminhão excluído com sucesso");
            } catch (Exception e) {
                Console.WriteLine($"Erro ao excluir caminhão: {e.Message}");
            }
        }

        public static void ListarCaminhoes() {
            Console.WriteLine("Listar caminhões");
            foreach (Model.Caminhao caminhao in Controller.Caminhao.ListarCaminhoes()) {
                Console.WriteLine(caminhao);
            }
        }
    }
}