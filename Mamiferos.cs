namespace GerenciadorAnimais
{
    internal class Mamiferos : Animais, INadar, IVoar
    {
        public int LimiteProfundidade { get; set; }
        public int Metros { get; set; }
        public bool PodeNadar {  get; set; }
        public bool PodeVoar {  get; set; }

        public Mamiferos(bool podeNadar, bool podeVoar)
        {            
            PodeNadar = podeNadar;
            PodeVoar = podeVoar;
        }

        public override void DescreverAnimal()
        {
            Console.WriteLine("Mamiferos são animais que podem nadar ou voar");
        }

        public void Descer(int limiteProfundidade, int metros)
        {
            if (PodeNadar)
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
            else
            {
                Console.WriteLine("Não pode nadar!");
            }            
        }

        public void Subir(int metros)
        {
            if (PodeNadar)
            {
                Console.WriteLine($"Subiu até {metros} metros.");
            }
            else
            {
                Console.WriteLine("Não pode nadar!");
            }
        }

        public void LevantarVoo()
        {
            if (PodeVoar)
            {
                Console.WriteLine("Levantou voo.");
            }
            else
            {
                Console.WriteLine("Não pode voar!");
            }            
        }

        public void Pousar()
        {
            if (PodeVoar)
            {
                Console.WriteLine("Pousou.");
            }
            else
            {
                Console.WriteLine("Não pode voar!");
            }
        }

    }
}
