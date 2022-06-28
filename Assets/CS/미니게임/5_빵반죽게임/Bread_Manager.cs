using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread_Manager : MonoBehaviour
{
    private Vector2 Mouse_Pos;

    private void Update()
    {
        Mouse_Pos = Input.mousePosition;

        Bread_Cheak oc = GameObject.Find("GameCanvas").GetComponent <Bread_Cheak>();
        float Distance = Vector3.Distance(Mouse_Pos, this.gameObject.transform.position);
        if (Distance < 50)
        {
            oc.cheak_Num++;
            oc.Clear_void();
            Destroy(gameObject);
        }
    }
}