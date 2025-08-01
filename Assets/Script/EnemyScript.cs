using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    Vector2 startPosition = Vector2.zero;
    float moveSpeed = 0.0f;
    float downs = -400.0f;
    float ups = 400.0f;
    float genkaiy = -670f;
    float genkaix = 670f;

    bool frag = false;

    float EnemyHp = 100.0f;
    float EnemyAtk = 100.0f;
    void Start()
    {
        Camera.main.transform.position = startPosition;
        startPosition -= Vector2.down * 1.5f * Time.deltaTime;

        moveSpeed = 2.5f;
        downs = -6.5f;
        ups = 6.5f;
    }
    void Update()
    {
        float time = Time.deltaTime * 60;
        //3�b���߂����瑬�x��ς���
        if (time > 3.0f)
        {
            moveSpeed = moveSpeed * 2;
        }
        else
        {
            moveSpeed = moveSpeed * 1;
        }
        InitCube();
        MoveCube();
    }

    //Cube�������ݒ肷��

    void InitCube()
    {
        transform.position = startPosition;
    }

    //Cube�������ړ�����
    void MoveCube()
    {
        float time = Time.deltaTime * 60;
        if (transform.position.x <= -100)
        {
            if (frag == false)
            {
                transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

                //����̋�����i��ł�����
                if (transform.position.y <= downs)
                {
                    frag = true;
                }
            }
            else
            {
                transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);

                if (transform.position.y >= ups)//
                {
                    frag = false;
                }
            }
            if (time >= 6)//�b����6�b�ȏソ������
            {
                Destroy(gameObject);//���g������
            }
        }
    }
}
