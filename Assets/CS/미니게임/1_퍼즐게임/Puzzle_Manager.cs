using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puzzle_Manager : MonoBehaviour
{
    public int a; //������ ���� �̹��� ���� 0�� ������ ����
    public Sprite[] Puzzle; // ���� ��������Ʈ

    public Image Image; // ���� ���ڼ�
    public bool cheak_Clear = false;

    void Start()
    {
        Image.sprite = Puzzle[a]; // ���۽� ���ư��ִ� ������ ���� �� ��
        if (a == 0) cheak_Clear = true;
    }

    public void PuzzleCheck()
    {
        //3�� �Ѿ�� a�� 0���� �ϰ� �ٽ� ���ư�
        if (a > 2)
        {
            a = 0;
            // 0�� �������̱⿡ true�� ����
            cheak_Clear = true;
        }
        else
        {
            // �̹����� �ٽ� ���ư��⿡ false�� ����
            cheak_Clear = false;
            a++;
        }
        // �̹��� �ٲٱ�
        Image.sprite = Puzzle[a];
    }
}