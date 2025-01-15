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
        FirstFunction();
        FirstFunction(); 
        FirstFunction();
        //呼叫有參數的方法:小括號內要放入引數
        UseSkill("火球術");

    }
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    //參數語法:與區域變數相同 資料類型 參數名稱(習慣用小寫或者加底線開頭)
    void UseSkill(string skill)
    {
        Debug.Log($"<color=#f93>施放技能:{skill}</color>");
    }
}
