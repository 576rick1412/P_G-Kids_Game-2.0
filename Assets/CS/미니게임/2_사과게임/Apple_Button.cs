using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Apple_Button : MonoBehaviour
{

    public void Right_B()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        Apple_Manager oc = GameObject.Find("SCP-079").GetComponent<Apple_Manager>();
        Debug.Log("�ߺ�!! ����");
        sound.Right();
        oc.InClear++;
        oc.Creat_Canvas();
        oc.clear_void();
        gameObject.SetActive(false);
    }
    public void False_B()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        sound.Wrong();
        Debug.Log("�ߺ�!! ����");
    }

}