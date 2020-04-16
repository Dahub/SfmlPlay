using KassB.Core;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

namespace KassB.Main
{
    class Program
    {
        private const int _windowsWidth = 800;
        private const int _windowsHeight = 600;

        static void Main()
        {
            var party = new Party();
            var scaleFactorX = (float)_windowsWidth / party.PlayGround.Width;
            var scaleFactorY = (float)_windowsHeight / party.PlayGround.Height;

            using (var window = new RenderWindow(new VideoMode(_windowsWidth, _windowsHeight)," KassB"))
            {
                window.Closed += (s, e) => window.Close();

                var ball = new CircleShape(party.Ball.Radius * scaleFactorX);

                ball.Position = new Vector2f(party.Ball.PositionX * scaleFactorX, party.Ball.PositionY * scaleFactorY);
                ball.FillColor = Color.Red;

                while (window.IsOpen)
                {
                    window.DispatchEvents();
                    window.Clear();
                    window.Draw(ball);
                    window.Display();
                }
            }
        }
    }
}
