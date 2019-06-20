using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitObject : MonoBehaviour
{
    public Text onCollisionEnter;
    public Text onCollisionExit;
    public Text onCollisionStay;

    public Text onTriggerEnter;
    public Text onTriggerExit;
    public Text onTriggerStay;


    int onCollisionEnterCount;
    int onCollisionExitCount;
    int onCollisionStayCount;

    int onTriggerEnterCount;
    int onTriggerExitCount;
    int onTriggerStayCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カウントのリセット
        if (Input.GetKeyDown(KeyCode.Q))
        {
            onCollisionEnterCount = 0;
            onCollisionExitCount = 0;
            onCollisionStayCount = 0;

            onTriggerEnterCount = 0;
            onTriggerExitCount = 0;
            onTriggerStayCount = 0;
        }

        //文字の表示
        onCollisionEnter.text = "onCollisionEnter" + onCollisionEnterCount;
        onCollisionExit.text = "onCollisionExit" + onCollisionExitCount;
        onCollisionStay.text = "onCollisionStay" + onCollisionStayCount;

        onTriggerEnter.text = "onTriggerEnter" + onTriggerEnterCount;
        onTriggerExit.text = "onTriggerExit" + onTriggerExitCount;
        onTriggerStay.text = "onTriggerStay" + onTriggerStayCount;
    }

    void OnCollisionEnter(Collision other)
    {
        onCollisionEnterCount++;
    }
    void OnCollisionExit(Collision other)
    {
        onCollisionExitCount++;
    }
    void OnCollisionStay(Collision other)
    {
        onCollisionStayCount++;
    }

    void OnTriggerEnter(Collider other)
    {
        onTriggerEnterCount++;
    }
    void OnTriggerExit(Collider other)
    {
        onTriggerExitCount++;
    }
    void OnTriggerStay(Collider other)
    {
        onTriggerStayCount++;
    }
}
