using System;
namespace FigureFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine("'O' 'I' 'J' 'S'");
            choice = Console.ReadLine();
            IFigure create = ICreateFigure.CreateFigure(choice);
            create.Show();

        }
    }
}