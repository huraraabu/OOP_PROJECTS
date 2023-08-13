using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Game.GameGL
{
    class RandomEnemy:GameEnemy
    {
        GameDirection direction = GameDirection.Up;
        
        public RandomEnemy(Image enemyImage,GameCell startCell):base(enemyImage)
        {
            this.CurrentCell = startCell;
            
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
        public int GenerateRandom(int min,int max)
        {
            Random rand = new Random();
            return rand.Next(min, max);
        }
        
        
        public void RandomMove(int min,int max)
        {
            int rand = GenerateRandom(min,max);
            if(rand>20&&rand<30)
            {
                direction = GameDirection.Right;
                this.Image = ImageGiver.getLeftZ();
            }
            else if(rand > 30 && rand < 50)
            {
                direction = GameDirection.Left;
                this.Image = ImageGiver.getRightZ();
            }
            else if(rand > 50 && rand < 70)
            {
                direction = GameDirection.Up;
                this.Image = ImageGiver.getUpZ();
            }
            else if(rand > 70 && rand < 100)
            {
                direction = GameDirection.Down;
                this.Image = ImageGiver.getDownZ();
            }
        }
    }
}
