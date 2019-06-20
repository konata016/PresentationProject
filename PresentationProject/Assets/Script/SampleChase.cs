using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleChase : MonoBehaviour
{
    public GameObject target;
    public Vector3 plusPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.transform.position;
        transform.position += plusPos;
    }
}
