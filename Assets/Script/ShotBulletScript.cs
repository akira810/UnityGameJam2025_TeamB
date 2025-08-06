using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBulletScript : MonoBehaviour
{
    public GameObject playerbulletPrefab;//弾丸を定めるパブリック
    public GameObject enemy;
    public AudioClip sound;//射出時の効果音
    public float BulletSpeed;
    public float desprn;//弾丸が消えるタイミング   
    void Start()
    {
        //プレイヤーを探知する
        enemy = GameObject.FindWithTag("Enemy");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }
    }

    void Shoot()
    { 
        Quaternion rotation = Quaternion.Euler(0f, 0f, 90f);//弾丸射出時の角度を９０度にしてまっすぐ出しているように見せる
                                                            //bulletは発射物
        GameObject bullet = Instantiate(playerbulletPrefab, transform.position, Quaternion.identity);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();//Rigidbodyを弾丸から取得して射出方向を決める
       
        // 弾速は自由に設定、directionは発射方向
        bulletRb.AddForce(Vector2.right * BulletSpeed);
        // 発射音を出す
        AudioSource.PlayClipAtPoint(sound, transform.position);

        // ５秒後に砲弾を破壊する
        Destroy(bullet, desprn);
    }  
}
