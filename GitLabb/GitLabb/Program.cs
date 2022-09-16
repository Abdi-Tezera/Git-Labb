var minbil = new Bil(4, "Toyota", "Privat", 5, "YAG494","svart",5);
var minbåt = new Båt("Segel", "Privat", "Ja", "Nej", 3);
//minbil.typ = "Toyota";
//minbil.antalfönster = 5;
//minbil.användningsområde = "Privat";
//minbil.antalhjul = 4;
//minbil.registreringsnummer = "YAG495";
//minbåt.typ = "Segel";
//minbåt.användningsområde = "Transport";
//minbåt.harUtombordsmotor = "Ja";
//minbåt.harHytt = "Nej";
//minbåt.antalKnop = 3;
Console.WriteLine($"Min bil är: \n" +
    $"Typ: {minbil.typ}\n" +
    $"Användningsområde: {minbil.användningsområde}\n" +
    $"Antalfönster: {minbil.antalfönster}\n" +
    $"Antalhjul: {minbil.antalhjul}\n" +
    $"Registreringsnummer: {minbil.registreringsnummer}\n"
    );
Console.WriteLine($"Min båt är: \n" +
    $"Typ: {minbåt.typ}\n" +
    $"Användningsområde: {minbåt.användningsområde}\n" +
    $"Har  utombordsmotor?: {minbåt.harUtombordsmotor}\n" +
    $"Har hytt?: {minbåt.harHytt}\n" +
    $"Antal knoppar: {minbåt.antalKnop}");



class Fordon
{
    public string typ; public string användningsområde;

}
class Bil : Fordon
{
    public int antalhjul;
    public int antalfönster;
    public string registreringsnummer;
    public string färg;
    public int ålder;
    public Bil(int antalhjul, string typ, string användningsområde, int antalfönster, string registreringsnummer, string färg, int ålder)
    {
        this.antalhjul = antalhjul;
        this.antalfönster = antalfönster;
        this.typ = typ;
        this.registreringsnummer = registreringsnummer;
        this.användningsområde = användningsområde;
        this.färg = färg;
        this.ålder = ålder;
    }

}
class Båt : Fordon
{

    public string harUtombordsmotor;
    public string harHytt;
    public int antalKnop;
    public Båt(string typ, string användningsområde, string harUtombordsmotor, string harHytt, int antalKnop)
    {
        this.typ = typ;
        this.användningsområde = användningsområde;
        this.harUtombordsmotor = harUtombordsmotor;
        this.harHytt = harHytt;
        this.antalKnop = antalKnop;
    }
}