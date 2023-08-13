using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Game.GameGL
{
    class GameCollider
    {
        //check that Enemies  Bullet Collide With Player
        public static bool isBulletColide_WithPlayer(GamePlayer player,Bullet bullet)
        {
           if(player.CurrentCell==bullet.CurrentCell)
            {
                return true;
            }
            return false;
        }
        // player bullet collide with Verticle Enemy
        public static bool isBulletCollide_With_VEnemy(VerticalEnemy enemy,Bullet bullet)
        {
            if(enemy.CurrentCell==bullet.CurrentCell)
            {
            
                return true;
            }
            return false;
        }
        //PLayer collide with reward
        public static bool isPlayerCollide_With_Reward(GamePlayer player,GameReward reward)
        {
            bool isCollide=false;
            for (int a=0;a<reward.rewards.Count;a++)
            {
                if (player.CurrentCell == reward.rewards[a])
                {
                    isCollide = true;
                    reward.removeRewardCell(reward.rewards[a]);
                }

            }   
            
            return isCollide;
        }
        //player Bullet Collide With Zombies
        public static bool isBulletCollide_WithZombies(Bullet bullet,List<RandomEnemy> Enemies)
        {
            foreach(RandomEnemy randE in Enemies)
            {
                if(bullet.CurrentCell==randE.CurrentCell)
                {
                    Enemies.Remove(randE);
                    return true;
                }

            }
            return false;
        }

        //Player Bullet Collide With Smart Enemy
        public static bool isBulletCollide_WithSmartEnemy(Bullet bullet,SmartEnemy S_Ene)
        {
            
                if (bullet.CurrentCell ==S_Ene.CurrentCell)
                {
                    return true;
                   
                }

            
            return false;
        }

        //Player Collide With Zombies
        public static bool isPLayerCollide_WithZombies(List<RandomEnemy>Enemies,GamePlayer player)
        {
            foreach(RandomEnemy randE in Enemies)
            {
                if(randE.CurrentCell==player.CurrentCell)
                {
                    return true;
                }
            }
            return false;
        }

        //Player Bullet Collide With Horizontal Enemy
        public static bool isBulletCollideWith_Henemy(HorizontalEnemy Henemy,Bullet bullet)
        {
            if(Henemy.CurrentCell==bullet.CurrentCell)
            {
                return true;
            }
                return false;
        }

    }
}
