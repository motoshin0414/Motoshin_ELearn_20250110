using motoshin.Tools;
using UnityEngine;

namespace motoshin
{
    /// <summary>
    /// 類別與結構
    /// </summary>
    public class Class8_3_ClassAndStruct : MonoBehaviour
    {
        private void Awake()
        {
            //3.空值:類別可以空值，結構不行
            Class8_3_Class class1 = new Class8_3_Class();       //有實例化
            Class8_3_Class class2 = null;                       //空值

            Class8_3_struct struct1 = new Class8_3_struct();   //有實例化
            //Class8_3_struct struct2 = null;                      //空值

            LogSystem.LogWithColor(class1.ToString(), "#F96");
            //LogSystem.LogWithColor(class2.ToString(), "#F96");
            LogSystem.LogWithColor(struct1.ToString(), "#F96");
            //LogSystem.LogWithColor(struct2.ToString(), "#F96");
        }

    }
    public class Class8_3_Class : MonoBehaviour
    {
        //類別:
        //1.繼承:可以繼承
        //2.建構子:允許無參數的建構子
        public Class8_3_Class()
        {

        }
        public Class8_3_Class(int text)
        {

        }
    }
    public struct Class8_3_struct
    {
        //結構"
        //1.繼承:不允許繼承
        //2.建構子:不允許沒有參數的建構子
        /*public Class8_3_struct()
        {

        }*/
        public Class8_3_struct(int test)
        {

        }
    }
}

