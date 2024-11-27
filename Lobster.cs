using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;

namespace EasyLifeDisplay
{
    internal class Lobster : Actor
    {
        private Crab crab;

        public Lobster(Crab crab)
        {
            this.crab = crab;
        }
        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

            TurnTowards(crab.X, crab.Y);
            Move(200 * deltaTime);


        }
    }
}