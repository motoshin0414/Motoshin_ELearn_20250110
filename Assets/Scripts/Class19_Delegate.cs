using UnityEngine;
using motoshin.Tools;
using motoshin.Class18;

namespace motoshin.Class19
{
    public class Class19_Delegate : MonoBehaviour
    {
        private void Awake()
        {
            Cure(10);
            Card(("飛行",99));
        }
        //將int 當作參數
        private void Cure(int cure)
        {
            LogSystem.LogWithColor($"治癒值:{cure}", "#6f6");

        }
        //將元組當作參數
        private void Card((string name,int index) card)
        {
            LogSystem.LogWithColor($"卡片:{card.name} | 編號:{card.index}","#F6f");
        }

        //委派:將方法當作參數
        //1.宣告委派：簽章(傳回與參數)
        private delegate void DelegateMethod();

        //2.目標方法:簽章必須與委派相同
        private void Test()
        {
            LogSystem.LogWithColor("測試", "#FF1");
        }

        private void Talk()
        {
            LogSystem.LogWithColor("hi", "#FF1");
        }
        private void Magic()
        {
            LogSystem.LogWithColor("施放魔法", "#FF1");
        }



        //3.宣告變數存放方法(預設為空值)
        private DelegateMethod delegateMethod;

        //4.呼叫委派
        private void Start()
        {
            delegateMethod = Test;      //將方法test存到變數delegateMethod內
            delegateMethod += Talk;     //將方法Talk加進變數delegateMethod內
            delegateMethod += Magic;    //將方法Magic加進變數delegateMethod內
            delegateMethod -= Test;     //將方法Test從delegateMethod內移除
            delegateMethod();       //呼叫委派
        }
    }

}
