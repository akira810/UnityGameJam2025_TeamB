using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveBulletScript : MonoBehaviour
{   
    private Rigidbody rd;
    public float speed;  
    void Awake()
    {
        rd = GetComponent<Rigidbody>();
    }
    //public void SetDirection(Vector2 dir)
    //{
    //    direction = dir.normalized;//�e�ۂ��i�ޕ���
    //}
    private void FixedUpdate()
    {
        rd.velocity = Vector2.right * speed;
    }
    void OnCollisionEnter(Collision collision)
    {
        //�^�O�����m���ăv���C���[�̍U���^�O��������
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //���g���폜
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }

}
