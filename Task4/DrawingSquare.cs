using System;


namespace Task4
{
    internal class DrawingSquare
    {
        public void Draw()
        {
            Prepare();
            DrawCore();
        }

        protected virtual void Prepare()
        {
            Console.WriteLine("Preparing Square");
        }

        protected virtual void DrawCore()
        {
            Console.WriteLine("Drawing");
        }
    }

}
