using UnityEngine;
using motoshin.Tools;


namespace motoshin.Class15
{
    public class Class15_Interface : MonoBehaviour
    {
        public object invertoryFirst;

        private void Awake()
        {
            int random = Random.Range(0, 3);
            LogSystem.LogWithColor($"隨機數字:{random}", "#FFF");

            if (random == 1) invertoryFirst = new Prop();
            else if (random == 2) invertoryFirst = new Equipment();
            else if (random == 3) invertoryFirst = new Map();
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                //如果第一格是道具，就使用道具
                if (invertoryFirst is Prop) ((Prop)invertoryFirst).Use();
                //如果第一格是裝備，就使用裝備
                if (invertoryFirst is Equipment) ((Equipment)invertoryFirst).Use();
                //如果第一格是地圖，就使用地圖
                if (invertoryFirst is Map) ((Map)invertoryFirst).Use();

            }
        }
    }

    public class Prop
    {
        public void Use() 
        {
            LogSystem.LogWithColor("使用道具，恢復體力", "#F01");
            
        }

    }
    public class Equipment
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用裝備，到對應位置", "#F01");
            
        }
    }

    public class Map
    {
        public void Use()
        {
            LogSystem.LogWithColor("使用地圖，開啟地圖功能", "#F01");
        }
    }
}

