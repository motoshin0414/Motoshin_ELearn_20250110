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
            int NumA = 7, NumB = 11;
            LogSystem.LogWithColor($"數字A與B:{NumA} | {NumB}", "#FFF");
            SwapNumber(ref NumA, ref NumB);
            LogSystem.LogWithColor($"數字A與B:{NumA} | {NumB}", "#FFF");
            LogSystem.LogWithColor($"數字A與B:{NumA} | {NumB}", "#FFF");

            char charA = '嗨', charB = '嘿';
            LogSystem.LogWithColor($"字元A與B:{charA} | {charB}", "#FFF");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字元A與B:{charA} | {charB}", "#FFF");

            object objA = 3.5f, objB = 7.6f;
            LogSystem.LogWithColor($"物件A與B:{objA} | {objB}", "#FFF");
            SwapObj(ref objA, ref objB);
            LogSystem.LogWithColor($"物件A與B:{objA} | {objB}", "#FFF");
        }
        
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
    }

}

