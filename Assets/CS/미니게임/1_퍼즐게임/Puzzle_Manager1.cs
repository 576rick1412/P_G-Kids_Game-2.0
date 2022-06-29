using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[Serializable]
[HideInInspector]
public class Puzzle_S
{
    public Sprite[] Puzzle = new Sprite[4];
}

public class Puzzle_Manager1 : MonoBehaviour
{

    public Puzzle_S[] Puzzle_Order = new Puzzle_S[4]; // 위에 클래스와 연결됨 

    public int[] Puzzle_Num; //퍼즐의 현재 이미지 상태 0이 정방향 상태

    public Image[] Image; // 퍼즐 기본 배치
    public bool[] cheak_Clear;

    public GameObject clear;
    public GameObject clearART;
    public float Clear_time;
    public bool clearIN = false;
    void Start()
    {
        clearART.SetActive(false);
        clear.SetActive(false);

        for (int i = 0; i < Puzzle_Num.Length; i++)
        {
            Image[i].sprite = Puzzle_Order[i].Puzzle[Puzzle_Num[i]];
            if (Puzzle_Num[i] == 0) cheak_Clear[i] = true;
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clearIN == true)
        {
            SceneManager.LoadScene("Main_Scene");
        }
    }

    public void Puzzle_Rotate_0(){PuzzleCheck(0);}
    public void Puzzle_Rotate_1(){PuzzleCheck(1);}
    public void Puzzle_Rotate_2(){PuzzleCheck(2);}
    public void Puzzle_Rotate_3(){PuzzleCheck(3);}


    public void PuzzleCheck(int i)
    {
        // 이미지 바꾸기
        //3이 넘어가면 a를 0으로 하고 다시 돌아감
        if (Puzzle_Num[i] > 2)
        {
            Puzzle_Num[i] = 0;  cheak_Clear[i] = true;
            Image[i].sprite = Puzzle_Order[i].Puzzle[Puzzle_Num[i]];
            clear_void();   return;
        }
        else
        {
            // 이미지가 다시 돌아갔기에 false로 변경
            cheak_Clear[i] = false; Puzzle_Num[i]++;
            Image[i].sprite = Puzzle_Order[i].Puzzle[Puzzle_Num[i]];    return;
        }
    }
    public void clear_void()
    {
        if (cheak_Clear[0] == true && cheak_Clear[1] == true && cheak_Clear[2] == true && cheak_Clear[3] == true)
        {
            clearIN = true;
            clearART.SetActive(true);   clear.SetActive(true);
            Debug.Log("클리어");
            Invoke("Clear_Timer", Clear_time);
        }
    }
    public void Clear_Timer()
    {
        clear.SetActive(false);
    }
}