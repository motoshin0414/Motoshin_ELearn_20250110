using UnityEngine;
using motoshin.Tools;
using System;

namespace motoshin.Class18
{
    public class Class18_Exception : MonoBehaviour
    {
        private void Awake()
        {
            #region 官方例外處理
            #region 除0錯誤處理
            LogSystem.LogWithColor($"{Division(9, 9)}", "#f33");
            LogSystem.LogWithColor($"{Division(111, 8)}", "#f33");
            LogSystem.LogWithColor($"{Division(10, 0)}", "#f33");
            #endregion

            #region 陣列範圍外處理
            LogSystem.LogWithColor($"{GetScores(0)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(4)}", "#3f3");
            LogSystem.LogWithColor($"{GetScores(10)}", "#3f3");
            #endregion

            SetEnemy();
            #endregion
            try
            {
                Damage(30);
                Damage(80);
            }
            catch (Exception e)
            {

                LogSystem.LogWithColor(e, "#9f9");
            }

            try
            {
                Cure(30);
                Cure(-10);
            }
            catch (CureValueLowerZeroException e)
            {

                LogSystem.LogWithColor(e.Message, "#7f3");

            }
        }

        #region 官方例外處理
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="x">分母</param>
        /// <param name="y">分子</param>
        /// int? 允許傳回空值
        private int? Division(int x, int y)
        {
            //可能發生例外的區域
            try
            {
                return x / y;       //發生例外
            }
            //捕捉到例外為「除以0」時將會執行
            catch (DivideByZeroException e)
            {
                LogSystem.LogWithColor($"分子不能為0 | {e.Message}", "#F99");
                return null;
            }
            //最後區域
            finally
            {
                LogSystem.LogWithColor("例外處理完畢", "#F73");
            }
        }

        private int[] scores = { 40, 66, 31, 88, 54 };

        private int? GetScores(int index)
        {
            try
            {
                return scores[index];
            }
            catch (DivideByZeroException)
            {
                LogSystem.LogWithColor("發生例外", "#F11");
                return null;
            }
            catch (IndexOutOfRangeException e)
            {
                LogSystem.LogWithColor($"發生例外 | {e.Message}", "#F11");
                return null;
            }

        }

        [SerializeField]
        private GameObject enemy;

        private void SetEnemy()
        {
            try
            {
                enemy.SetActive(true); //顯示敵人
            }
            catch (Exception e)         //Exception 處理所有例外
            {

                LogSystem.LogWithColor($"發生例外:{e.Message}", "#996");
            }
        }
        #endregion

        private float hp = 100;

        private void Damage(float damage)
        {
            hp -= damage;
            if (hp <= 0)
            {
                throw new Exception("血量小於零");
            }
            else
            {
                LogSystem.LogWithColor($"血量:{hp}", "#951");
            }
        }
        private void Cure(float cure)
        {
            if (cure < 0) 
            {
                //throw new Exception("治癒值小於零");
                throw new CureValueLowerZeroException("治癒值小於零");

            }
            else
            {
                hp += cure;
            }
        }
    }

    public class CureValueLowerZeroException : Exception
    {
        public CureValueLowerZeroException(string message):base(message)
        {

        }

    }


}

