namespace View
{
    public class Rota
    {
        public static void CadastrarRota() {
            Console.WriteLine("Cadastrar Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Origem:");
            string origemId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("Valor:");
            string valor = Console.ReadLine();
            
            valor = valor.Replace(".", ",");
            try {
                Controller.Rota.CadastrarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("Rota cadastrada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void AlterarRota() {
            Console.WriteLine("Alterar Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            Console.WriteLine("Origem:");
            string origemId = Console.ReadLine();
            Console.WriteLine("Destino:");
            string destinoId = Console.ReadLine();
            Console.WriteLine("Caminhão:");
            string caminhaoId = Console.ReadLine();
            Console.WriteLine("Data:");
            string data = Console.ReadLine();
            Console.WriteLine("Valor:");
            string valor = Console.ReadLine();

            valor = valor.Replace(".", ",");
            try {
                Controller.Rota.AlterarRota(id, origemId, destinoId, caminhaoId, data, valor);
                Console.WriteLine("Rota alterada com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ExcluirRota() {
            Console.WriteLine("Excluir Rota");
            Console.WriteLine("Id:");
            string id = Console.ReadLine();
            try {
                Controller.Rota.ExcluirRota(id);
                Console.WriteLine("Rota excluída com sucesso");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }

        public static void ListarRotas() {
            Console.WriteLine("Listar Rotas");
            foreach (string rota in Controller.Rota.ListarRotas()) {
                Console.WriteLine(rota);
            }
        }    

        public static void TotalRotasCaminhao() {
            Console.WriteLine("Id do caminhão");
            Console.WriteLine("idCaminhao:");
            string id = Console.ReadLine();
            try {
                int total = Controller.Rota.TotalRotasCaminhao(id);
                Console.WriteLine("Total de Rotas para o caminhão: " + total );
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } 

         public static void TotalValorCaminhao() {
            Console.WriteLine("Id do caminhão");
            Console.WriteLine("idCaminhao:");
            string id = Console.ReadLine();

            try {
                Double total = Controller.Rota.TotalValorCaminhao(id);
                Console.WriteLine("Total : R$" + total );
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } 
        public static void AvgValor() {
            
            Console.WriteLine("Avg valor de rotas");
            try {
                Double total = Controller.Rota.AvgValor();
                Console.WriteLine("A media em valor de todas as rotas : R$" + total );
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        } 
        
    }
}