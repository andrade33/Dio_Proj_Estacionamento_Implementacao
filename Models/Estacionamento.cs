namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0.00M;
        private decimal precoPorHora = 0.00M;
        private List<string> veiculos {get; set;}= new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {

            // Lendo a placa e adicionando ao estacionamento
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Bem-vindo ao nosso estacionamento!");

        }

        public void RemoverVeiculo()
        {
            // lendo a placa pra efetuar calculos e remoção
            string placa = "";
            Console.WriteLine("Digite a placa do veículo para remover:");
            placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Digitando a quantidade de horas e fazendo o calculo;
                int horas = 0;
                horas = int.Parse(Console.ReadLine());
                decimal valorTotal = 0.00M; 
                valorTotal = precoInicial + precoPorHora * horas;
        
                //Após calculo, removendo o veiculo;
                veiculos.Remove(placa);
               
                //Imprimindo o recibo;
                Console.WriteLine($"O veículo {placa} foi removido!");
                Console.WriteLine($"Preço inicial: {precoInicial:C}");
                Console.WriteLine($"Preço por hora: {precoPorHora:C}");
                Console.WriteLine($"A quantidade de horas :{horas} hs");
                Console.WriteLine($"Preço total foi de: R$ {valorTotal:C}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
             
                //Implementando a listagem dos veiculos do estacionamento.
                foreach (String veic in veiculos)
                {
                    Console.Write($"{veic}, ");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
