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
    Vector3 moveSpeed = Vector3.zero;

    
    // Start is called before the first frame update
    void Start()
    {
        InitCube();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();        
    }

    public void InitCube()
    {
        moveSpeed.x = 10.0f;
        moveSpeed.y = 10.0f;        
    }

    //プレイヤーの移動
    public void MoveCube()
    {
        moveSpeed.y = Input.GetAxis("Vertical");
        moveSpeed.x = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.up * moveSpeed.y * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed.x * Time.deltaTime);

        //position.y = transform.position.y;
        //position.x = transform.position.x;

    }
    

    
}
