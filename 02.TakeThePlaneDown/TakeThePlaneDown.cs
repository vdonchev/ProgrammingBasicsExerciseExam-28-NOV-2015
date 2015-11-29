namespace _02.TakeThePlaneDown
{
    using System;

    public static class TakeThePlaneDown
    {
        public static void Main()
        {
            var baseX = int.Parse(Console.ReadLine());
            var baseY = int.Parse(Console.ReadLine());
            var baseRadius = int.Parse(Console.ReadLine());
            var numOfPlanes = int.Parse(Console.ReadLine());

            int planeX;
            int planeY;
            for (var i = 0; i < numOfPlanes; i++)
            {
                planeX = int.Parse(Console.ReadLine());
                planeY = int.Parse(Console.ReadLine());

                if ((Math.Pow(planeX - baseX, 2) + Math.Pow(planeY - baseY, 2)) 
                    < baseRadius * baseRadius)
                {
                    Console.WriteLine($"You destroyed a plane at [{planeX},{planeY}]");
                }
            }
        }
    }
}
