
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
            public vognType SelectedVognType { get; set; }
            public bool TransportAfCykel { get; set; }
            public bool Opbaering { get; set; }
            public bool HjaelpTilOpbaering { get; set; }
            public bool Lufthavn { get; set; }
            public bool AfhentningILufthavn { get; set; }
            public bool FemPersonerEllerOver { get; set; }
            public bool Liftvogn { get; set; }
            public bool Oeresundsbro { get; set; }
            public bool Storebaeltsbroen { get; set; }
            public int EstimatedTime { get; set; }
            public decimal DistanceInKm { get; set; }

            public decimal? TotalPris { get; set; }

            // Additional fee amounts
            public decimal CykelTillaeg { get; set; } = 30.00m;
            public decimal OpbaeringTillaeg { get; set; } = 30.00m;
            public decimal LufthavnTillaeg { get; set; } = 15.00m;
            public decimal FemPersonerEllerOverTillaeg { get; set; } = 40.00m;
            public decimal LiftvognTillaeg { get; set; } = 350.00m;
            public decimal OeresundsbroTillaeg { get; set; } = 350.00m;
            public decimal StorebaeltsbroenTillaeg { get; set; } = 540.00m;
        }
    


}