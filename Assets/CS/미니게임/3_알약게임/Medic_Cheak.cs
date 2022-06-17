using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Medic_Cheak : MonoBehaviour
{
    private int claer_Num;
    void Update()
    {
        Medical_Manager check1 = GameObject.Find("빨간접시").GetComponent<Medical_Manager>();
        Medical_Manager check2 = GameObject.Find("노란접시").GetComponent<Medical_Manager>();
        Medical_Manager check3 = GameObject.Find("파란접시").GetComponent<Medical_Manager>();

        claer_Num = check1.setMedical.Length;

        if (check1.Medical_Num >= claer_Num &&
           check2.Medical_Num >= claer_Num &&
           check3.Medical_Num >= claer_Num)
        {
            Debug.Log("클리어");
            this.gameObject.SetActive(false);
        }
    }
}
