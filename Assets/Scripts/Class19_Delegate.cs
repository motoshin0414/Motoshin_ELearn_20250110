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
        private delegate float Calculate(float NumberA,float NumberB);
        private delegate void DelegetCombine<T>(T A);

        //2.目標方法:簽章必須與委派相同
        #region 無參數與回傳的委派
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
        #endregion

        private float Add(float NumA, float NumB)
        {
            float result = NumA + NumB;
            LogSystem.LogWithColor(result, "#FF1");
            return result;
        }
        private float Sub(float NumA, float NumB)
        {
            float result = NumA - NumB;
            LogSystem.LogWithColor(result, "#FF1");
            return result;
        }
        private float Mul(float NumA, float NumB)
        {
            float result = NumA * NumB;
            LogSystem.LogWithColor(result, "#FF1");
            return result;
        }

        private void Combine<T>(T A)
        {
            LogSystem.LogWithColor(A, "#1f1");
        }

        //3.宣告變數存放方法(預設為空值)
        private DelegateMethod delegateMethod;
        private Calculate calculate;
        private DelegetCombine<float> delegetCombineFloat;
        private DelegetCombine<int> delegetCombineInt;

        //4.呼叫委派
        private void Start()
        {
            #region 基本委派
            delegateMethod = Test;      //將方法test存到變數delegateMethod內
            delegateMethod += Talk;     //將方法Talk加進變數delegateMethod內
            delegateMethod += Magic;    //將方法Magic加進變數delegateMethod內
            delegateMethod -= Test;     //將方法Test從delegateMethod內移除
            delegateMethod();       //呼叫委派 
            #endregion

            calculate += Add;
            calculate += Sub;
            calculate += Mul;
            calculate(10,3);

            CalcuateNumber(Sub,3,9);

            delegetCombineFloat = Combine<float>;
            delegetCombineFloat(3.5f);
            delegetCombineInt = Combine<int>;
            delegetCombineInt(16);


        }
        //委派:將方法當作參數
        private void CalcuateNumber(Calculate calcute ,float NumA, float NumB)
        {
            var result = calculate(NumA, NumB);
            LogSystem.LogWithColor(result, "#159");

        }
    }

}
