using SFML.Graphics;
using SFML.Window;
using SFML.System;
using System;


namespace Pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = new Scene();
            scene.loader.Load("maze");
            
            using (var window = new RenderWindow(
                       new VideoMode(828, 900), "Pacman"))
            {
                window.Closed += (o, e) => window.Close();
                //TODO: initialize
                Clock clock = new Clock();
                while (window.IsOpen)
                {
                    window.DispatchEvents();
                    float deltatime = clock.Restart().AsSeconds();
                    deltatime = MathF.Min(deltatime, 0.1f);
                    //Todo: updates
                    window.Clear(new Color(223, 246, 245));
                    //Todo: Drawing
                    window.Display();
                }
            }
        }
    }
}