using UnityEngine;

namespace motoshin
{
    /// <summary>
    /// 史萊姆
    /// </summary>
    public class Class7_2_Smail : MonoBehaviour
    {
        //非靜態成員是每個物件個別擁有(不共享)
        public float HP = 100;

        //靜態成員是該類別共同擁有
        public static float Movespeed = 1.5f;

    }
}

