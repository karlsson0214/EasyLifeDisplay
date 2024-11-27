using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace EasyLifeDisplay
{
    internal class Crab : Actor
    {
        private bool isDead = false;
        private LifeDisplay lifeDisplay;


        public Crab(LifeDisplay lifeDisplay)
        {
            this.lifeDisplay = lifeDisplay;

        }

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
                
                lifeDisplay.RemoveLife();
                if (lifeDisplay.Lives <= 0)
                {
                    World.ShowText("Game Over", 400, 300);
                    isDead = true;
                    EasyGame.Instance.IsPaused = true;
                }
                else
                {
                    
                    EasyGame.Instance.ActiveWorld = new MyWorld(lifeDisplay.Lives);
                }
                
                
            }
        }
    }
}
