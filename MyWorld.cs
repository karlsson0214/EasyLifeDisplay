using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyDemoEnemyLife
{
    internal class MyWorld : World
    {
        private Crab my_crab;
        public MyWorld(int lifes) : base(800, 600)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "sand2";

            List<Life> lifeList = new List<Life>();
            for (int i = 0; i < lifes; i++)
            {
                Life life = new Life();
                lifeList.Add(life);
                Add(life, "herz", 50 + i * 60, 50);
            }


            my_crab = new Crab(lifeList);
            Add(my_crab, "crab2", 400, 300); 
            Add(new Lobster(my_crab), "lobster", 170, 100);

            

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (my_crab.IsDead)
            {
                //MyWorld world = new MyWorld(3);
                //EasyGame.Instance.ActiveWorld = world;
            }

        }
    }
}
