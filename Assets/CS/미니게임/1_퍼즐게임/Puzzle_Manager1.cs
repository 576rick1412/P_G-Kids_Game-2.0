using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[Serializable]
[HideInInspector]
public class Puzzle_S
{
    public Sprite[] Puzzle = new Sprite[4];
}

public class Puzzle_Manager1 : MonoBehaviour
{
    public Puzzle_S PS;

    public Puzzle_S[] Puzzle_Order = new Puzzle_S[4]; // 위에 클래스와 연결됨 

    public int[] Puzzle_Num; //퍼즐의 현재 이미지 상태 0이 정방향 상태

    public Image Image; // 퍼즐 십자선
    public bool[] cheak_Clear;

    void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            for(int j=0; j < 4; j++)
            {
                Image.sprite = Puzzle_Order[i].Puzzle[i];
                if (Puzzle_Num[i] == 0) cheak_Clear[i] = true;
            }
        }
    }

    public void Puzzle_Rotate_0()
    {
        PuzzleCheck(0);
    }

    public void Puzzle_Rotate_1()
    {
        PuzzleCheck(1);
    }

    public void Puzzle_Rotate_2()
    {
        PuzzleCheck(2);
    }
    public void Puzzle_Rotate_3()
    {
        PuzzleCheck(3);
    }


    public void PuzzleCheck(int i)
    {
        //3이 넘어가면 a를 0으로 하고 다시 돌아감
        if (Puzzle_Num[i] > 2)
        {
            Puzzle_Num[i] = 0;
            // 0은 정방향이기에 true로 변경
            cheak_Clear[i] = true;
        }
        else
        {
            // 이미지가 다시 돌아갔기에 false로 변경
            cheak_Clear[i] = false;
            Puzzle_Num[i]++;
        }
        // 이미지 바꾸기
        Image.sprite = Puzzle_Order[i].Puzzle[i];
    }
}