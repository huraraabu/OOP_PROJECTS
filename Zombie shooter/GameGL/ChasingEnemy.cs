using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Game.GameGL
{
    class ChasingEnemy:GameEnemy
    {
        double[] distance = new double[4] { 1000000, 1000000, 1000000, 1000000 };
        GameDirection direction = GameDirection.Left;

        public static char EnemyDirection;

        private const int enemySpeed = 3;
        public ChasingEnemy(Image enemyImage,GameCell startCell):base(enemyImage)
        {
            this.CurrentCell = startCell;
        }
        public override void move(GameCell gameCell)
        {
            if (this.CurrentCell != null)
            {
                this.CurrentCell.setGameObject(ImageGiver.getBlankGameObject());

            }
            CurrentCell = gameCell;
        }
        public double CalculateDistance(int EnemyX,int Enemy_Y,int PLayer_X,int Player_Y)
        {
             
            double distance = Math.Sqrt((Math.Pow(Player_Y - Enemy_Y, 2) + (Math.Pow(PLayer_X - EnemyX, 2))));
            return distance;
        }
        public  GameCell smartMove(GamePlayer player)
        {
         
            if (GameObjectType != GameObjectType.WALL)
            {
                distance[0] = (CalculateDistance(CurrentCell.X, CurrentCell.Y - 1, player.CurrentCell.X, player.CurrentCell.Y));
            }
            if (GameObjectType != GameObjectType.WALL)
            {
                distance[1] = (CalculateDistance(CurrentCell.X, CurrentCell.Y + 1, player.CurrentCell.X, player.CurrentCell.Y));
            }
            if (GameObjectType != GameObjectType.WALL)
            {
                distance[2] = (CalculateDistance(CurrentCell.X + 1, CurrentCell.Y, player.CurrentCell.X, player.CurrentCell.Y));
            }
            if (GameObjectType != GameObjectType.WALL)
            {

                distance[3] = (CalculateDistance(CurrentCell.X - 1, CurrentCell.Y, player.CurrentCell.X, player.CurrentCell.Y));

            }

            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                direction = GameDirection.Left;

                GameCell next = this.CurrentCell.nextCell(direction);

                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {

                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {

                    if (next != null)
                    {
                    
                        next.CurrentGameObject.Image = ImageGiver.getLeftPLayer();
                        return next;
                    }
                }
            }

            if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                direction = GameDirection.Right;


                GameCell next = this.CurrentCell.nextCell(direction);

                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {

                }

                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {

                    if (next != null)
                    {
                        next.CurrentGameObject.Image = ImageGiver.getPlayerImage();
                        return next;
                    }
                }

            }

            if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                direction = GameDirection.Down;

                GameCell next = this.CurrentCell.nextCell(direction);

                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {

                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {

                    if (next != null)
                    {


                        next.CurrentGameObject.Image = ImageGiver.getDownPLayer();
                        return next;
                    }
                }

            }

            else
            {
                direction = GameDirection.Up;

                GameCell next = this.CurrentCell.nextCell(direction);

                if (next.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
                {

                }
                if (next.CurrentGameObject.GameObjectType != GameObjectType.WALL)
                {

                    if (next != null)
                    {

                        next.CurrentGameObject.Image = ImageGiver.getUpPLayer();
                        return next;
                    }
                }

            }
            return null;





        

    }
        public override GameCell nextCell()
        {
            throw new NotImplementedException();
        }


    }
}
