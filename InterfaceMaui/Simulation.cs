using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Projet_2022
{
    public class Simulation : IDrawable
    {
        List<SimulationObject> objects;
 
        public Simulation()
        {

            objects = new List<SimulationObject>();

            objects.Add(new Carnivore(100, 100));
            objects.Add(new Plante(50, 100));
            objects.Add(new Herbivore(150, 150));
            objects.Add(new Viande(250, 50));
            objects.Add(new DechetOrganique(350, 250));

            


        }
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            foreach (SimulationObject drawable in objects)
            {              
                canvas.FillColor = drawable.Color;
                canvas.FillCircle(new Point(drawable.X, drawable.Y), 10.0);
               
            }
        }
        public void Update()
        {
            foreach (SimulationObject drawable in objects)
            {
                //Perte d'énergie et récupération
                drawable.Pe --;
                if (drawable.Pe <= 0)
                {
                    Console.WriteLine(drawable.Name + " s'épuise");
                    drawable.Pv -= 10;
                    drawable.Pe += 10;                   
                }

                //Mort
                if (drawable.Pv <= 0)
                {
                    Console.WriteLine(drawable.Name + " est mort");
                }

                drawable.Update();        
            }
        }
        
        
    }    
}
