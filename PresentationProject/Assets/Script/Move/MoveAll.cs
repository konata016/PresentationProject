using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class MoveAll : MonoBehaviour
{
    public Text Txt;
    public float speed = 10f;

    Rigidbody rb;
    CharacterController controller;

    Vector3 move;

    int moveMode;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        GetComponent<CharacterController>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //移動のモードを変える
        if (Input.GetKeyDown(KeyCode.Q))
        {
            
            if (moveMode < 6) moveMode++;
            if (moveMode == 6) moveMode = 0;

            //キャラクターコントローラーを使うとき用やつ
            if (moveMode == 3 || moveMode == 4)
            {
                GetComponent<CharacterController>().enabled = true;
            }
            else GetComponent<CharacterController>().enabled = false;
        }

        //キー入力
        move.x = Input.GetAxis("Horizontal") * speed;
        move.z = Input.GetAxis("Vertical") * speed;


        switch (moveMode)
        {
            //トランスフォーム移動
            case 0: transform.Translate(move * Time.deltaTime); break;

            //アッドフォース移動
            case 1: rb.AddForce(move); break;

            //ベクトル移動
            case 2: rb.velocity = move; break;
            
            //キャラクターコントローラー移動1
            case 3: controller.SimpleMove(move); break;

            //キャラクターコントローラー移動2
            case 4: controller.Move(move * Time.deltaTime);break;

            //アッドフォース加速無
            case 5: rb.AddForce(speed * (move - rb.velocity)); break;

            default: break;
        }


        //テキスト表示
        switch (moveMode)
        {
            case 0: Txt.text = "Q:transform.Translate"; break;
            case 1: Txt.text = "Q:rb.AddForce"; break;
            case 2: Txt.text = "Q:rb.velocity"; break;
            case 3: Txt.text = "Q:controller.SimpleMove"; break;
            case 4: Txt.text = "Q:controller.Move"; break;
            case 5: Txt.text = "Q:アッドフォース加速無"; break;
            default: break;
        }
    }
}
