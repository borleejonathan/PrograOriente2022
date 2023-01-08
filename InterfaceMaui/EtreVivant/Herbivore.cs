using System;
namespace Projet_2022
{
    public class Herbivore : SimulationObject
    {
        public Herbivore(double x, double y) : base(Colors.SkyBlue, x, y, 100, 10, "Herbivore") { }

        public override void Update()
        {
            // Déplacement
            Random rd = new Random();
            int random = rd.Next(1, 6);
            switch (random)
            {
                case 1:
                    X += 50;
                    break;
                case 2:
                    X -= 50;
                    break;
                case 3:
                    Y += 50;
                    break;
                case 4:
                    Y -= 50;
                    break;
                case 5:
                    Y = Y;
                    X = X;
                    break;
            }

            // Limite de la carte
            if (X >= 600)
            {
                X -= 50;
                Console.WriteLine("Oui");
            }
            if (X <= 0)
            {
                X += 50;
            }
            if (Y >= 400)
            {
                Y -= 50;
            }
            if (Y <= 0)
            {
                Y += 50;
            }

        }
       
    }
}
