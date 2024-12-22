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
            Ennemi = GameManager.Instance.Ennemi;
        }

        public override void Attaque()
        {
            for (int i = 0; i < PointsActions; i++)
            {
                Console.WriteLine($"{Nom} attaque le joueur");
                GameManager.Instance.JoueurEtat.PertePV();
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
            this.TurnManager.SetAnnemiAJoue();
            this.TurnManager.Transition(GameManager.Instance.JoueurEtat);
        }

        public override void PertePV()
        {
            Ennemi.PertePV(1);
            Console.WriteLine($"Il reste {Ennemi.NombrePV}PV après l'attaque de {GameManager.Instance.JoueurEtat.Nom}");
        }
    }
}
