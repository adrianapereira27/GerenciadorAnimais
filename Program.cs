using GerenciadorAnimais;
using System;

class Program
{
    static void Main(string[] args)
    {
        Anfibios anfibio = new Anfibios();
        var metrosAnfibio = anfibio.Metros = 12;
        var limiteAnfibio = anfibio.LimiteProfundidade = 10;
        anfibio.DescreverAnimal();
        anfibio.Descer(limiteAnfibio, metrosAnfibio);


        Mamiferos mamifero = new Mamiferos(true, false);        
        var metrosMamiferoDescer = mamifero.Metros = 5;
        var limiteMamifero = mamifero.LimiteProfundidade = 10;
        mamifero.DescreverAnimal();
        mamifero.Descer(limiteMamifero, metrosMamiferoDescer);
        var metrosMamiferoSubir = mamifero.Metros = 7;
        mamifero.Subir(metrosMamiferoSubir);

        Mamiferos mamifero2 = new Mamiferos(false, true);
        mamifero2.DescreverAnimal();
        var metrosMamifero2Descer = mamifero.Metros = 5;
        var limiteMamifero2 = mamifero2.LimiteProfundidade = 10;        
        mamifero2.Descer(limiteMamifero2, metrosMamifero2Descer);        
        var metrosMamifero2Subir = mamifero2.Metros = 7;
        mamifero2.Subir(metrosMamifero2Subir);

        mamifero2.LevantarVoo();
        mamifero2.Pousar();

        Console.ReadLine();
    }
}

