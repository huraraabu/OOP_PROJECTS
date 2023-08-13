using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.GameGL
{
    internal class GamePlayer : GameObject
    {
        public static char setBullet_Direction='R';
        public static List<Bullet> bullets;
        public static List<Bullet> Leftbullets;
        public static List<Bullet> Upbullets;
        public static List<Bullet> Downbullets;
        public  bool isEnemyDead;

        public GamePlayer(Image image, GameCell startCell)
            : base(GameObjectType.PLAYER, image)
        {
            base.CurrentCell = startCell;
            
            bullets = new List<Bullet>();
            Leftbullets = new List<Bullet>();
            Upbullets = new List<Bullet>();
            Downbullets = new List<Bullet>();
        }

        public void move(GameCell gameCell)
        {
            base.CurrentCell = gameCell;
        }

        public bool moveBulletsIn_Right()
        {

            if (bullets.Count > 0)
            {
                for (int i = 0; i < bullets.Count; i++)
                {
                    if (bullets[i].CurrentCell == bullets[i].nextCell(GameDirection.Right))
                    {

                        removeBullet(bullets[i],'R') ;
                    }

                    else
                    {
                        bullets[i].move(bullets[i].nextCell(GameDirection.Right));
                    }
                }
                    
            }
                    
            return false;
        }
                    

        public bool isRightBulletCollide(List<RandomEnemy> Enemies,char EnemyType,HorizontalEnemy Henemy,VerticalEnemy Venemy,SmartEnemy s_Enemy)
        {
            foreach(Bullet bul in bullets)
            {
                if (EnemyType == 'Z')
                {
                    if (GameCollider.isBulletCollide_WithZombies(bul, Enemies) == true)
                    {
                        removeBullet(bul,'R');
                        return true;

                    }
                }
                else if (EnemyType=='H')
                {
                    if (GameCollider.isBulletCollideWith_Henemy(Henemy,bul))
                    {
                        removeBullet(bul,'R');
                        return true;
                    }
                }
                else if (EnemyType == 'V')
                {
                    if (GameCollider.isBulletCollide_With_VEnemy(Venemy,bul))
                    {
                        removeBullet(bul,'R');
                        return true;
                    }
                }
                else if (EnemyType == 'S')
                {
                    if (GameCollider.isBulletCollide_WithSmartEnemy(bul,s_Enemy))
                    {
                        removeBullet(bul, 'R');
                        return true;
                    }
                }

            }
                    return false;
        }
        public bool isLeftBulletCollide(List<RandomEnemy> Enemies,char EnemyType, HorizontalEnemy Henemy,VerticalEnemy Venemy,SmartEnemy S_enemy)
        {

            foreach (Bullet bul in Leftbullets)
            {
                if (EnemyType == 'Z')
                {
                    if (GameCollider.isBulletCollide_WithZombies(bul, Enemies) == true)
                    {
                        removeBullet(bul,'L');
                        return true;
                    }
                }
                else if (EnemyType == 'H')
                {
                    if (GameCollider.isBulletCollideWith_Henemy(Henemy, bul))
                    {
                        removeBullet(bul,'L');
                        return true;
                    }

                }
                else if (EnemyType == 'V')
                {
                    if (GameCollider.isBulletCollide_With_VEnemy(Venemy,bul))
                    {
                        removeBullet(bul,'L');
                        return true;
                    }

                }
                else if (EnemyType == 'S')
                {
                    if (GameCollider.isBulletCollide_WithSmartEnemy(bul,S_enemy))
                    {
                        removeBullet(bul, 'L');
                        return true;
                    }
                }
            }
            return false;
        }
        public bool isUpBulletCollide(List<RandomEnemy> Enemies, char EnemyType, HorizontalEnemy Henemy,VerticalEnemy Venemy,SmartEnemy S_Ene)
        {
            foreach(Bullet bul in Upbullets)
            {
                if (EnemyType == 'Z')
                {
                    if (GameCollider.isBulletCollide_WithZombies(bul, Enemies) == true)
                    {
                        removeBullet(bul,'U');
                        return true;
                    }
                }
                else if (EnemyType == 'H')
                {
                    if (GameCollider.isBulletCollideWith_Henemy(Henemy, bul))
                    {
                        removeBullet(bul,'U');
                        return true;
                    }

                }
                else if (EnemyType == 'V')
                {
                    if (GameCollider.isBulletCollide_With_VEnemy(Venemy, bul))
                    {
                        removeBullet(bul,'U');
                        return true;
                    }

                }
                else if (EnemyType == 'S')
                {
                    if (GameCollider.isBulletCollide_WithSmartEnemy(bul,S_Ene))
                    {
                        removeBullet(bul, 'U');
                        return true;
                    }
                }
            }
            return false;
        }
        public bool isDownBulletCollide(List<RandomEnemy> Enemies, char EnemyType, HorizontalEnemy Henemy,VerticalEnemy Venemy,SmartEnemy S_Ene)
        {
            foreach(Bullet bul in Downbullets)
            {
                if (EnemyType == 'Z')
                {
                    if (GameCollider.isBulletCollide_WithZombies(bul, Enemies) == true)
                    {
                        removeBullet(bul,'D');
                        return true;
                    }
                }
                else if (EnemyType == 'H')
                {
                    if (GameCollider.isBulletCollideWith_Henemy(Henemy, bul))
                    {
                        removeBullet(bul,'D');
                        return true;
                    }

                }
                else if (EnemyType == 'V')
                {
                    if (GameCollider.isBulletCollide_With_VEnemy(Venemy, bul))
                    {
                        removeBullet(bul,'D');
                        return true;
                    }

                }
                else if (EnemyType == 'S')
                {
                    if (GameCollider.isBulletCollide_WithSmartEnemy(bul,S_Ene))
                    {
                        removeBullet(bul, 'D');
                        return true;
                    }
                }

            }
            return false;
        }
        public void removeBullet(Bullet bul, char BulletDir)
        {
            GameCell currentCell = this.CurrentCell;
            bul.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());
            switch (BulletDir) {
                case 'R':       bullets.Remove(bul); break;
                case 'L':       Leftbullets.Remove(bul);break;
                case 'U':       Upbullets.Remove(bul);break;
                case 'D':       Downbullets.Remove(bul);break;
        }
         
        }
        public void moveBulletsIn_Left()
        {

            for (int i = 0; i <Leftbullets.Count; i++)
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

            for (int i = 0; i <Upbullets.Count; i++)
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
        public void generateBullet_InRight()
        {
                Bullet bullet;
                bullet= new Bullet(ImageGiver.getRightBulletForPlayer(), this.CurrentCell.nextCell(GameDirection.Right));
                bullets.Add(bullet);   
        }
       
        public void generateLeftBullet()
        {
                Bullet bullet;
                bullet = new Bullet(ImageGiver.getLeftBulletForPlayer(), this.CurrentCell.nextCell(GameDirection.Left));
                Leftbullets.Add(bullet);

        }
        public void generateBullet_InUp()
        {
            Bullet bullet;
            bullet = new Bullet(ImageGiver.getUpBulletForPlayer(), this.CurrentCell.nextCell(GameDirection.Up));
            Upbullets.Add(bullet);
        }
        public void generateBullet_InDown()
        {
            Bullet bullet;
            bullet = new Bullet(ImageGiver.getDownBulletForPlayer(), this.CurrentCell.nextCell(GameDirection.Down));
            Downbullets.Add(bullet);
        }
    }
}
