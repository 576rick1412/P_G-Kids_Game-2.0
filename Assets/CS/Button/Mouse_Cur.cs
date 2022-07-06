using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Cur : MonoBehaviour
{
    [SerializeField] Texture2D cursorIMG;

    private void Start()
    {
        Cursor.SetCursor(cursorIMG, Vector2.zero, CursorMode.ForceSoftware);
    }
}
