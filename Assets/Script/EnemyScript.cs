using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    
   int EnemyState = 0;
    float EnemyHp = 100.0f;
    public GameObject bullet;//弾丸を定めるパブリック
    public GameObject player;//プレイヤ―を設定
    public EnemyManager enemyManager;
    Vector2 targetPosition;//目的地
    Vector2 Straight;//Enemyのポジション    
    float duration = 0.3f;
    float t = 0.0f;
    Vector2 basePosition;  // 基準の位置を保持
    bool Moveflag = true;
   

    void Start()
    {
        player = GameObject.FindWithTag("Player");//プレイヤーを探す                                         
        basePosition = transform.position;  // 初期位置を基準位置に設定
    }
    void Update()
    {
        MoveEnemy();
        ManageState(); 
    }

    void OnCollisionEnter(Collision collision)
    {
        //タグを検知してプレイヤーの攻撃タグだったら
        if (collision.gameObject.CompareTag("ATK"))
        {
            //GetComponent<Player_Script>(Status);
            //EnemyHp = EnemyHp - playerATK;
            //スコア加算

            //アイテムを２分の１の確率で生成

        //自身を削除,同時に敵の出現数を1減らす
        enemyManager.SpawnCount--;           
        Destroy(gameObject);
        }
    }

    void MoveEnemy()
    {
        if (Moveflag == true)
        {
            float x = Random.Range(-4.0f, 8.0f);
            float y = Random.Range(-7.0f, 7.0f);

            targetPosition = new Vector2(x, y);
            EnemyState = Random.Range(0, 3);
            Moveflag = false;
        }       
    }
   
    void ManageState()
    {
        Straight = new Vector2(transform.position.x, transform.position.y);
                                             //周期　振幅
        float yOffset = Mathf.Sin(Time.time * 3f) * 4.0f;
        Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;//ターゲットとの距離差を出す
        t = Mathf.Min(t, 1f);//始点と終点の真ん中      
        float speed = 0.5f;
        t += Time.deltaTime / duration;

        switch (EnemyState)
        {
            case 0://直線で目的地に向かう。
               
                transform.Translate(direction * speed * Time.deltaTime);//直線的移動
                break;

            case 1://波状に目的地に向かう。
               
                transform.position = new Vector2(transform.position.x, basePosition.y + yOffset);//波状移動
                transform.Translate(direction * speed * Time.deltaTime);//直線的移動
                break;

            case 2://曲線で目的地に向かう。
                transform.position = Vector2.Lerp(transform.position, targetPosition, t);
                if (EnemyState == 2 && Vector2.Distance(transform.position, targetPosition) < 0.1f)
                {
                    Moveflag = true;
                    t = 0f;
                    basePosition = transform.position; // 次の波状の基準点にもなる
                }

                break;
        }
       
    }
}
