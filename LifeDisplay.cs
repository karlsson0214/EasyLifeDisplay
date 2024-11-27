using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using EasyMonoGame;

namespace EasyLifeDisplay
{
    internal class LifeDisplay
    {
        private int lives = 0;
        private World world;
        private float x;
        private float y;

        public LifeDisplay(World world, float x, float y)
        {
            this.world = world;
            this.x = x;
            this.y = y;
        }
        public int Lives
        {
            get
            {
                return lives;
            }
        }
        public void AddLife()
        {      
            world.Add(new Life(), "herz", x + lives * 60, y);
            lives += 1;
        }
        public void RemoveLife()
        {
            lives -= 1;
            List<Actor> lifeList = world.GetActors(typeof(Life));
            if (lifeList.Count > 0)
            {
                var life = lifeList[lifeList.Count - 1];
                world.RemoveActor(life);
            }
        }

    }
}
