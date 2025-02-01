using Unity.VisualScripting;
using UnityEngine;
namespace motoshin
{
    /// <summary>
    /// 反覆運算述式:迴圈
    /// for、foreach、do、while
    /// </summary>
    public class Class6While_for_foreach : MonoBehaviour
    {
        private void Awake()
        {
            #region 迴圈:for、do、while

            
            //迴圈請在一次性事件內使用:Awake、Start
            //while迴圈:當布林值為true時會持續執行
            //while(布林值) { 程式區段 }
            //無限迴圈:布林值一直為true
            //宣告區域變數 i 為 0
            int i = 0;
            while(i < 5)
            {
                Debug.Log($"<color = #F33>while 迴圈，i :{i}</color>");
                i++;
            }
            #endregion

            //foreach 迴圈
            //資料結構:陣列、清單等等...
            //foreach (資料類型 資料名稱 in 資料結構) {程式區塊}
            //字串就是一種資料結構，用來存放 char 的陣列
            string dialogue = "hi hi motoshin.";
            //foreach 迴圈將抓出 dialogue的每一個字並存放在區域變數text內。
            //var 無類型
            foreach (var text in dialogue)
            {
                Debug.Log($"<color=#3FF>{text}</color>");
            }
        }
        
    }
}


