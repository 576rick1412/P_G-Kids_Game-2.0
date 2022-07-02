using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Medic_Cheak : MonoBehaviour
{
    public GameObject clear;
    private int claer_Num;
    public float Clear_time;
    public bool clearIN = false;

    private bool clear_macine = false;
    private void Start()
    {
        clear_macine = false;
        clear.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clearIN == true)
        {
            SceneManager.LoadScene("Main_Scene");
        }

        Medical_Manager check1 = GameObject.Find("��������").GetComponent<Medical_Manager>();
        Medical_Manager check2 = GameObject.Find("�������").GetComponent<Medical_Manager>();
        Medical_Manager check3 = GameObject.Find("�Ķ�����").GetComponent<Medical_Manager>();

        claer_Num = check1.setMedical.Length;

        if (check1.Medical_Num >= claer_Num &&
           check2.Medical_Num >= claer_Num &&
           check3.Medical_Num >= claer_Num && clear_macine == false)
        {
            clearIN = true;
            Debug.Log("Ŭ����"); Sound_Clear();
            clear.SetActive(true);
            Invoke("clear_void", Clear_time);
            clear_macine = true;
        }
    }

    public void clear_void()
    {
        clear.SetActive(false);
    }
    public void Sound_Clear()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        sound.Clear();
    }
}
