namespace Churrasco_JoséRicardoDavid_LuizCarlosSianNeto
{
    class Insumos
    {
        // Valores Constantes
        public const double precoQueijo = 12.50;
        public const double precoPaoAlho = 7.50;
        public const double precoCarvao = 15.00;

        private int quantQueijo;
        private int quantPaoAlho;
        private int numSacosCarvao;



        public Insumos(int quantQueijo, int quantPaoAlho)
        {
            this.quantQueijo = quantQueijo;
            this.quantPaoAlho = quantPaoAlho;
        }

        public Insumos() // Construtor padrão.
        {
        }

        public int sacosCarvao()
        {
            Carne carne = new Carne();
            numSacosCarvao = ((int)carne.KgCarne) / 3;
            if (numSacosCarvao == 0)
            {
                numSacosCarvao = 1; //pelo menos um carvao deverá ser vendido se o cliente assim quiser.
            }
            return numSacosCarvao;
        }

        public double totalInsumos()
        {
            return precoQueijo * quantQueijo + precoPaoAlho * quantPaoAlho + numSacosCarvao * precoCarvao;
        }
    }
}

