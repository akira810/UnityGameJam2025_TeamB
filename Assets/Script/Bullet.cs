using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody rd;
    public float speed;   
    void Awake()
    {
      rd = GetComponent<Rigidbody>();
    }   
    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;//�e�ۂ��i�ޕ���
    }
    private void FixedUpdate()
    {
        rd.velocity = direction * speed;   
    }
    void OnCollisionEnter(Collision collision)
    {
        //�^�O�����m���ăv���C���[�̍U���^�O��������
        if (collision.gameObject.CompareTag("ATK"))
        {
            //���g���폜
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

}
