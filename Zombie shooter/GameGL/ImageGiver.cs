using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Properties;

namespace Game.GameGL
{
    internal class ImageGiver
    {
        public static GameObject getBlankGameObject()
        {
            return new GameObject(GameObjectType.NONE, Resources.simplebox);
        }
        public static GameObject getDeadPLayer_GameObject()
        {
            return new GameObject(GameObjectType.NONE, Resources.dead);
        }
        public static Image getPlayerImage()
        {
            return Resources.rightPLayer;
        }
        public static Image getPlayerDeadImage()
        {
            return Resources.dead;
        }
        public static Image getLeftPLayer()
        {
            return Resources.leftPlayer;
        }
        public static Image getUpPLayer()
        {
            return Resources.upPlayer;
                
        }
        public static Image getReward()
        {
            return Resources.ammo_Image;
        }
        public static Image getDownPLayer()
        {
            return Resources.downPlayer;
        }
        public static Image getLeftZ()
        {
            return Resources.zleft;
        }
        public static Image getRightZ()
        {
            return Resources.zright;
        }
        public static Image getUpZ()
        {
            return Resources.zup;
        }
        public static Image getDownZ()
        {
            return Resources.zdown;
        }
        public static  Image getHorizontalEnemy()
        {
            return Resources.leftPlayer;
        }
        public static Image getBulletImage()
        {
            return Resources.player;
        }
        public static Image getVerticleEnemyBullet()
        {
            return Resources.VerticleEenmyBullet;
        }
        //player bullets 
        public static Image getLeftBulletForPlayer()
        {
            return Resources.PlayerL;
        }
        public static Image getRightBulletForPlayer()
        {
            return Resources.PLayerR;
        }
        public static Image getUpBulletForPlayer()
        {
            return Resources.PlayerUp;
        }
        public static Image getDownBulletForPlayer()
        {
            return Resources.PlayerD;
        }

        //smart enemy bullets 
        public static Image getLeftBulletForS_enemy()
        {
            return Resources.SLeft;
        }
        public static Image getRightBulletForS_enemy()
        {
            return Resources.S_right;
        }
        public static Image getUpBulletForS_enemy()
        {
            return Resources.S_Up;
        }

        public static Image getDownBulletForS_enemy()
        {
            return Resources.S_Down;
        }



        public static Image getSmartEnemyBullet()
        {
            return Resources.whiteBullet;
        }
        public static Image getUpSmartEnemyBullet()
        {
            return Resources.UpFire;
        }
        public static Image getRightSmartEnemyBullet()
        {
            return Resources.S_right;
        }
        public static Image getVerticleEnemyBul()
        {
            return Resources.S_right;
        }
        public static Image getHorizontalEnemyBul()
        {
            return Resources.HorizontalBul;
        }
        public static Image getBlankImage()
        {
            return Resources.simplebox;
        }


        public static Image getGameObjectImage(char displayCharacter)
        {
            Image result = Resources.simplebox;
            if (displayCharacter == '|' || displayCharacter == '%')
            {
                result = Resources.horizontal;
            }

            if (displayCharacter == '#')
            {
                result = Resources.horizontal;
            }

            if (displayCharacter == '.')
            {
                //result = Resources.pallet;
            }

            if (displayCharacter == 'P' || displayCharacter == 'p')
            {
                result = Resources.tank;
            }

            return result;
        }
    }
}
