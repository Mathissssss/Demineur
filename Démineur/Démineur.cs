using System;

namespace Démineur
{
    public class Démineur
    {
        private int nbBombs;
        private int discovered;
        private int bombsleft;
        
        private readonly int size = 16;

        public int NbBombs => nbBombs;

        public Démineur(int nbBombs)
        {
            this.nbBombs = nbBombs;
            this.discovered = 0;
            this.bombsleft = nbBombs;
        }

        public Fill(Démineur démineur)
        {
            Random rnd = new Random();
            
        }
    }
}