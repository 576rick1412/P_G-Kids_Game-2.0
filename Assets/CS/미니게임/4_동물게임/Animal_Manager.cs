using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal_Manager : MonoBehaviour
{
    private float Null_Num = 0; // ��� ��ǥ ����

    [Header("�ܾ��")]
    public int OBJ_Num; // ������Ʈ �� , target_POS�� ������ �ʵ��� �� ����

    [Header("�ܾ� ����")]
    public int[] OBJ_order; // ������Ʈ ����
    public bool[] cheak; // ��� Ȯ�ο�
    
    public GameObject[] GameObject; //���ڹڽ�
    public GameObject[] target; // ��ĭ
    Vector2[] target_POS = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 5.6f; //ȭ�� ������ ����ؼ� ������ �ٲ�� ����

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
                { Debug.Log("Ŭ����"); }
                break;
            case 2:
                if (cheak[0] == true && cheak[1] == true)
                { Debug.Log("Ŭ����"); }
                break;

            case 3:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true)
                { Debug.Log("Ŭ����"); }
                break;

            case 4:
                if (cheak[0] == true && cheak[1] == true && cheak[2] == true && cheak[3] == true)
                { Debug.Log("Ŭ����"); }
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
        // ���ڹڽ�(GameObject)�� ��ĭ��ǥ(target)�� ward[n]�������� �Ÿ��� Null_Num���� �۴ٸ� true �ִٸ� false
        float Distance = Vector3.Distance(GameObject[i].transform.position, target[OBJ_order[i]].transform.position);
        if (Distance < Null_Num)
        {
            GameObject[i].transform.position = target[OBJ_order[i]].transform.position;
            cheak[i] = true;    return;
        }
        GameObject[i].transform.position = target_POS[i];
    }
}