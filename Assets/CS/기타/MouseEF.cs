using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEF : MonoBehaviour
{
    private void Update()
    {
        Vector2 curPos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = curPos;
    }
}
