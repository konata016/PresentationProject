using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetpMove : MonoBehaviour
{
    public Text txt;

    public GameObject aPos;
    public GameObject bPos;

    public float speed;

    Vector3 targetPos;
    int moveMode;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = bPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //移動のモードを変える
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (moveMode < 2) moveMode++;
            if (moveMode == 2) moveMode = 0;
        }

        //キー入力
        if (Input.GetAxis("Horizontal") > 0) targetPos = bPos.transform.position;
        if (Input.GetAxis("Horizontal") < 0) targetPos = aPos.transform.position;

        //移動処理
        switch (moveMode)
        {
            case 0:
                transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
                break;

            case 1:
                transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
                break;
        }

        //テキスト表示
        switch (moveMode)
        {
            case 0:txt.text = "Q:Vector3.MoveTowards";break;
            case 1:txt.text = "Q:Vector3.Lerp"; break;
        }
    }
}
