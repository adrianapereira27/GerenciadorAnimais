namespace GerenciadorAnimais
{
    internal abstract class Animais
    {
        public TipoAnimal TipoAnimal { get; set; }

        public abstract void DescreverAnimal();
        
    }
}
