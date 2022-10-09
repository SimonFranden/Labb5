namespace Labb5
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new(5);
            Circle circle2 = new(6);

            Console.WriteLine("Arean av första cirkeln är " + circle1.GetArea());
            Console.WriteLine("Arean av andra cirkeln är " + circle2.GetArea());
        }
    }

    class Circle
    {
        int Radius;
        static float pi = 3.141f;
        public Circle (int Radius)
        {
            this.Radius = Radius;
        }

        public float GetArea()
        {
            float area = Radius * Radius * pi;
            return area;
        }
        
    }
}