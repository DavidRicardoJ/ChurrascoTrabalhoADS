namespace Churrasco_JoséRicardoDavid_LuizCarlosSianNeto
{
    class Carne
    {
        private double kgCarne, precoCarne;
        private double kgFrango, precoFrango;
        private double kgLinguica, precoLinguica;


        // Construtor
        public Carne(double kgCarne, double precoCarne, double kgFrango, double precoFrango, double kgLinguica, double precoLinguica)
        {
            this.kgCarne = kgCarne;
            this.precoCarne = precoCarne;
            this.kgFrango = kgFrango;
            this.precoFrango = precoFrango;
            this.kgLinguica = kgLinguica;
            this.precoLinguica = precoLinguica;
        }

        public Carne() //construtor padrão
        {
        }

        public double KgCarne { get => kgCarne; set => kgCarne = value; }

        public double totalCarne()
        {
            return kgCarne * precoCarne + kgFrango * precoFrango + kgLinguica * precoLinguica;
        }
    }
}
