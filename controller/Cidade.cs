namespace Controller
{
    public class Cidade
    {
        public static void CadastrarCidade(string id, string nome)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("IdCidade inválido");
            }
            Model.Cidade cidade = new Model.Cidade(idConvert, nome);
        }

        public static void AlterarCidade(string id, string nome)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("IdCidade inválido");
            }
            
            Model.Cidade.AlterarCidade(idConvert, nome);
        }

        public static void ExcluirCidade(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("IdCidade inválido");
            }
            
            Model.Cidade.ExcluirCidade(idConvert);
        }

        public static Model.Cidade BuscarCidade(string id)
        {
            int idConvert = 0;
            try {
                idConvert = int.Parse(id);
            } catch (Exception) {
                throw new Exception("IdCidade inválido");
            }
            
            return Model.Cidade.BuscarCidade(idConvert);
        }

        public static List<Model.Cidade> ListarCidades()
        {
            return Model.Cidade.Cidades;
        }
    }
}