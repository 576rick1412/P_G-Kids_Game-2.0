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

    public Puzzle_S[] Puzzle_Order = new Puzzle_S[4]; // ���� Ŭ������ ����� 

    public int[] Puzzle_Num; //������ ���� �̹��� ���� 0�� ������ ����

    public Image Image; // ���� ���ڼ�
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
        //3�� �Ѿ�� a�� 0���� �ϰ� �ٽ� ���ư�
        if (Puzzle_Num[i] > 2)
        {
            Puzzle_Num[i] = 0;
            // 0�� �������̱⿡ true�� ����
            cheak_Clear[i] = true;
        }
        else
        {
            // �̹����� �ٽ� ���ư��⿡ false�� ����
            cheak_Clear[i] = false;
            Puzzle_Num[i]++;
        }
        // �̹��� �ٲٱ�
        Image.sprite = Puzzle_Order[i].Puzzle[i];
    }
}