using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace PlatfomerMonoGame1
{
    public class Sprite
    {
        public Vector2 position = Vector2.Zero;
        public Vector2 velocity = Vector2.Zero;
        public Vector2 offset = Vector2.Zero;

        Texture2D texture;

        public int width = 0;
        public int hight = 0;

        //the edge of the spright, also the eges of the hit boxfow collistions
        public int leftEdge = 0;
        public int rightEdge = 0;
        public int topEdge = 0;
        public int bottomEdge = 0;

        public Sprite()
        {

        }

        public void Load(ContentManager content, string asset)
        {
            texture = content.Load<Texture2D>(asset);
            width = texture.Bounds.Width;
            hight = texture.Bounds.Width;
            UpdateHitBox();
        }

        public void UpdateHitBox()
        {
            leftEdge = (int)position.X;
            rightEdge = (int)position.X + width;
            topEdge = (int)position.Y;
            bottomEdge = (int)position.Y + hight;
        }

        public void update(float deltatime)
        {

        }

        public void draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position + offset, Color.White);
        }
    }
}
