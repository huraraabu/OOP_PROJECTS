using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game.GameGL
{
    class SmartEnemy:GameEnemy
    {
        GameDirection direction = GameDirection.Left;

        List<Bullet> bullets;
        List<Bullet> Leftbullets;
        List<Bullet> Upbullets;
        List<Bullet> Downbullets;


        public  char EnemyDirection;

        public SmartEnemy(Image enemyImage,GameCell startCell) :base(enemyImage)
        {
            this.CurrentCell = startCell;
            bullets = new List<Bullet>();
            Leftbullets = new List<Bullet>();
            Upbullets = new List<Bullet>();
            Downbullets = new List<Bullet>();
        }

        public bool isRightBulletCollideWithPlayer(GamePlayer player)
        {
            foreach (Bullet bul in bullets)
            {
                
                    if (GameCollider.isBulletColide_WithPlayer(player,bul) == true)
                    {
                        removeBullet(bul,'R');
                        return true;
                    }
                
            }
            return false;
        }
        public bool isLeftBulletCollideWithPlayer(GamePlayer player)
        {
            foreach (Bullet bul in Leftbullets)
            {

                if (GameCollider.isBulletColide_WithPlayer(player, bul) == true)
                {
                    removeBullet(bul, 'L');
                    return true;
                }

            }
            return false;
        }
        public bool isUpBulletCollideWithPlayer(GamePlayer player)
        {
            foreach (Bullet bul in Upbullets)
            {

                if (GameCollider.isBulletColide_WithPlayer(player, bul) == true)
                {
                    removeBullet(bul, 'U');
                    return true;
                }

            }
            return false;
        }
        public bool isDownBulletCollideWithPlayer(GamePlayer player)
        {
            foreach (Bullet bul in Downbullets)
            {

                if (GameCollider.isBulletColide_WithPlayer(player, bul) == true)
                {
                    removeBullet(bul, 'D');
                    return true;
                }

            }
            return false;
        }
        public void removeBullet(Bullet bul, char BulletDir)
        {
            GameCell currentCell = this.CurrentCell;
            bul.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            switch (BulletDir)
            {
                case 'R': bullets.Remove(bul); break;
                case 'L': Leftbullets.Remove(bul); break;
                case 'U': Upbullets.Remove(bul); break;
                case 'D': Downbullets.Remove(bul); break;
            }

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
                    direction = GameDirection.Down;
                    this.CurrentCell.CurrentGameObject.Image = ImageGiver.getPlayerImage();
                    EnemyDirection = 'R';
                }
                else if (direction == GameDirection.Down)
                {
                    direction = GameDirection.Right;
                    this.CurrentCell.CurrentGameObject.Image = ImageGiver.getUpPLayer();
                    EnemyDirection = 'U';
                }
                else if (direction == GameDirection.Right)
                {
                    direction = GameDirection.Up;
                    this.CurrentCell.CurrentGameObject.Image = ImageGiver.getLeftPLayer();
                    EnemyDirection = 'L';
                }
                else if (direction == GameDirection.Up)
                {
                    direction = GameDirection.Left;
                    this.CurrentCell.CurrentGameObject.Image = ImageGiver.getDownPLayer();
                    EnemyDirection = 'D';
                }
            }
            else
            {
                nextCell = potentialNextCell;
            }
            return nextCell;
        }
        //generte bullet in right
        public void generateBullet_InRight()
        {
            Bullet bullet;
            bullet = new Bullet(ImageGiver.getRightBulletForS_enemy(), this.CurrentCell.nextCell(GameDirection.Right));
            bullets.Add(bullet);
        }

        //generte bullet in Left
        public void generateLeftBullet()
        {
            Bullet bullet;
            bullet = new Bullet(ImageGiver.getLeftBulletForS_enemy(), this.CurrentCell.nextCell(GameDirection.Left));
            Leftbullets.Add(bullet);

        }

        //generte bullet in Up
        public void generateBullet_InUp()
        {
            Bullet bullet;
            bullet = new Bullet(ImageGiver.getUpBulletForS_enemy(), this.CurrentCell.nextCell(GameDirection.Up));
            Upbullets.Add(bullet);
        }

        //generte bullet in Down
        public void generateBullet_InDown()
        {
            Bullet bullet;
            bullet = new Bullet(ImageGiver.getDownBulletForS_enemy(), this.CurrentCell.nextCell(GameDirection.Down));
            Downbullets.Add(bullet);
        }
        public bool moveBulletsIn_Right()
        {

            if (bullets.Count > 0)
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Right))
                    {

                        removeBullet(bullets[i]);
                    }

                    else
                    {
                        bullets[i].move(bullets[i].nextCell(GameDirection.Right));
                    }
                }

            }

            return false;
        }
        public void moveBulletsIn_Left()
        {

            for (int i = 0; i < Leftbullets.Count; i++)
            {
                if (Leftbullets[i].CurrentCell == Leftbullets[i].nextCell(GameDirection.Left))
                {
                    GameCell currentCell = this.CurrentCell;
                    Leftbullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    Leftbullets.RemoveAt(i);
                }

                else
                {
                    Leftbullets[i].move(Leftbullets[i].nextCell(GameDirection.Left));
                }
            }
        }
        public void moveBulletsIn_Up()
        {

            for (int i = 0; i < Upbullets.Count; i++)
            {
                if (Upbullets[i].CurrentCell == Upbullets[i].nextCell(GameDirection.Up))
                {
                    GameCell currentCell = this.CurrentCell;
                    Upbullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    Upbullets.RemoveAt(i);
                }

                else
                {
                    Upbullets[i].move(Upbullets[i].nextCell(GameDirection.Up));
                }
            }
        }
        public void moveBulletsIn_Down()
        {

            for (int i = 0; i < Downbullets.Count; i++)
            {
                if (Downbullets[i].CurrentCell == Downbullets[i].nextCell(GameDirection.Down))
                {
                    GameCell currentCell = this.CurrentCell;
                    Downbullets[i].CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
                    Downbullets.RemoveAt(i);
                }

                else
                {
                    Downbullets[i].move(Downbullets[i].nextCell(GameDirection.Down));
                }
            }
        }
        public void removeBullet(Bullet bul)
        {
            GameCell currentCell = this.CurrentCell;
            bul.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            bullets.Remove(bul);
        }
    }
}
