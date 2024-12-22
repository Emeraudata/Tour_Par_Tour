namespace Tour_Par_Tour.Etats
{
    public class EnnemiEtat : Etat
    {
        public Ennemi Ennemi { get; private set; }
        public int PointsActions { get; private set; }

        public EnnemiEtat()
        {
            PointsActions = 3;
            SetNom("LeGrandMéchant");
        }

        public override void Attaque()
        {
            for (int i = 0; i < PointsActions; i++)
            {
                Console.WriteLine($"{Nom} attaque le joueur");
            }
        }

        public override void DebutTour()
        {
            Console.WriteLine("Début du tour de l'ennemi.");
            Attaque();
            Console.WriteLine("Fin des attaques de l'ennemi");
        }

        public override void FinDeTour()
        {
            Console.WriteLine("Fin du tour de l'ennemi.");
            this.TurnManager.Transition(new PlayerEtat());
        }

        public override void PertePV()
        {
            throw new NotImplementedException();
        }
    }
}
