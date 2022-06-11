using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puzzle_Manager : MonoBehaviour
{
    public int a; //퍼즐의 현재 이미지 상태 0이 정방향 상태
    public Sprite[] Puzzle; // 퍼즐 스프라이트

    public Image Image; // 퍼즐 십자선
    public bool cheak_Clear = false;

    void Start()
    {
        Image.sprite = Puzzle[a]; // 시작시 돌아가있는 퍼즐을 위한 한 줄
        if (a == 0) cheak_Clear = true;
    }

    public void PuzzleCheck()
    {
        //3이 넘어가면 a를 0으로 하고 다시 돌아감
        if (a > 2)
        {
            a = 0;
            // 0은 정방향이기에 true로 변경
            cheak_Clear = true;
        }
        else
        {
            // 이미지가 다시 돌아갔기에 false로 변경
            cheak_Clear = false;
            a++;
        }
        // 이미지 바꾸기
        Image.sprite = Puzzle[a];
    }
}