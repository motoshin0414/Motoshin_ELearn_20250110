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
            //變數名稱.非靜態成員
            //取得非靜態變數
            Debug.Log(Class_7_2.Itembug);
            //取得非靜態屬性
            Debug.Log (Class_7_2.skillMain);
            //呼叫非靜態方法
            Class_7_2.Punch();

            //類別名稱.靜態成員
            //取得靜態資料(成員)
            Debug.Log (Class7_2_static.Itembug2);
            //取得靜態屬姓
            Debug.Log(Class7_2_static.skillsecned);
            //呼叫靜態方法
            Class7_2_static.Kick();

            
        }

        public Class7_2_Smail SlimeG, SlimeB;

        private void Start()
        {
            //非靜態成員
            SlimeB.HP -= 10;
            Debug.Log ($"藍史萊姆HP:{SlimeB.HP}");
            SlimeG.HP -= 10;
            Debug.Log ($"綠史萊姆HP:{SlimeG.HP}");

            //靜態成員
            //靜態成員沒辦法透過個體存取
            //SlimeG.moveSpeed = 3.5f;
            Class7_2_Smail.Movespeed = 3.5f;
            Debug.Log($"史萊姆移動速度:{Class7_2_Smail.Movespeed}");
        }
    }

}

