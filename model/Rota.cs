using System;
using System.Collections.Generic;

namespace Model
{
    public class Rota
    {
        public int Id { get; set; }
        private int _origemId;
        public Cidade Origem { get; set; }
        private int _destinoId;
        public Cidade Destino { get; set; }
        private int _caminhaoId;
        public Caminhao Caminhao { get; set; }
        public DateTime Data { get; set; }

        public Double Valor  { get; set; }

        public static List<Rota> Rotas { get; set; } = new List<Rota>();

        public Rota(
            int id,
            Cidade origem,
            Cidade destino,
            Caminhao caminhao,
            DateTime data,
            Double valor
        )
        {
            Id = id;
            Origem = origem;
            _origemId = origem.Id;
            Destino = destino;
            _destinoId = destino.Id;
            Caminhao = caminhao;
            _caminhaoId = caminhao.Id;
            Data = data;
            Valor = valor;

            Rotas.Add(this);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Origem: {Origem}, Destino: {Destino}, Caminhão: {Caminhao}, Data: {Data}, Valor: {Valor}";
        }

        public static void AlterarRota(
            int id,
            Cidade origem,
            Cidade destino,
            Caminhao caminhao,
            DateTime data,
            Double valor
        )
        {
            Rota rota = BuscarRota(id);
            rota.Origem = origem;
            rota.Destino = destino;
            rota.Caminhao = caminhao;
            rota.Data = data;
            rota.Valor = valor;
        }

        public static void ExcluirRota(int id)
        {
            Rota rota = BuscarRota(id);
            Rotas.Remove(rota);
        }

        public static Rota BuscarRota(int id)
        {
            Rota? rota = Rotas.Find(r => r.Id == id);
            if (rota == null) {
                throw new Exception("Rota não encontrada");
            }

            return rota;
        }

        public static int ContaRotasPorCaminhao(int id){
            int count = Rotas.Count(r => r._caminhaoId == id);
            if (count == 0) {
                throw new Exception("Não foram encontradas rotas para esse caminhão");
            }
            return count;
        }

        public static Double TotalValorCaminhao(int id){
            List<Rota> rts = Rotas.FindAll(r => r._caminhaoId == id).ToList();
            if (rts.Count == 0) {
                throw new Exception("Não foram encontradas rotas para esse caminhão");
            }
            Double valor = 0.0d;

            foreach (var rt in rts)
                valor += rt.Valor;

            return valor;
        }
        
        public static Double AvgValor(){
          
            if (Rotas.Count == 0) {
                throw new Exception("Não existem rotas cadastradas");
            }
            Double valor = 0.0d;
            foreach (var rt in Rotas){
                valor += rt.Valor;
            }

            return valor / Rotas.Count;
        }
        


    }
}