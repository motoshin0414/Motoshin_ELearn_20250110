using System.Drawing;
using UnityEngine;
/// <summary>
/// 課程三：運算子
/// 補充：Unity 欄位屬性 Unity事件
/// </summary>
public class Class3Operator : MonoBehaviour
{
    #region 欄位屬性
    //C#變數 = 欄位 Field
    //欄位屬性 Field Attritube
    //[標題(標題文字)]：在屬性面板上標示標題文字
    [Header("等級")]
    public int Lv = 1;
    //[提示(提示文字)]：在屬性面板上滑鼠停留在變數上時顯示
    [Tooltip("這是腳色的移動速度，不建議超過100。")]
    public float moveSpeed = 2.5f;
    //[範圍(最大，最小)]：幫數值類型添加範圍（面板上改為滑桿）
    [Range(1, 100)]
    public byte count = 10;
    //範圍不能使用在非數值類型上，會顯示"Use Range with..."
    [Range(1, 100)]
        public string weapon = "劍";
    //[文字範圍(最小行，最大行)]:使用在字串上，設定面板上的文字框範圍
    [TextArea(2, 5)]
    public string itemDescription = "這裡是文字描述。";
    #endregion

    private void Start()
    {
        #region 布林直邏輯運算子
        Debug.Log($"<color = #f93>布林值邏輯運算結果</color>");
        Debug.Log(!true);
        Debug.Log(!false);
        bool boolVarTrue = true;
        bool  boolVarFlase = false;
        Debug.Log(!boolVarTrue);
        Debug.Log(!boolVarFlase);

        Debug.Log($"<color = #f93>布林值邏輯並且以及或是&&，||</color>");
        Debug.Log($"<color = #f93>&&篇</color>");
        Debug.Log(true && true);
        Debug.Log(true && false);
        Debug.Log(false && true);
        Debug.Log(false && false);
        Debug.Log($"<color = #f93>||篇</color>");
        Debug.Log(true || true);
        Debug.Log(true || false);
        Debug.Log(false || true);
        Debug.Log(false || false);
        #endregion



    }

}
