using motoshin.Tools;
using UnityEngine;

namespace motoshin
{
    /// <summary>
    /// 裝箱 Boxing 與拆箱 Unboxing
    /// </summary>
    public class Class9_1_Boxing : MonoBehaviour
    {
        //實質型別的資料型態
        //結構、列舉、整數、浮點數
        //實值型別的資料回儲存在stack記憶體內
        private int num = 100;

        //參考型別的資料型態
        //物件、類別、字串
        //物件資料類型為參考型別
        private object box;

        private object boxnum = 50;
        private int count;

        private void Awake()
        {
            //裝箱 Boxing 
            //將實質型別資料放到參考型別資料內
            box = num;
            LogSystem.LogWithColor(box.ToString(), "#FFF");

            //拆箱 Unboxing
            //將參考型別資料放到實質型別資料內
            //在前方添加(要轉換的資料類型)
            count = (int)boxnum;
            LogSystem.LogWithColor(count.ToString(), "#F51");
        }
    }
}


