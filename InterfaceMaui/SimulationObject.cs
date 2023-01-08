using System;
namespace Projet_2022
{
    public abstract class SimulationObject : DrawableObject
    {
        public SimulationObject(Color color, double x, double y, int pv, int pe, string name) : base(color, x, y, pv, pe, name) { }

        public abstract void Update();
    }
}
