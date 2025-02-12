using UnityEngine;

namespace motoshin
{
    public class Class7_1_GetSetData : MonoBehaviour
    {
        public Class7_1_Property property;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(property.MoveSpeed);  //可以
            //Debug.Log(property.TurnSpeed);//不允許

            Debug.Log(property.runspeed);       //可以取得公開的屬性
            //Debug.Log(property.springspeed);  //不可取得私人的屬性

            property.runspeed = 50.2f;
            //property.jumpspeed = 99.5f;       //不可設定，沒有set屬性(唯讀)
        }

    
    }
}


