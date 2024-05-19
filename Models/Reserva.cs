using System.Diagnostics;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            try
            {
                if (hospedes != null && hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    throw new Exception($"A capacidade da suite {Suite.TipoSuite} não é suficiente para receber {hospedes.Count} hóspedes. Capacidade máxima: {Suite.Capacidade}.");
                }
            }
            catch (Exception ex)
            {
                // Capture a exceção e trate-a de acordo com suas necessidades
                Console.WriteLine($"Erro: {ex.Message}");  // Exemplo de tratamento básico
            }

        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            bool Decena = DiasReservados >= 10;
            Decimal desconto = (Decena ? (valor = (DiasReservados * Suite.ValorDiaria) * 0.9M) : valor = (DiasReservados * Suite.ValorDiaria));
            return valor;

        }
    }
}