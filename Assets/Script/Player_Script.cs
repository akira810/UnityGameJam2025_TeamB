//
//Player�̓����𐧌䂷��N���X
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

    
    // Start is called before the first frame update
    void Start()
    {
        InitCube();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();      
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            
        }
    }

    public void InitCube()
    {
              
    }

    //�v���C���[�̈ړ�
    public void MoveCube()
    {
        stickLy = Input.GetAxis("Vertical");//L�X�e�B�b�N��y��
        stickLx = Input.GetAxis("Horizontal");//L�X�e�B�b�N��x��

        transform.Translate(Vector3.up * stickLy * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * stickLx * moveSpeed * Time.deltaTime);
    }    
}
