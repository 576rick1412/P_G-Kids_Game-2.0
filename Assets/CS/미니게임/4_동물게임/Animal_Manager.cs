using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Manager : MonoBehaviour
{
    private float Null_Num = 0; // 드롭 좌표 범위

    [Header("단어수")]
    public int OBJ_Num; // 오브젝트 수 , target_POS가 꼬이지 않도록 수 조정

    [Header("단어 순서")]
    public int[] OBJ_order; // 오브젝트 순서
    public bool[] cheak; // 드롭 확인용
    
    public GameObject[] GameObject; //글자박스
    public GameObject[] target; // 빈칸
    Vector2[] target_POS = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 5.6f; //화면 비율이 비례해서 범위가 바뀌기 위해

        for (int i = 0; i < OBJ_Num; i++)
        {
            target_POS[i] = GameObject[i].transform.position;
        }

        for (int i = 0; i < cheak.Length; i++)
        {
            cheak[i] = false;
        }

    }

    void Update()
    {
        switch (cheak.Length)
        {
            case 1:
                if (cheak[0] == true)
                { Debug.Log("클리어"); }
                break;
            case 2:
                if (cheak[0] == true && cheak[1] == true)
                { Debug.Log("클리어"); }
                break;

            case 3:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true)
                { Debug.Log("클리어"); }
                break;

            case 4:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true && cheak[3] == true)
                { Debug.Log("클리어"); }
                break;
        }
    }

    public void Drag_Animal_0()
    {
        Drag_Animal(0);
    }
    public void Drag_Animal_1()
    {
        Drag_Animal(1);
    }
    public void Drag_Animal_2()
    {
        Drag_Animal(2);
    }
    public void Drag_Animal_3()
    {
        Drag_Animal(3);
    }
    public void Drag_Animal_4()
    {
        Drag_Animal(4);
    }

    // =====================================================================
    public void Drop_Animal_0()
    {
        Drop_Animal(0);
    }
    public void Drop_Animal_1()
    {
        Drop_Animal(1);
    }
    public void Drop_Animal_2()
    {
        Drop_Animal(2);
    }
    public void Drop_Animal_3()
    {
        Drop_Animal(3);
    }
    public void Drop_Animal_4()
    {
        Drop_Animal(4);
    }
    public void Drag_Animal(int i)
    {
        GameObject[i].transform.position = Input.mousePosition;
        cheak[i] = false;
    }
    public void Drop_Animal(int i)
    {
        // 글자박스(GameObject)와 빈칸좌표(target)의 ward[n]번쨰와의 거리가 Null_Num보다 작다면 true 멀다면 false
        float Distance = Vector3.Distance(GameObject[i].transform.position, target[OBJ_order[i]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[i].transform.position = target[OBJ_order[i]].transform.position;
            cheak[i] = true;    return;
        }
        GameObject[i].transform.position = target_POS[i];
    }
}