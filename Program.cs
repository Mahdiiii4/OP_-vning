using OP;

IKörbar f1 = new Bil("Nintendo", "PlaystationX");
Cykel f2 = new Cykel("Speedtree");
Spel doom = new Doom();

List<IKörbar> körbarLista = new List<IKörbar>();

körbarLista.Add(doom);
körbarLista.Add(f1);
körbarLista.Add(f2);


foreach(var körbar in körbarLista)
{
    körbar.Kör();
}

Fordon f = new Cykel("");
