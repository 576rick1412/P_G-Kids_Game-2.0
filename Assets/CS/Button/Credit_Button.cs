using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credit_Button : MonoBehaviour
{
    public GameObject credit;
    void Start()
    {
        credit.SetActive(false);
    }

    void Update()
    {
        
    }
    public void Credit_On()
    {
        credit.SetActive(true);
    }

    public void Credit_Off()
    {
        credit.SetActive(false);
    }
}
