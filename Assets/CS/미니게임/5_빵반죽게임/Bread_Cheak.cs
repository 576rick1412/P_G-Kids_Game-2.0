using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread_Cheak : MonoBehaviour
{
    public int cheak_Num;
    public int target; // ���� ������Ʈ ��

    public GameObject Bread;
    public GameObject This_OBJ;

    public GameObject clear;
    public float Clear_time;

    void Start()
    {
        Bread.SetActive(false);
        cheak_Num = 0;
        clear.SetActive(false);
    }

    public void Clear_void()
    {
        if (cheak_Num >= target)
        {
            Bread.SetActive(true);
            This_OBJ.SetActive(false);
            Debug.Log("Ŭ����");
            clear.SetActive(true);
            Invoke("end_clear", Clear_time);
        }
    }
    public void end_clear()
    {
        clear.SetActive(false);
    }
}
