using UnityEngine;
using motoshin.Tools;

namespace motoshin.Class17
{
    /// <summary>
    /// 元組 Tuple
    /// </summary>
    public class Class17_Tuple : MonoBehaviour
    {
        private void Awake()
        {
            //元組：儲存多筆不同類型的資料
            //宣告方式1:指定類型與名稱
            (string name, int cost, int index) card1 = ("史萊姆", 1, 1);
            LogSystem.LogWithColor($"{card1.name} | 消耗:{card1.cost} | 編號:{card1.index}", "#F99");
            

            //宣告方式2:指定類型
            //取得元組資料時使用 Item1~ItemN
            (string, int, int) card2 = ("哥布林", 2, 23);
            LogSystem.LogWithColor($"{card2.Item1} | 消耗:{card2.Item2} | 編號:{card2.Item3}", "#F99");

            //宣告方式3:使用var
            var card3 = ("妖精", 5, 32);
            LogSystem.LogWithColor($"{card3.Item1} | 消耗:{card3.Item2} | 編號:{card3.Item3}", "#F99");

            //宣告方式4:使用var以及指名
            var card4 = (name:"蝙蝠" , cost:2, index:3);
            LogSystem.LogWithColor($"{card4.Item1} | 消耗:{card4.Item2} | 編號:{card4.Item3}", "#F99");

            UseCard(card1);
            UseCard(card2);
            UseCard(("暴龍",9,199));

            var card1Update = UpdateCardCost(card1);
            LogSystem.LogWithColor($"{card1Update.name} | 消耗:{card1Update.cost} | 編號:{card1Update.index}", "#F99");
            //可以使用書出來偵測兩個元組是否相同
            LogSystem.LogWithColor($"{card1 == card1Update}", "#845");


        }
        public void UseCard((string name,int cost,int index) card)
        {
            LogSystem.LogWithColor($"消耗{card.cost}，使用{card.name}", "#7f7");
        }
        private (string name, int cost, int index) UpdateCardCost((string name, int cost, int index) card)
        {
            card.cost -= 1;
            return card;
        }
    }

}

