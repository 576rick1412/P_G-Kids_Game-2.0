using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple_Button : MonoBehaviour
{
    public GameObject clear;
    public float Clear_time;
    private void Start()
    {
        clear.SetActive(false);
    }

    public void Right_B()
    {
        Debug.Log("�ߺ�!! ����");
        clear_void();
    }
    public void False_B()
    {
        Debug.Log("�ߺ�!! ����");
    }

    public void clear_void()
    {
        clear.SetActive(true);
        Debug.Log("Ŭ����");
        Invoke("Clear_Timer", Clear_time);
    }
    public void Clear_Timer()
    {
        clear.SetActive(false);
    }
}
