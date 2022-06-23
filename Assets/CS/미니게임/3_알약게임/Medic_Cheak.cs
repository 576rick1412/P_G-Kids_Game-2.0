using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic_Cheak : MonoBehaviour
{
    public GameObject clear;
    private int claer_Num;
    public float Clear_time;

    private bool clear_macine = false;
    private void Start()
    {
        clear_macine = false;
        clear.SetActive(false);
    }
    void Update()
    {
        Medical_Manager check1 = GameObject.Find("빨간접시").GetComponent<Medical_Manager>();
        Medical_Manager check2 = GameObject.Find("노란접시").GetComponent<Medical_Manager>();
        Medical_Manager check3 = GameObject.Find("파란접시").GetComponent<Medical_Manager>();

        claer_Num = check1.setMedical.Length;

        if (check1.Medical_Num >= claer_Num &&
           check2.Medical_Num >= claer_Num &&
           check3.Medical_Num >= claer_Num && clear_macine == false)
        {
            Debug.Log("클리어");
            clear.SetActive(true);
            Invoke("clear_void", Clear_time);
            clear_macine = true;
        }
    }

    public void clear_void()
    {
        clear.SetActive(false);
    }
}
