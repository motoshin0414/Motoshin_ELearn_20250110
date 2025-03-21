using UnityEngine;
using motoshin.Tools;
using static motoshin.Class15.Class15_InterfaceObject;


namespace motoshin.Class15
{
    public class Class15_Interface : MonoBehaviour
    {
        public object invertoryFirst;
        public object invertorySecond;

        private void Awake()
        {
            int random = Random.Range(0, 3);
            LogSystem.LogWithColor($"隨機數字:{random}", "#FFF");

            if (random == 1) invertoryFirst = new Prop();
            else if (random == 2) invertoryFirst = new Equipment();
            else if (random == 3) invertoryFirst = new Map();

            int randomSecond = Random.Range(0, 3);
            LogSystem.LogWithColor($"隨機數字:{random}", "#FFF");

            if (randomSecond == 1) invertorySecond = new Weapon();
            else if (randomSecond == 2) invertorySecond = new Potion();
            else if (randomSecond == 3) invertorySecond = new Chest();
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

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                if(invertorySecond is IUse)((IUse)invertorySecond).Use();

                if(invertorySecond is IDestory) ((IDestory)invertorySecond).Destory();

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

