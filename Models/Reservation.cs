namespace DesafioProjetoHospedagem.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            if (Suite.Capacity >= guests.Count)
            {
                Guests = guests;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*
                throw new Exception("Suite não suporta a quantidade de hospedes.");
            }
        }

        public void RegisterSuites(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestQuantity()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal value = ReservedDays * Suite.DailyValue;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (ReservedDays >= 10)
            {
                return value - (value * 0.10M);
            }

            return value;
        }
    }
}