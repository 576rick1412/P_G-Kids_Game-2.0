using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Animal_Manager : MonoBehaviour
{
    private float Null_Num = 0; // ��� ��ǥ ����

    [Header("�ܾ��")]
    public int OBJ_Num; // ������Ʈ �� , target_POS�� ������ �ʵ��� �� ����

    [Header("�ܾ� ����")]
    public int[] OBJ_order; // ������Ʈ ����
    public bool[] cheak; // ��� Ȯ�ο�
    public bool[] Null_cheak; // ��� Ȯ�ο�
    public int[] Null_cheak_Num; //��� Ȯ�ο�222

    public GameObject[] GameObject; //���ڹڽ�
    public GameObject[] target; // ��ĭ
    Vector2[] target_POS = new Vector2[5];

    public GameObject clear;
    public float Clear_time;
    public bool clearIN = false;
    void Start()
    {
        clear.SetActive(false);
        Null_Num = 1.7f; //ȭ�� ������ ����ؼ� ������ �ٲ�� ����
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
        // ���ڹڽ�(GameObject)�� ��ĭ��ǥ(target)�� OBJ_order[n]��°���� �Ÿ��� Null_Num���� �۴ٸ� true �ִٸ� false
        // �� ���ڹڽ����� Null_cheak_Num���� ������ ���� �ִ� ��ĭ�� ������ ������� ���, ���� ��ĭ�� �ٸ� ���ڹڽ��� �ִٸ� ������ġ�� ��ȯ, �ƴϸ� ��ĭ���� �̵�
        // return 0;���� �� ��� ��ĭ[0]�� ��ġ�� ��찡 ���� 100���� ��ȯ
        for (int j = 0; j < target.Length; j++)
        {
            float Distance = Vector3.Distance(GameObject[i].transform.position, target[OBJ_order[j]].transform.position);
            if (Distance < Null_Num)
            {
                if (Null_cheak[j] == true) { GameObject[i].transform.position = target_POS[i]; return 100; } //��ĭ�� ������Ʈ�� �ִٸ� ����
                else
                {
                    if (i == j) // �ùٸ� ĭ�� ��� 
                    { GameObject[i].transform.position = target[OBJ_order[i]].transform.position;   cheak[i] = true;    Null_cheak[j] = true; clear_cheak(); return j; }
                    else //ĭ�� ������ �ùٸ� ĭ�� �ƴҰ��
                    { GameObject[i].transform.position = target[OBJ_order[j]].transform.position;                       Null_cheak[j] = true;                return j; }
                }
            }
        }GameObject[i].transform.position = new Vector3(target_POS[i].x, target_POS[i].y, 100f); return 100;
    }

    public void clear_void()
    {
        clearIN = true;
        Debug.Log("Ŭ����");
        clear.SetActive(true);
        Invoke("end_clear", Clear_time);
    }
    public void end_clear()
    {
        clear.SetActive(false);
    }
}