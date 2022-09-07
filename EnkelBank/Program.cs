public class Kund {
    String förNamn {get; set; }
    String efterNamn;
    String personNummer;
    String kontoNummer;

    public Kund(String förNamn, String efterNamn, String personNummer, String kontoNummer) {
        this.förNamn = förNamn;
        this.efterNamn = efterNamn;
        this.personNummer = personNummer;
        this.kontoNummer = kontoNummer;
    }
}

public class Konto {
    String ägare;
    double saldo;
    int senasteTransaktionen;

    public Konto(String ägare, double saldo, int senasteTransaktionen) {
        this.ägare = ägare;
        this.saldo = saldo;
        this.senasteTransaktionen = senasteTransaktionen;
    }
}

public class Bank {
    List<Kund> kunder;
    List<Konto> konton;

    public Bank() {
        List<Kund> kunder = new List<Kund>();
        List<Konto> konton = new List<Konto>(); 
    }
}

static class Program{
    static void Main() {
        string förNamn;
        System.Console.Write("Välkommen till banken, vad vill du göra?"
        + "\n" + "1. skapa ny kund"
        + "\n" + "2. skapa nytt konto"
        + "\n" + "3. koppla kund till konto"
        + "\n" + "4. ändra saldo på konto"
        + "\n" + "5. antal kunder" 
        + "\n" + "6. totala bankens omsättning"
        + "\n");
        switch(Console.ReadLine())
        {
            case "1":
                Console.Clear();
                Console.WriteLine("ange ditt namn: ");
                förNamn = Console.ReadLine();

                Kund kund = new Kund(förNamn)
                
        }

    }
}