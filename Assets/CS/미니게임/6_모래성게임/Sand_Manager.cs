using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sand_Manager : MonoBehaviour
{
    public float Null_Num = 0; // 드롭 좌표 범위

    [Header("단어수")]
    public int OBJ_Num; // 오브젝트 수 , target_POS가 꼬이지 않도록 수 조정

    [Header("단어 순서")]
    public bool[] cheak; // 드롭 확인용

    public GameObject[] SandObjects; //이동오브제
    public GameObject[] target; // 빈칸

    public GameObject[] setSand;
    public int Sand_Num = 1; //성공한 알약수

    Vector2[] target_POS = new Vector2[5];

    public GameObject clear;
    public float Clear_time;

    void Start()
    {
        clear.SetActive(false);
        Null_Num = Screen.height / 5.6f; //화면 비율이 비례해서 범위가 바뀌기 위해
        for (int i = 0; i < cheak.Length; i++)
        {
            cheak[i] = false; setSand[i].SetActive(false);
            setSand[i].SetActive(false);
            target_POS[i] = SandObjects[i].transform.position;
        }

        for (int j = 1; j < OBJ_Num; j++)
        {
            SandObjects[j].SetActive(false);
        }
    }
    void Update()
    {
        switch (Sand_Num)
        {
            case 1: SandObjects[0].SetActive(true);                                                         break;
            case 2: SandObjects[1].SetActive(true); target[0].SetActive(false); setSand[0].SetActive(true); break;
            case 3: SandObjects[2].SetActive(true); target[1].SetActive(false); setSand[1].SetActive(true); break;
            case 4: SandObjects[3].SetActive(true); target[2].SetActive(false); setSand[2].SetActive(true); break;
            case 5: SandObjects[4].SetActive(true); target[3].SetActive(false); setSand[3].SetActive(true); break;
        }
    }
    public void Drag_Sand_0()
    {
        Drag_Sand(0);
    }
    public void Drag_Sand_1()
    {
        Drag_Sand(1);
    }
    public void Drag_Sand_2()
    {
        Drag_Sand(2);
    }
    public void Drag_Sand_3()
    {
        Drag_Sand(3);
    }
    public void Drag_Sand_4()
    {
        Drag_Sand(4);
    }

    // =====================================================================
    public void Drop_Sand_0()
    {
        Drop_Sand(0);
    }
    public void Drop_Sand_1()
    {
        Drop_Sand(1);
    }
    public void Drop_Sand_2()
    {
        Drop_Sand(2);
    }
    public void Drop_Sand_3()
    {
        Drop_Sand(3);
    }
    public void Drop_Sand_4()
    {
        Drop_Sand(4);
    }
    public void Drag_Sand(int i)
    {
        SandObjects[i].transform.position = Input.mousePosition;
    }
    public void Drop_Sand(int i)
    {
        // 이동오브제(GameObject)와 빈칸좌표(target)의 OBJ_order[n]번째와의 거리가 Null_Num보다 작다면 true 멀다면 false
        float Distance = Vector3.Distance(SandObjects[i].transform.position, target[i].transform.position);
        if (Distance < Null_Num)
        {
            if (OBJ_Num <= Sand_Num)
            {
                Destroy(SandObjects[i]);
                target[i].SetActive(false); setSand[i].SetActive(true);
                Sand_Num = 100; clear_void(); return;
            }
            Sand_Num++;
            Destroy(SandObjects[i]);
        }
        SandObjects[i].transform.position = target_POS[i];
    }
    public void clear_void()
    {
        Debug.Log("클리어");
        clear.SetActive(true);
        Invoke("end_clear", Clear_time);
    }
    public void end_clear()
    {
        clear.SetActive(false);
    }
}
