namespace TaxiCALC.Data
{

    public enum vognType //ensure only valid choices.
    {
        Almindelig,
        AlmindeligAften,
        Stor,
        StorSpecial
    }

    public class TaxiData //vogntype should change the startpris etc.
    {
        public float kilometer;
public float minutTid;

        public vognType ?vognNavn;

        public decimal startPris;

        public decimal Kilometerpris;

        public decimal minutPris;

        internal decimal TotalPris;

         //Taxi's will only calculate per minute, therefore user should only give whole numbers. (Userinput could have exception catching for this.)

        public TaxiData(vognType VognNavn, decimal InputPris, decimal INkilometerpris, decimal INminutPris) //parameters is input slots
        {
            vognNavn = VognNavn; //the inputted values gets fitted into their respective slots
            startPris = InputPris;
            Kilometerpris = INkilometerpris;
            minutPris = INminutPris;
            //this constructor will activate when a new taxidata is instatiatied.
        }
    }

    public class CustomerChoices
    {
        public bool TransportAfCykel { get; set; }
        public bool HjaelpTilOpbaering { get; set; }
        public bool Lufthavn { get; set; }
        public bool FemPersonerEllerOver { get; set; }
        public bool Liftvogn { get; set; }
        public bool Oeresundsbro { get; set; }
        public bool Storebaeltsbroen { get; set; }
        public decimal DistanceInKm { get; set; }
    }

    public class TaxiFareCalculator
    {
        public decimal CalculateFare(CustomerChoices choices) //Takes in customerchoices bool and returns the sum of all the 'true' cases
        {
            decimal AddonFare = 0;
            if (choices.TransportAfCykel)
            {
                AddonFare += 30.00m;
            }

            if (choices.HjaelpTilOpbaering)
            {
                AddonFare += 30.00m;
            }

            if (choices.Lufthavn)
            {
                AddonFare += 15.00m;
            }

            if (choices.FemPersonerEllerOver)
            {
                AddonFare += 40.00m;
            }

            if (choices.Liftvogn)
            {
                AddonFare += 350.00m;
            }

            if (choices.Oeresundsbro)
            {
                AddonFare += 350.00m;
            }

            if (choices.Storebaeltsbroen)
            {
                AddonFare += 540.00m;
            }


            return AddonFare;
        }

    }
}