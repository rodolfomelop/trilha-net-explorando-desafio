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
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
               throw new Exception("A suíte não tem capacidade para acomodar todos os hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
           
            decimal valor = Suite.ValorDiaria * DiasReservados;
            

            if (DiasReservados >= 10)
            {
               decimal desconto = valor * 0.1m;
                valor -= desconto;

            }

            return valor;
        }
    }
}