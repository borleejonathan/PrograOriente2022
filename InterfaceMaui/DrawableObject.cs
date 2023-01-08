using System;
namespace Projet_2022
{
    public class DrawableObject
    {
        Color color;
        double x, y;
        int pv;
        int pe;
        string name;

        public DrawableObject(Color color, double x, double y, int pv, int pe, string name)
        {
            this.color = color;
            this.x = x;
            this.y = y;
            this.pv = pv;
            this.pe = pe;
            this.name = name;   
            
        }

        public Color Color { get { return this.color; } }
        public double X { get { return this.x; } set { this.x = value; } }
        public double Y { get { return this.y; } set { this.y = value; } }
        public int Pv { get { return this.pv; } set { this.pv = value;} }
        public int Pe { get { return this.pe; } set { this.pe = value; } }
        public string Name { get { return this.name; } set { this.name = value;} }
    }
}
