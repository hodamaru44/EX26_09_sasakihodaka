using System;


namespace EX._26
{
    class Program
    {
       
        static void Main(string[] args)
        {
            float Length = GetValue("幅を決めてください");
            float Height = GetValue("高さを決めてください");
            Triangul triangul1 = new Triangul(Length, Height);
            Console.WriteLine($"体積は{triangul1.GetSurface()}");
        }
        static float GetValue(string nema)
        {
            float value;
            Console.Write(nema+":") ;
            value = float.Parse(Console.ReadLine());
            return value;
        }
    }
}

class Triangul
{
    float Length;
    float Height;

    public Triangul(float l,float h)
    {
       this.Length = l;
       this.Height = h;
    }

   public float GetSurface()
    {
        return (Length*Height/2);
    }

}
