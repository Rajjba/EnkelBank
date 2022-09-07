public class Kund {
    String förNamn {get; set; }
    String efterNamn;
    List<String> accountNumber;
    public String id;

    public Kund(String förNamn, String efterNamn, String id) {
        this.förNamn = förNamn;
        this.efterNamn = efterNamn;
        this.id = id;
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

        System.Console.Write("Välkommen till banken, vad vill du göra?"
        + "\n" + "1. skapa ny kund"
        + "\n" + "2. skapa nytt konto"
        + "\n" + "3. koppla kund till konto"
        + "\n" + "4. ändra saldo på konto"
        + "\n" + "5. antal kunder" 
        + "\n" + "6. totala bankens omsättning");

    }
}