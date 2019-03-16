namespace Churrasco_JoséRicardoDavid_LuizCarlosSianNeto
{
    class Bebidas
    {
        private int quantCerveja;
        private int quantRefri;
        private double precoCerveja;
        private double precoRefri;

        public Bebidas(int quantCerveja, int quantRefri) //construtor da classe
        {
            this.quantCerveja = quantCerveja;
            this.quantRefri = quantRefri;
        }

        public Bebidas(double precoCerveja, double precoRefri) //construtor da classe
        {
            this.precoCerveja = precoCerveja;
            this.precoRefri = precoRefri;
        }

        public double totalBebidas()
        {
            return quantCerveja * precoCerveja + quantRefri * precoRefri;
        }
    }
}
