namespace GitHubIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regular2DShape icosagon = new Icosagon(10);
            Console.WriteLine(icosagon.GetArea());
        }
    }
}