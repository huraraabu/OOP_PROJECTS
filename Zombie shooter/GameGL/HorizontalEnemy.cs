using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Game.GameGL
{
    internal class HorizontalEnemy : GameEnemy
    {
        GameDirection direction = GameDirection.Left;
        List<Bullet> bullets;
        public HorizontalEnemy(Image ghostImage, GameCell startCell) : base(ghostImage)
        {
            this.CurrentCell = startCell;
            bullets = new List<Bullet>();
        }
        public void generateBullet()
        {
            Bullet bullet = new Bullet(ImageGiver.getVerticleEnemyBullet(), this.CurrentCell.nextCell(GameDirection.Left));
            bullets.Add(bullet);
        }
        public bool moveBullet(GamePlayer player)
        {
            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i].CurrentCell == bullets[i].CurrentCell.nextCell(GameDirection.Down))
                {


                    removeBullet(bullets[i]);
                  
                }
                else
                {
                    bullets[i].move(bullets[i].nextCell(GameDirection.Down));
                }
                if (i > 0)
                {
                    if (GameCollider.isBulletColide_WithPlayer(player, bullets[i]) == true)
                    {
                        return true;
                    }
                }
               
            }
            return false;
        }
        public void removeBullet(Bullet bul)
        {
            bullets.Remove(bul);
            GameCell currentCell = this.CurrentCell;
            bul.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            bullets.Remove(bul);
        }
        public override void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }

        public override GameCell nextCell()
        {

            GameCell nextCell = this.CurrentCell;

            GameCell potentialNextCell = this.CurrentCell.nextCell(direction);

            if (potentialNextCell == nextCell)
            {
                if (direction == GameDirection.Left)
                {
                    direction = GameDirection.Right;
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Left;
                }
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;

        }
    }
}
