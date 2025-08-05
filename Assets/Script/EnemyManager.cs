using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyPrefab;//敵を定めるパブリック
    public AudioClip sound;//出現時の効果音
    public GameObject player;    
    public float start;//始めにフラグを変えるタイミング
    public float interval;//フラグを再び変えるタイミング
    public int MaxSpawn;
    public int SpawnCount;

    void Start()
    {
        //敵出現の間隔と最初の出現
        InvokeRepeating("Count", start, interval);
    }
    public void Count()
    {
        if (SpawnCount < MaxSpawn)
        {
            //敵の数を生成するたびに増やす
            SpawnCount++;
            //敵を複製
            GameObject enemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
        }
    }
}

