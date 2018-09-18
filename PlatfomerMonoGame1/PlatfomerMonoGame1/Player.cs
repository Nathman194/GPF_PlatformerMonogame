using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PlatfomerMonoGame1
{
    class Player
    {
        Sprite playerSprit = new Sprite();

        public Player()
        {

        }

        public void Load(ContentManager content)
        {
            playerSprit.Load(content, "hero");
        }

        public void Update(float deltaTime)
        {
            playerSprit.update(deltaTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerSprit.draw(spriteBatch);
        }
    }
}
