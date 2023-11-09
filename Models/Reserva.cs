using System.Globalization;

namespace DesafioHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite {get; set;}
        public int DiasReservados {get; set;}

        public Reserva(){}
        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes){
            //Checa se passou da capacidade
            if (hospedes.Count <= Suite.Capacidade){
                Hospedes = hospedes;
            } else {
                throw new Exception($"A quantidade de hóspedes não pode exceder a capacidade da suíte que é de: {Suite.Capacidade} pessoa(s).");    
            }
        }
        public void CadastrarSuite(Suite suite){
            Suite = suite;
        }
        public int ObterQuantidadeHospedes(){
            return Hospedes.Count;
        }
        
        public string CalcularValorDiaria(){
            //Checa se existe desconto valido e aplica
            //Se reserva for a partir de 10 dias, ganha 10% desconto
            decimal desconto = (DiasReservados >= 10) ? .10M: 0;
            decimal valorTotal = (DiasReservados * Suite.ValorDiaria) * (1 - desconto);
            return valorTotal.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"));
        }
    }
}