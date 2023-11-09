using System.Text;
using DesafioHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

//Cria modelos de hospedes e cadastra na lista
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa ("Afonso", "Queiroga");
Pessoa p2 = new Pessoa ("Rafaela", "Souza");

hospedes.Add(p1);
hospedes.Add(p2);

//Cria suite
Suite suite = new Suite("Premium", 3, 30);

//Cria uma nova reserva
Reserva reserva = new Reserva(10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a quantidade de hospedes e valor diaria
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");