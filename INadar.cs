namespace GerenciadorAnimais
{
    internal interface INadar
    {
        public int LimiteProfundidade { get; set; }
        public int Metros { get; set; }

        public void Subir(int metros);
        public void Descer(int limiteProfundidade, int metros);

    }
}
