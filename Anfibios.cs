namespace GerenciadorAnimais
{
    internal class Anfibios : Animais, INadar
    {
        public int LimiteProfundidade { get; set; }
        public int Metros { get; set; }

        public override void DescreverAnimal()
        {
            Console.WriteLine("Anfibios são animais que podem nadar");
        }
        public void Descer(int limiteProfundidade, int metros)
        {
            if (limiteProfundidade < metros)
            {
                Console.WriteLine("Não é possível descer.");
            }
            else
            {
                Console.WriteLine($"Desceu até {metros} metros.");
            }

        } 
        public void Subir(int metros)
        {
            Console.WriteLine($"Subiu até {metros} metros.");
        }
    }
}
