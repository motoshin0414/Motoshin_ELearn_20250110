using UnityEngine;
namespace Motoshin
{
    /// <summary>
    /// 列舉:enumeration，C#內關鍵字為enum
    /// </summary>
    public class Class5_2Enum : MonoBehaviour
    {
        //列舉:定義下拉式選單的選項(通常為單選)
        //語法:
        //修飾詞 關鍵字 enum 列舉名稱 {列舉選項}
        //定義一個列舉，為季節
        //舉列都是數值，預設從0開始
        private enum Season
        {
            Spring,Summer,Fall,Winter
        }
        [SerializeField , Header("季節")]
        private Season season = Season.Summer;

        private void Awake()
        {
            //取得列舉的值(Get)抓出值
            Debug.Log(season);
            //取得列舉的整數值
            Debug.Log((int)season);

            //設定列舉的值(Set)修改值
            season = Season.Winter;
            Debug.Log(season);
            //透過數值設定列舉
            season = (Season)2;
            Debug.Log(season);
        }

    }
}

