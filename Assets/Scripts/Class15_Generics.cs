using UnityEngine;
using motoshin.Tools;

namespace motoshin.Class15
{
    /// <summary>
    /// 泛型 Generics
    /// </summary>
    public class Class15_Generics : MonoBehaviour
    {
        private void Awake()
        {
            #region 不使用泛型
            int NumA = 7, NumB = 11;
            LogSystem.LogWithColor($"數字A與B:{NumA} | {NumB}", "#FFF");
            SwapNumber(ref NumA, ref NumB);
            LogSystem.LogWithColor($"數字A與B:{NumA} | {NumB}", "#FFF");


            char charA = '嗨', charB = '嘿';
            LogSystem.LogWithColor($"字元A與B:{charA} | {charB}", "#FFF");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字元A與B:{charA} | {charB}", "#FFF");

            object objA = 3.5f, objB = 7.6f;
            LogSystem.LogWithColor($"物件A與B:{objA} | {objB}", "#FFF");
            SwapObj(ref objA, ref objB);
            LogSystem.LogWithColor($"物件A與B:{objA} | {objB}", "#FFF");
            #endregion

            bool boolA = true, boolB = false;
            LogSystem.LogWithColor($"A與B:{boolA} | {boolB}", "#FFF");
            Swap<bool>(ref boolA, ref boolB);
            LogSystem.LogWithColor($"A與B:{boolA} | {boolB}", "#FFF");

            byte byteA = 1, byteB = 9;
            LogSystem.LogWithColor($"A與B:{byteA} | {byteB}", "#FFF");
            Swap<byte>(ref byteA, ref byteB);
            LogSystem.LogWithColor($"A與B:{byteA} | {byteB}", "#FFF");

            var player1 = new DataPlayer<int>();
            player1.Data = 999;
            player1.LogData(999);

            var player2 = new DataPlayer<string>();
            player2.Data = "motoshin";
            player2.LogData("motoshin");
        }

        #region 方法區域
        public void SwapNumber(ref int a, ref int b)
        {
            int temp = a;   //將數字A移去旁邊
            a = b;          //將數字A變成數字B
            b = temp;       //將數字B變成旁邊的數字
        }

        public void SwapChar(ref char a, ref char b)
        {
            char temp = a;   //將數字A移去旁邊
            a = b;          //將數字A變成數字B
            b = temp;       //將數字B變成旁邊的數字
        }

        public void SwapObj(ref object a, ref object b)
        {
            object temp = a;   //將數字A移去旁邊
            a = b;          //將數字A變成數字B
            b = temp;       //將數字B變成旁邊的數字
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;   //將數字A移去旁邊
            a = b;          //將數字A變成數字B
            b = temp;       //將數字B變成旁邊的數字
        } 
        #endregion

        public class DataPlayer<T>
        {
            public T Data;

            public void LogData(T data)
            {
                LogSystem.LogWithColor(data, "#999");
            }
        }


    }

}

