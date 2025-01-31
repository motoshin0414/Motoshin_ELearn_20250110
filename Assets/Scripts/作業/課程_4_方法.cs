using UnityEngine;

public class 課程_4_方法 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        FunctionBackTrue();
        FunctionBackFalse();
    }

    private bool FunctionBackTrue()
    {
        Debug.Log("this is true");
        return true;
    }

    private bool FunctionBackFalse()
    {
        Debug.Log("this is false");
        return false;
        
    }
}
