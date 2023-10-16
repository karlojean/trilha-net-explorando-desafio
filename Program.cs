using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Person> guests = new List<Person>();

Person g1 = new Person(name: "Hóspede 1");
Person g2 = new Person(name: "Hóspede 2");

guests.Add(g1);
guests.Add(g2);

// Cria a suíte
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyValue: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reservation reserva = new Reservation(reservedDays: 10);
reserva.RegisterSuites(suite);
reserva.RegisterGuests(guests);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.GetGuestQuantity()}");
Console.WriteLine($"Valor diária: {reserva.CalculateDailyValue():C}");