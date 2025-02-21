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

        private void Start()
        {
            //var 不指定類型，可以儲存任何資料型態
            var testClass = new Class8_4_Class("我是類別");
            var testStruct = new Class8_4_Struct("我是結構");

            var testClass2 = new Class8_4_Class("我是類別2");
            var testStruct2 = new Class8_4_Struct("我是結構2");

            LogSystem.LogWithColor(testClass.name, "#F65");
            LogSystem.LogWithColor(testClass2.name, "#F65");
            LogSystem.LogWithColor(testStruct.name, "#F65");
            LogSystem.LogWithColor(testStruct2.name, "#F65");

            testClass2 = testClass;     //傳址:這時候的class與class2指向同一個地址
            testStruct2 = testStruct;   //傳值:這時候struct與struct2指向同一個值

            //修改class 或 class2 資料都會被同步
            testClass.name = "類別";
            LogSystem.LogWithColor(testClass.name, "#F85");
            LogSystem.LogWithColor(testClass2.name, "#F85");

            //修改struct 或 struct2 資料都不會同步
            testStruct.name = "結構";
            LogSystem.LogWithColor(testStruct.name, "#F85");
            LogSystem.LogWithColor(testStruct2.name, "#F85");
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
}

