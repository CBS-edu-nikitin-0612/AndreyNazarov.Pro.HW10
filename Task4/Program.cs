using System;
using System.Transactions;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingSquare drawingSquare = new DrawingSquare();
            DrawingSphere drawingSphere = new DrawingSphere();

            drawingSphere.Draw();
            Console.WriteLine();
            drawingSquare.Draw();
        }
    }

}
