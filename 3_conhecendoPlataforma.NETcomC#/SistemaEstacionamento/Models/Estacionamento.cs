namespace SistemaEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>(); //variavel tipo list
        
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            string placa = "";

            Console.WriteLine("Informe sua placa para estacionar: ");
            placa = Console.ReadLine();

            veiculos.Add(placa); //adicionando a placa na lista de veiculos
            Console.WriteLine("Placa cadastrada com sucesso");

        }


        public void RemoveVeiculo()
        {
           


        }


        public void ListarVeiculo()
        {

        }

    }
}