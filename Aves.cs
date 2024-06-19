namespace GerenciadorAnimais
{
    internal class Aves : Animais, IVoar
    {
        public override void DescreverAnimal()
        {
            Console.WriteLine("Aves são animais que podem voar");
        }
        public void LevantarVoo()
        {
            Console.WriteLine("Levantou voo.");
        }

        public void Pousar()
        {
            Console.WriteLine("Pousou.");
        }
    }
}
