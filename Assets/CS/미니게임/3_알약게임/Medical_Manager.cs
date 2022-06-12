using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medical_Manager : MonoBehaviour
{
    private float Null_Num = 0; // 드롭 좌표 범위

    public int Medical_Num = 0; //성공한 알약수

    public GameObject[] Medical;
    public GameObject[] Medical_positon;

    public GameObject[] setMedical;

    Vector2[] Medicalpos = new Vector2[5];

    void Start()
    {
        Null_Num = Screen.height / 12f;

        for (int i = 0; i < Medical.Length; i++)
        {
            Medicalpos[i] = Medical[i].transform.position;
            setMedical[i].SetActive(false);
        }
    }

    void Update()
    {
        switch (Medical_Num)
        {
            case 1:
                setMedical[0].SetActive(true);
                break;
            case 2:
                setMedical[1].SetActive(true);
                break;
            case 3:
                setMedical[2].SetActive(true);
                break;
            case 4:
                setMedical[3].SetActive(true);
                break;
            case 5:
                setMedical[4].SetActive(true);
                break;
        }
    }

    public void Drag_Medical_0()
    {
        Drag_Medical(0);
    }
    public void Drag_Medical_1()
    {
        Drag_Medical(1);
    }
    public void Drag_Medical_2()
    {
        Drag_Medical(2);
    }
    public void Drag_Medical_3()
    {
        Drag_Medical(3);
    }
    public void Drag_Medical_4()
    {
        Drag_Medical(4);
    }

    // =====================================================================

    public void Drop_Medical_0()
    {
        Drop_Medical(0);
    }
    public void Drop_Medical_1()
    {
        Drop_Medical(1);
    }
    public void Drop_Medical_2()
    {
        Drop_Medical(2);
    }
    public void Drop_Medical_3()
    {
        Drop_Medical(3);
    }
    public void Drop_Medical_4()
    {
        Drop_Medical(4);
    }
    public void Drag_Medical(int i)
    {
        Medical[i].transform.position = Input.mousePosition;
    }

    public void Drop_Medical(int i)
    {
        for (int j = 0; j < 5; j++)
        {
            // 알약(Medical)과 약접시좌표(Medical_Black)의 거리가 Null_Num보다 작다면 true 멀다면 false
            float Distance0 = Vector3.Distance(Medical[i].transform.position, Medical_positon[j].transform.position);
            if (Distance0 < Null_Num)
            { Destroy(Medical[i]); Medical_Num++; return; } 
        }
        Medical[i].transform.position = Medicalpos[i];
    }
}
