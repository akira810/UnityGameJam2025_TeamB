using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;
    private Rigidbody rd;
    public float speed;
    public GameObject player;
    //public float EnemyAtk = 10.0f;
    void Awake()
    {
      rd = GetComponent<Rigidbody>();
    }   
    public void SetDirection(Vector2 dir)
    {
        direction = dir.normalized;//弾丸が進む方向
    }
    private void FixedUpdate()
    {
        rd.velocity = direction * speed;   
    }
    void OnCollisionEnter(Collision collision)
    {
        //タグを検知してプレイヤーの攻撃タグだったら
        if (collision.gameObject.CompareTag("ATK"))
        {
            //自身を削除
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
          // GetComponent<Player_Script>();
          //plaeyrHP=playerHP-ATK;
            Destroy(gameObject);
        }

    }

}
