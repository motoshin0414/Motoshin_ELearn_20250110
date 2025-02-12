using UnityEngine;
namespace motoshin
{
    public class Class7_2_GetSetStaticData : MonoBehaviour
    {
        //取得非靜態成員
        //1.先定義要獲取的資料類別的變數
        //2.透過變數取得非靜態成員
        public Class7_2_static Class_7_2;

        private void Awake()
        {
            Debug.Log(Class_7_2.Itembug);

            //取得靜態資料(成員)
        }
    }

}

