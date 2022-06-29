using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainUI_Setting : MonoBehaviour
{
    public GameObject credit;

    public GameObject UI_Window; // 설정창
    public bool on_off = false;
    void Start()
    {
        on_off = false;
        UI_Window.SetActive(false);
    }

    public void MakeWindow()
    {
        //on_off가 false면 꺼진 상태, true면 켜진상태
        if (on_off == false)
        {
            on_off = true;
            UI_Window.SetActive(true);
            Debug.Log("창 켜짐");
            return;
        }
        else
        {
            on_off = false;
            UI_Window.SetActive(false);
            Debug.Log("창 꺼짐");
            return;
        }
    }

}
