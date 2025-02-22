using UnityEngine;
using motoshin.Tools;
using System.Xml.Schema;

namespace motoshin
{
    public class Class10_1_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin1 = new Goblin(10, 1);
            LogSystem.LogWithColor(goblin1.Attack, "#F4D");
            var slime1 = new Slime(3, 2);
            LogSystem.LogWithColor(slime1.Attack, "#F4D");
            goblin1.Move();
            slime1.Move();
            slime1.Initlize();

            //判斷史萊姆是否有繼承哥布林
            //類別A is 類別B : 布林值
            var slime1IsGoblin = slime1 is Goblin;
            LogSystem.LogWithColor($"史萊姆是否為哥布林:{slime1IsGoblin}", "#AAA");

            var spider1 = new Spider(15, 5);

            var spiderIsSlime = spider1 is Slime;
            var spiderIsGoblin = spider1 is Goblin;
            LogSystem.LogWithColor($"蜘蛛是否為史萊姆:{spiderIsSlime}", "#AAA");
            LogSystem.LogWithColor($"蜘蛛是否為哥布林:{spiderIsGoblin}", "#AAA");

        }


    }
    public class Goblin
    {
        public int Attack;          //公開:所有類別可以存取
        public int Defense;

        private float move = 3.5f;  //私人:此類別可以存取
        protected float HP;         //保護:子類別可以存取
        protected int LV = 5;


        public Goblin(int _attack, int _defense) 
        {
            Attack = _attack; Defense = _defense;
        }

        //virtual 虛擬:允許子類別覆寫
        public virtual void Move()
        {
            LogSystem.LogWithColor("兩條腿移動","#F9F");
        }
    }
    //繼承讓類別可以繼承另一個類別，擁有該類別的成員
    //子類別:父類別
    //C# 僅提供單一繼承(只能繼承一個類別)
    public class Slime : Goblin
    {
        protected int LV = 10;

        public Slime(int _attack, int _defense) : base(_attack, _defense)
        {
        }
        public void Initlize()
        {
            Attack = 7;
            //move = 2.5f;
            HP = 10;
            LogSystem.LogWithColor($"等級:{LV}", "#D5D");
            LogSystem.LogWithColor($"等級:{base.LV}", "#D5D");
        }

        //override 覆寫:覆寫父類別有virtual關鍵字的成員
        //override 選擇要覆寫的成員 > 按下 Enter自動完成
        public override void Move()
        {
            //base.Move();//父類別原有的內容
            LogSystem.LogWithColor("爬行", "#F6F");
        }


    }
    public class Spider : Slime
    {
        public Spider(int _attack, int _defense) : base(_attack, _defense)
        {
        }
    }
}


