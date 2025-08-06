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
    //    direction = dir.normalized;//弾丸が進む方向
    //}
    private void FixedUpdate()
    {
        rd.velocity = Vector2.right * speed;
    }
    void OnCollisionEnter(Collision collision)
    {
        //タグを検知してプレイヤーの攻撃タグだったら
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //自身を削除
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }

}
