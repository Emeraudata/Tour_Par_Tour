namespace Tour_Par_Tour
{
    public class Ennemi
    {
        public int NombrePV { get; private set; }

        public Ennemi()
        {
            NombrePV = 10;
        }

        public void PertePV(int pvPerdus)
        {
            if(NombrePV > 0)
                NombrePV -= pvPerdus;
        }
    }
}
