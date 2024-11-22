using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyDemoEnemy
{
    internal class MyWorld : World
    {
        private Crab my_crab;
        public MyWorld() : base(800, 600)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand2";

            my_crab = new Crab();
            Add(my_crab, "crab2", 400, 300); 
            Add(new Lobster(my_crab), "lobster", 100, 100);
            
        }  

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (my_crab.IsDead)
            {
                MyWorld world = new MyWorld();
                EasyGame.Instance.ActiveWorld = world;
            }

        }
    }
}
