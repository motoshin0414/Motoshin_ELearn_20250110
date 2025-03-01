using UnityEngine;
using motoshin.Tools;

namespace motoshin
{
    public class Class11_Abstract : MonoBehaviour
    {
        private void Awake()
        {
            //抽象類別:
            //1.必須使用關鍵字 abstract
            //2.不能被實例化(new)
            //3.如果有抽象方法成員，不需要主體(大刮號)
            //4.抽象成員必須被子類別實作(override)
            var flyDragon = new FlyDragon();
            var triDragon = new TriDragon();

            //var monster = new Monster(); //錯誤:抽象無法實例化

            flyDragon.Attack();
            triDragon.Attack();

            //向上轉型upcasting : 實例化後存放到父類別
            //向上轉型可以使用多型
            Monster fly = new FlyDragon();
            fly.Track();

            FlyDragon fly2 = new FlyDragon();
            fly2.Track();
            fly2.Track(100);

            var fly3 = new FlyDragon();
            fly3.Track();
            fly3.Track(150);
        }


    }

    //abstract 抽象類別
    public abstract class Monster
    {
        public float hp;
        public float moveSpeed;

        //抽象方法不需要主體(大括號{})
        public abstract void Attack();

        public void Track() 
        {
            LogSystem.LogWithColor("追蹤", "#F45");
        }


    }
    public class FlyDragon : Monster
    {
        public override void Attack()
        {
            LogSystem.LogWithColor("飛龍攻擊", "#F41");
            

        }
        public void Track(int speed)
        {
            LogSystem.LogWithColor($"追蹤，速度:{speed}", "#F14");
        }
    }
    public class TriDragon : Monster
    {
        public override void Attack()
        {
            LogSystem.LogWithColor("三角龍攻擊", "#F41");
        }
    }
}


