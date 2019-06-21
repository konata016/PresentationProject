using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantObj : MonoBehaviour
{
    public float destroyTime;
    public GameObject instant;

    GameObject obj;
    List<GameObject> objs = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //オブジェクト生成
            obj = Instantiate(instant, transform) as GameObject;

            //作ったオブジェクトをリストに確保
            objs.Add(obj);
        }

        //オブジェクトデストロイ
        if (Input.GetMouseButtonDown(1))
        {
            //リストの先頭にいるオブジェクトを　destroyTime　後に消す
            Destroy(objs[0], destroyTime);

            //リストに確保されている先頭オブジェクトを消す
            objs.RemoveAt(0);
        }
    }
}
