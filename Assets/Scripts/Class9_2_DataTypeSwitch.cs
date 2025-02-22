using UnityEngine;
using motoshin.Tools;
using System;

namespace motoshin
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
public class Class9_2_DataTypeSwitch : MonoBehaviour
{
        private void Awake()
        {
            #region 隱式轉換
            //隱式轉換:不需要另外宣告轉換類型
            //將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;

            LogSystem.LogWithColor(byte1, "#F7F");
            LogSystem.LogWithColor(byte1.GetType(), "#F7F");
            LogSystem.LogWithColor(int1, "#F7F");
            LogSystem.LogWithColor(int1.GetType(), "#F7F");

            //隱式轉換:將小的資料(byte)轉換成大的資料(int)
            int1 = byte1;
            LogSystem.LogWithColor(int1, "#F7F");
            LogSystem.LogWithColor(int1.GetType(), "#F7F");
            #endregion

            #region 顯示傳換
            //顯示轉換:需要宣告轉換類型
            //將大的資料轉換成小的資料
            int int2 = 100;
            byte byte2 = 10;
            LogSystem.LogWithColor(int2, "#F7F");
            LogSystem.LogWithColor(int2.GetType(), "#F7F");
            LogSystem.LogWithColor(byte2, "#F7F");
            LogSystem.LogWithColor(byte2.GetType(), "#F7F");
            //顯示轉換:將比較大的int 放到小的byte
            //添加(資料類型)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#F7F");
            LogSystem.LogWithColor(byte2.GetType(), "#F7F");

            //浮點數轉為整數型別，小數點會遺失
            float float1 = 2.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogSystem.LogWithColor(byte3, "#F71");

            //範圍較大的轉為範圍較小的，會導致溢位
            int int3 = 257;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#F71");
            #endregion
        }

        private void Start()
        {
            //將整數轉為字串
            int count = 99;
            var intTostring = Convert.ToString(count);
            LogSystem.LogWithColor(intTostring.GetType(), "#F54");
            //將布林值轉為字串
            bool isover = false;
            var boolTostring = Convert.ToString(isover);
            LogSystem.LogWithColor(boolTostring.GetType(), "#F54");

            float move = 3.5f;
            var floatTobyte = Convert.ToByte(move);
            LogSystem.LogWithColor(floatTobyte.GetType(), "#F41");

            //true = 1,false = 0
            bool isClear = true;
            var boolTobyte = Convert.ToByte(isClear);
            LogSystem.LogWithColor(boolTobyte.GetType(), "#F41");
            LogSystem.LogWithColor(boolTobyte, "#F41");

        }
    }

}

