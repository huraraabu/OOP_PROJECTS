using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
namespace Game.GameGL
{
   class GameReward:GameObject
    {
        public List<GameCell> rewards;
        private int count = 0;
        private int x = 13;
        private int y = 5;
        GameCell rewardCell;

       public  List<GameCell> Rewards { get => rewards; set => rewards = value; }

        public GameReward(Image image,GameCell startCell,GameGrid grid):base(GameObjectType.REWARD,image)
        {
            base.CurrentCell = startCell;
            base.CurrentCell.Grid = grid;
           
            rewards = new List<GameCell>();
        }
        public void removeRewardCell(GameCell reward)
        {
            rewards.Remove(reward);
        }
        public void getRandomCell(GameGrid grid)
        {
            y = y + count;
            x = y +count;
            if (count < 4)
            {
                rewardCell= grid.getCell(x, y);
            }
            else
            {
                setCell();
            }
            count++;
         
            
            
        }
        public void setCell()
        {
            count = 0;
            x = 30;
            y = 6;
        }
        public GameCell generateReward()
        {
            getRandomCell(base.CurrentCell.Grid);
            rewards.Add(rewardCell);
            return rewardCell;
        }

    }
}
