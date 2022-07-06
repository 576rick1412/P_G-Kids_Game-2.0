using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Apple_Manager : MonoBehaviour
{
    public int Rna;
    public int InClear;
    public int USE_Num;
    public GameObject[] In_Canvas;

    public bool clearIN = false;
    public GameObject clear;
    public float Clear_time;
    void Start()
    {
        InClear = 0;
        clear.SetActive(false);
        USE_Num = 0;

        for(int i = 0; i < In_Canvas.Length; i++)
        {
            In_Canvas[i].SetActive(false);
        }
        Creat_Canvas();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clearIN == true)
        {
            SceneManager.LoadScene("Main_Scene");
        }
    }
    public void Creat_Canvas()
    {
        switch(InClear)
        {
            case 0:
                In_Setting(InClear);
                break;
            case 1:
                In_Setting(InClear);
                break;
            case 2:
                In_Setting(InClear);
                break;
            case 3:
                In_Setting(InClear);
                break;
            case 4:
                In_Setting(InClear);
                break;
        }
    }
    public int In_Setting(int i)
    {
        Rna = Random.Range(1, In_Canvas.Length);
        if (USE_Num == Rna) Rna++;
        USE_Num = Rna;
        In_Canvas[Rna].SetActive(true);
        return 0;
    }
    public void clear_void()
    {
        if (InClear >= 5)
        {
            clearIN = true;
            clear.SetActive(true);
            Debug.Log("클리어"); Sound_Clear();
            Invoke("Clear_Timer", Clear_time);
        }
    }
    public void Clear_Timer()
    {
        clear.SetActive(false);
    }
    public void Sound_Clear()
    {
        SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();
        sound.Clear();
    }
}
