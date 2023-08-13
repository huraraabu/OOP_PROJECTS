using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class VerticalEnemy : GameEnemy
    {
        private GameDirection direction = GameDirection.Down;
        List<Bullet> bullets;
        public VerticalEnemy(Image ghostImage, GameCell startCell)
            : base(ghostImage)
        {
            base.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }

        public override void move(GameCell gameCell)
        {
            if (base.CurrentCell != null)
            {
                base.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            }

            base.CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {
            GameCell gameCell = base.CurrentCell;
            GameCell gameCell2 = base.CurrentCell.nextCell(direction);
            if (gameCell2 == gameCell)
            {
                if (direction == GameDirection.Up)
                {
                    direction = GameDirection.Down;
                }
                else if (direction == GameDirection.Down)
                {
                    direction = GameDirection.Up;
                }
            }
            else
            {
                gameCell = gameCell2;
            }

            return gameCell;
        }

        public void generateBullet()
        {
            Bullet bullet = new Bullet(ImageGiver.getVerticleEnemyBul(), this.CurrentCell.nextCell(GameDirection.Left));
            bullets.Add(bullet);
        }

        public bool moveBullets(GamePlayer player)
        {
          
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Left))
                {
                    removeBullet(bullets[i]);
                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Left));
                }
                if (i > 0)
                {
                    if (GameCollider.isBulletColide_WithPlayer(player, bullets[i]) == true)
                    {
                        removeBullet(bullets[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        public void removeBullet(Bullet bul)
        {
            GameCell currentCell = this.CurrentCell;
            bul.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            bullets.Remove(bul);
        }
    }
}
