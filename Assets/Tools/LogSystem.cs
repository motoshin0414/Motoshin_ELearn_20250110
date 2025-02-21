using UnityEngine;

namespace motoshin.Tools
{
    public class LogSystem 
    {
        public static string LogWithColor(string message , string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result) ;
            return result ;
        }
    }
}


