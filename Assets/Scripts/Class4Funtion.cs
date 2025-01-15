using UnityEditor.Experimental.GraphView;
using UnityEngine;
/// <summary>
/// 方法
/// 中文:方法、函式、函數、功能
/// 英文:function、method(Unity)
/// </summary>

public class Class4Funtion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {

        #region 方法的基本呼叫與參數
        FirstFunction();
        FirstFunction();
        FirstFunction();
        //呼叫有參數的方法:小括號內要放入引數
        UseSkill("火球術");
        //呼叫有參數的方法，可以不用填參數(填選式參數)
        SpawnEnemy();
        SpawnEnemy("哥布林", 15);
        Fire(600);
        Fire(1000, "大砲");
        BuyItem();
        //BuyItem(30);錯誤:30會直接帶入到第一個參數，倒置資料型態不符合
        BuyItem(count: 30);//使用參數 = 值 的方法
        BuyItem("元氣根", 20, 100);
        #endregion

        //呼叫有回傳值的方法
        //第一種:把結果方到區域變數內
        int Number = Square(9);
        Debug.Log($"<color=#f66>9的平方 = {Number}<color>");
        //第二種:把回傳方法當作該回傳類型使用
        Debug.Log($"<color=#f66>7的平方 = {Square(7)}<color>");

        //框選要整理的程式，按下Ctrl + K + S，選擇#region，快速完成程式碼片段

        float BMI = BMICount(168, 60);
        Debug.Log(BMI);
        float MYBMI = BMICount(160, 75);
        Debug.Log(MYBMI);

    }
    #region 方法基本語法與參數
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    //參數語法:與區域變數相同 資料類型 參數名稱(習慣用小寫或者加底線開頭)
    void UseSkill(string skill)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
    }

    void SpawnEnemy(string enemy = "史萊姆", int blood = 10)
    {
        Debug.Log($"<color=#f33>生成敵人:{enemy},血量為:{blood}</color>");
    }
    /// <summary>
    /// 為生成發射物件的方法
    /// </summary>
    /// <param name="speed">發射速度</param>
    /// <param name="frie">發射物件</param>
    private void Fire(int speed, string frie = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件:{frie},速度為:{speed}</color>");
    }

    void BuyItem(string item = "藥草", int count = 5, int Price = 20)
    {
        Debug.Log($"<color=#36f>購買商品:{item},數量為:{count},價格為:{Price}</color>");

    } 
    #endregion

    //傳回方法:傳回類型不是void，呼叫該方法會獲得結果
    private int Square(int num)
    {
        return num * num;
    }

    private float BMICount(float High, float Weight)
    {
        float BMI = Weight / ((High / 100) * (High / 100));
        return BMI;
    }

    //方法多載 function Overload
    //參數的類型或數量不同
    //零個參數
    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {
        Debug.Log("移動中");
    }
    /// <summary>
    /// 移動，並顯示速度
    /// </summary>
    /// <param name="speed">移動速度</param>
    private void Move(float speed)
    {
        Debug.Log($"移動中，速度{speed}");
    }
}
