using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    Vector3 defPos;
    GameObject pos;

    // Start is called before the first frame update
    void Start()
    {
        defPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.position = defPos;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.position = pos.transform.position;
        }
    }
}
