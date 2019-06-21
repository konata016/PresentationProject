using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChase : MonoBehaviour
{
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスポインター追尾
        mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 20);
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
    }
}
