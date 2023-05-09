
namespace Piramide{
    public static class Piramide {

        public static int Piani(int mattoni)
        {
            int piani = 0;
            while(mattoni >= (2 * piani +1) *  (2 * piani +1))
            {
                piani++;
                mattoni = mattoni - (2 * piani - 1) * (2 * piani - 1);
            }
            return piani;
        }
        public static int Rimanenti( int mattoni )
        {
            int piani = Piani(mattoni);
            int usati = 0;
            for (int i = 1; i <= piani; i++) 
            {
                usati += (2 * i - 1) * (2 * i - 1);
            }
            int Rimanenti = mattoni - usati;
            return Rimanenti;
        }

        

    }
}