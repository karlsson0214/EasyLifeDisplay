using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace EasyDemoEnemy
{
    internal class Crab : Actor
    {
        private bool isDead = false;

        public bool IsDead 
        { 
            get 
            { 
                return isDead; 
            } 
        }
        public override void Update(GameTime gameTime)
        {
            if (isDead)
            {
                return;
            }
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            KeyboardState keyboard = Keyboard.GetState();
            if ( keyboard.IsKeyDown(Keys.Left))
            {
                Turn(deltaTime * 180);
            }
            else if (keyboard.IsKeyDown(Keys.Right))
            {
                Turn(deltaTime * -180);
            }
            if (keyboard.IsKeyDown(Keys.Up))
            {
                Move(500 * deltaTime);
            }


            if (IsTouching(typeof(Lobster)))
            {
                World.ShowText("Game Over", 400, 300);
                isDead = true;
            }
        }
    }
}
