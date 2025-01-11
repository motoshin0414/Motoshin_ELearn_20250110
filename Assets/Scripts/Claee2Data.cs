using UnityEngine;
/// <summary>
/// 認識資料類型
/// </summary>
public class Claee2Data:MonoBehaviour
{
    /*
    整數:儲存沒有小數點的數值 int
    浮點數:儲存有小數點的數值 float 
    字串:儲存文字，必須使用雙引號"" string EX:"源神"
    布林值:儲存正與反的數值 bool 只有true 與false
     */
    public int coin = 1000;
    public float movespeed = 3.5f;
    public float trunspeed = 30.0f;
    public string name = "源神";
    public bool gameover = false;
}
