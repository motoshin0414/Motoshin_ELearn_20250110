using UnityEngine;
using motoshin.Tools;

namespace motoshin.Class15
{
    /// <summary>
    /// 介面
    /// </summary>
    public class Class15_InterfaceObject : MonoBehaviour
    {
        //介面的使用步驟:
        //1.定義介面與介面成員
        //2.類別實作介面
        //3.實作介面成員

        //步驟1.
        //帶有「使用」功能的介面，遊戲內可被使用的物品
        //使用I開頭命名
        public interface IUse
        {
            //不用宣告方法主體，不用寫大括號
            public void Use();
        }

        //步驟2.
        //C# 單一繼承，多重實作介面
        public class Weapon : IUse
        {
            public void Use()
            {
                LogSystem.LogWithColor("使用武器，釋放武器技能", "#F73");

            }
        }
        public class Potion : IUse
        {
            public void Use()
            {
                LogSystem.LogWithColor("使用藥水，恢復魔力", "#F73");

            }
        }
        public class Chest : IUse
        {
            public void Use()
            {
                LogSystem.LogWithColor("使用寶箱，獲得隨機道具", "#F73");

            }
        }
    }

}

