namespace Principal
{
    class Carne
    {
        public double kgCarne, precoCarne;
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

        

        public double totalCarne ()        
        {
            double teste = kgCarne * precoCarne + kgFrango * precoFrango + kgLinguica * precoLinguica;
            return kgCarne * precoCarne + kgFrango * precoFrango + kgLinguica * precoLinguica;
        }

        public double kilosCarne ()
        {
             double teste = kgCarne * kgFrango * kgLinguica;
            return teste;
        }
    }
}
