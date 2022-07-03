using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread_Manager : MonoBehaviour
{
    public GameObject THE_Object;
    public bool mouseIN = false;
    void Update()
    {

        InMouse();
        Bread_Cheak oc = GameObject.Find("GameCanvas").GetComponent <Bread_Cheak>();
        SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();

        if (mouseIN == true)
        {
            Vector3 screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100.0f);
            THE_Object.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);

            float Distance = Vector3.Distance(THE_Object.transform.position, gameObject.transform.position);

            if (Distance < 0.5f)
            {
                oc.cheak_Num++;
                sound.Right();
                oc.Clear_void();
                Destroy(gameObject);
            }
        }
    }

    public void InMouse()
    {
        if (Input.GetMouseButton(0))
        {
            mouseIN = true;
        }
        else mouseIN = false;
        return;
    }
}