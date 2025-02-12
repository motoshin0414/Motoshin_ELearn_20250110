using UnityEngine;

namespace motoshin
{
    /// <summary>
    /// 類別 Class
    /// </summary>
    public class Class8_1_Class:MonoBehaviour
    {
        //類別:
        //用來定義一個物件以及他所擁有的資料與功能(成員)

        private void Awake()
        {
            //實例化 NPC 並儲存在NPCJack 變數內
            Class8_1_NPC npcJack = new Class8_1_NPC("捷克");
            Class8_1_NPC npcMotoshin = new Class8_1_NPC("Motoshin","我是源神!");

            npcJack.LogName();
            npcMotoshin.LogName();

            npcJack.Talk();
            npcMotoshin.Talk();
        }
    }
}

