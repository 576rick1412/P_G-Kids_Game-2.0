using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI_Setting : MonoBehaviour
{
    public GameObject credit;

    public GameObject UI_Window; // ����â
    public bool on_off = false;
    void Start()
    {
        on_off = false;
        UI_Window.SetActive(false);
    }

    public void MakeWindow()
    {
        //on_off�� false�� ���� ����, true�� ��������
        if (on_off == false)
        {
            on_off = true;
            UI_Window.SetActive(true);
            Debug.Log("â ����");
            return;
        }
        else
        {
            on_off = false;
            UI_Window.SetActive(false);
            Debug.Log("â ����");
            return;
        }
    }

}
