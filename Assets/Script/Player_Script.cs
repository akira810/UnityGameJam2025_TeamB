//
//Playerの動きを制御するクラス
//
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UIElements;

public class Player_Script : MonoBehaviour
{
    public float moveSpeed = 0.0f;
    float stickLx = 0.0f;
    float stickLy = 0.0f;
    public int playerHp;  
    public int EnemyAtk;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        MoveCube();       
    }
    void OnCollisionEnter(Collision collision)
    {

        //
        if (collision.gameObject.CompareTag("Bullet"))
        {
            GetComponent<Rigidbody>();
            playerHp = playerHp - EnemyAtk;
        }
    }
    //プレイヤーの移動
    public void MoveCube()
    {
        stickLy = Input.GetAxis("Vertical");//Lスティックのy軸
        stickLx = Input.GetAxis("Horizontal");//Lスティックのx軸

        transform.Translate(Vector3.up * stickLy * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * stickLx * moveSpeed * Time.deltaTime);
    }    
}
