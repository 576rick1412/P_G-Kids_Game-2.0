using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Animal_Manager : MonoBehaviour
{
    private float Null_Num = 0; // 드롭 좌표 범위

    [Header("단어수")]
    public int OBJ_Num; // 오브젝트 수 , target_POS가 꼬이지 않도록 수 조정

    [Header("단어 순서")]
    public int[] OBJ_order; // 오브젝트 순서
    public bool[] cheak; // 드롭 확인용
    public bool[] Null_cheak; // 드롭 확인용
    public int[] Null_cheak_Num; //드롭 확인용222

    public GameObject[] GameObject; //글자박스
    public GameObject[] target; // 빈칸
    Vector2[] target_POS = new Vector2[5];

    public GameObject clear;
    public float Clear_time;
    public bool clearIN = false;
    void Start()
    {
        clear.SetActive(false);
        Null_Num = 1.7f; //화면 비율이 비례해서 범위가 바뀌기 위해
        for (int i = 0; i < OBJ_Num; i++)       { target_POS[i] = GameObject[i].transform.position; }
        for (int i = 0; i < cheak.Length; i++)  { cheak[i] = false; }
    }
    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && clearIN == true)
        {
            SceneManager.LoadScene("Main_Scene");
        }

    }

    public void clear_cheak()
    {
        switch (cheak.Length)
        {
            case 1: if (cheak[0] == true)                                                               { clear_void(); } break;
            case 2: if (cheak[0] == true && cheak[1] == true)                                           { clear_void(); } break;
            case 3: if (cheak[0] == true && cheak[1] == true && cheak[2] == true)                       { clear_void(); } break;
            case 4: if (cheak[0] == true && cheak[1] == true && cheak[2] == true && cheak[3] == true)   { clear_void(); } break;
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
        Null_cheak_Num[0] = Drop_Animal(0);
    }
    public void Drop_Animal_1()
    {
        Null_cheak_Num[1] = Drop_Animal(1);
    }
    public void Drop_Animal_2()
    {
        Null_cheak_Num[2] = Drop_Animal(2);
    }
    public void Drop_Animal_3()
    {
        Null_cheak_Num[3] = Drop_Animal(3);
    }
    public void Drop_Animal_4()
    {
        Null_cheak_Num[4] = Drop_Animal(4);
    }
    public void Drag_Animal(int i)
    {
        var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100.0f);
        GameObject[i].transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
        cheak[i] = false;
        switch (Null_cheak_Num[i])
        {
            case 0: Null_cheak[0] = false; break;
            case 1: Null_cheak[1] = false; break;
            case 2: Null_cheak[2] = false; break;
            case 3: Null_cheak[3] = false; break;
        }
    }
    public int Drop_Animal(int i)
    {
        // 글자박스(GameObject)와 빈칸좌표(target)의 OBJ_order[n]번째와의 거리가 Null_Num보다 작다면 true 멀다면 false
        // 각 글자박스마다 Null_cheak_Num값을 가지며 현재 있는 빈칸의 정보를 담기위해 사용, 만약 빈칸에 다른 글자박스가 있다면 원래위치로 반환, 아니면 빈칸으로 이동
        // return 0;으로 할 경우 빈칸[0]과 겹치는 경우가 생겨 100으로 반환
        for (int j = 0; j < target.Length; j++)
        {
            float Distance = Vector3.Distance(GameObject[i].transform.position, target[OBJ_order[j]].transform.position);
            if (Distance < Null_Num)
            {
                if (Null_cheak[j] == true) { GameObject[i].transform.position = target_POS[i]; return 100; } //빈칸에 오브젝트가 있다면 리턴
                else
                {
                    if (i == j) // 올바른 칸일 경우 
                    { GameObject[i].transform.position = target[OBJ_order[i]].transform.position;   cheak[i] = true;    Null_cheak[j] = true; clear_cheak(); return j; }
                    else //칸은 맞으나 올바른 칸이 아닐경우
                    { GameObject[i].transform.position = target[OBJ_order[j]].transform.position;                       Null_cheak[j] = true;                return j; }
                }
            }
        }GameObject[i].transform.position = new Vector3(target_POS[i].x, target_POS[i].y, 100f); return 100;
    }

    public void clear_void()
    {
        clearIN = true;
        Debug.Log("클리어");
        clear.SetActive(true);
        Invoke("end_clear", Clear_time);
    }
    public void end_clear()
    {
        clear.SetActive(false);
    }
}