namespace TaxiCALC.Data
{
    public enum vognType
    {
        Almindelig,
        AlmindeligAften,
        Stor,
        StorSpecial
    }

    public class TaxiData
    {
        

        public vognType ?vognNavn;

        public decimal startPris;

        public double Kilometerpris;

        public double minutPris;

        internal decimal TotalPris;
    }

    public class CustomerChoices
    {
        public bool TransportAfCykel { get; set; }
        public bool Opbaering { get; set; }
        public bool HjaelpTilOpbaering { get; set; }
        public bool Lufthavn { get; set; }
        public bool AfhentningILufthavn { get; set; }
        public bool FemPersonerEllerOver { get; set; }
        public bool Liftvogn { get; set; }
        public bool Oeresundsbro { get; set; }
        public bool Storebaeltsbroen { get; set; }
        public decimal DistanceInKm { get; set; }
    }
}