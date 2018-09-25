using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PlatfomerMonoGame1
{
    class Player
    {
        public Sprite playerSprit = new Sprite();

        Game1 game = null;
        float runSpeed = 15000f;

        public Player()
        {

        }

        public void Load(ContentManager content, Game1 theGame)
        {
            playerSprit.Load(content, "hero");
            game = theGame;
            playerSprit.velocity = Vector2.Zero;
            playerSprit.position = new Vector2(theGame.GraphicsDevice.Viewport.Width / 2, 0);
        }

        public void Update(float deltaTime)
        {
            UpdateInput(deltaTime);
            playerSprit.update(deltaTime);
            playerSprit.UpdateHitBox();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerSprit.draw(spriteBatch);
        }

        private void UpdateInput(float deltaTime)
        {
            Vector2 localAcceleration = new Vector2(0, 0);

            if (Keyboard.GetState().IsKeyDown(Keys.A) == true)
            {
                localAcceleration.X = -runSpeed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D) == true)
            {
                localAcceleration.X = runSpeed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.W) == true)
            {
                localAcceleration.Y = -runSpeed;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S) == true)
            {
                localAcceleration.Y = runSpeed;
            }

            playerSprit.velocity = localAcceleration * deltaTime;
            playerSprit.position += playerSprit.velocity * deltaTime;
        }
    }
}
