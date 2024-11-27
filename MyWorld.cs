using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyLifeDisplay
{
    internal class MyWorld : World
    {
        private Crab my_crab;
        public MyWorld(int lives) : base(800, 600)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand2";

            LifeDisplay lifeDisplay = new LifeDisplay(this, 40, 40);
            for (int i = 0; i < lives; i++)
            {
                lifeDisplay.AddLife();
            }

            my_crab = new Crab(lifeDisplay);
            Add(my_crab, "crab2", 400, 300); 
            Add(new Lobster(my_crab), "lobster", 170, 100);
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }
    }
}
