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
        }
        
    }
}


