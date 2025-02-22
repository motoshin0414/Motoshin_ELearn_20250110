using UnityEngine;
using motoshin.Tools;


public class Class10_2_Polymorphism : MonoBehaviour
{
    private void Awake()
    {
        Trap trap1 = new Trap("落穴", 3);
        Magic magic1 = new Magic("使者甦醒", 5);

        //多型:多種型式，可以使用父類別或者自己成員
        trap1.Information();
        trap1.Information(51);

        //多型:宣告時使用父類別，實例化的類別會決定型式
        Card card1 = new Card("一班卡片", 0);
        Card magic2 = new Magic("興知會興", 7);
        card1.Information();
        magic2.Information();
    }
    public class Card
    {
        public string name;
        public int cost;
        public Card(string _name, int _cost)
        {
            name = _name;
            cost = _cost;
        }
        public virtual void Information()
        {
            LogSystem.LogWithColor($"{name}這是一張卡", "#BBB");
            

        }
    }
    public class Trap : Card
    {
        public Trap(string _name, int _cost) : base(_name, _cost)
        {
        }
        public void Information(int index)
        {
            LogSystem.LogWithColor($"這是一張陷阱卡 編號{index}", "#BBB");
        }
    }

    public class Magic : Card
    {
        public Magic(string _name, int _cost) : base(_name, _cost)
        {
        }
        public override void Information()
        {
            LogSystem.LogWithColor($"{name}是一張魔法卡", "#BBB");
        }
    }


}
