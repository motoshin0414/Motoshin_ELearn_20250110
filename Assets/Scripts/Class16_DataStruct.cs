using UnityEngine;
using System.Collections.Generic;
using motoshin.Tools;

namespace motoshin
{
    public class Class16_DataStruct : MonoBehaviour
    {
        #region 清單
        //陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 10.2f, 8.3f, 0.6f };

        //清單:泛型集合
        public List<int> speed = new List<int>() { 3,8,5};
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playDefens;
        #endregion
        private void Awake()
        {
            #region 清單
            //清單存取:與陣列相同
            LogSystem.LogWithColor($"第三筆速度{speed[2]}","#F54");
            speed[0] = 10;
            LogSystem.LogWithColor($"第一筆速度{speed[0]}","#F54");
            //增加一筆道具
            props.Add("寶劍");
            //刪除第一筆道具
            props.RemoveAt(0);

            //添加一筆道具到編號1
            props.Insert(1, "頭盔");
            foreach(var prop in props)
            {
                LogSystem.LogWithColor($"道具:{prop}", "#F16");
            }

            //使用建構子帶入陣列
            playDefens = new List<float>(defens);
            //排序:小到大
            playDefens.Sort();
            foreach(var item in playDefens)
            {
                LogSystem.LogWithColor($"資料:{item}", "#F64");
            }

            //排序:大到小
            playDefens.Reverse();
            foreach(var item in playDefens)
            {
                LogSystem.LogWithColor($"資料:{item}", "#F64");
            }

            //count 指清單內的資料數量，會依Add或Remove改變
            LogSystem.LogWithColor($"數量:{playDefens.Count}", "#F66");
            
            //Capcity 指清單內的容量，系統會自動分配，預設為4，並以倍數成長
            LogSystem.LogWithColor($"容量:{playDefens.Capacity}", "#f66");

            List<int> num = new List<int>();

            for(int i = 0; i <= 20; i++)
            {
                num.Add(i);
                LogSystem.LogWithColor($"數量:{num.Count}", "#F66");
                LogSystem.LogWithColor($"數量:{num.Capacity}", "#F66");
            }
            #endregion

            #region 堆疊
            Stack<string> enemys = new Stack<string>();
            enemys.Push("史雷姆");
            enemys.Push("科布林");
            LogStack<string>(enemys);
            //拿資料且不移除
            enemys.Peek();
            LogStack<string>(enemys);
            //拿資料並移除
            enemys.Pop();
            LogStack<string>(enemys);
            
            //判斷是否包含某筆資料
            LogSystem.LogWithColor($"{enemys.Contains("史雷姆")}", "#F12");
            //清除所有資料
            enemys.Clear();
            LogStack<string>(enemys);

            #endregion

            Queue<string> player = new Queue<string>();
            player.Enqueue("法師");
            player.Enqueue("戰士");
            player.Enqueue("盜賊");
            LogQueue<string>(player);
            //拿東西不刪除，與堆疊的Peek相同
            LogSystem.LogWithColor(player.Peek(), "#F33");
            
            LogQueue<string>(player);
            //拿東西刪除，與堆疊的Pop相同
            LogSystem.LogWithColor(player.Dequeue(), "#F33");
            LogQueue<string>(player);
        }

        private void LogStack<T>(Stack<T> stack)
        {
            LogSystem.LogWithColor("--------------", "#FFF");
            foreach(var item in stack)
            {
                LogSystem.LogWithColor($"堆疊資料:{item}", "#FF7");
                
            }
        }

        private void LogQueue<T>(Queue<T> queue)
        {
            LogSystem.LogWithColor("--------------", "#FFF");
            foreach (var item in queue)
            {
                LogSystem.LogWithColor($"堆疊資料:{item}", "#FF7");

            }
        }

    }

}
