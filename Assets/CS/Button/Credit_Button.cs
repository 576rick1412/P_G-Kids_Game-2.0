using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit_Button : MonoBehaviour
{
    public GameObject credit;
    public GameObject credit_2
        ;
    void Start()
    {
        credit.SetActive(false);
        credit_2.SetActive(false);
    }

    void Update()
    {
        
    }
    public void Credit_On()
    {
        Sound_USE();
        credit.SetActive(true);
        credit_2.SetActive(true);
    }

    public void Credit_Off()
    {
        Sound_USE();
        credit.SetActive(false);
        credit_2.SetActive(false);
    }
    public void Sound_USE()
    {
        SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();
        sound.Button();
    }

}
