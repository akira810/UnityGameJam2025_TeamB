using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject EnemyPrefab;//�G���߂�p�u���b�N
    public AudioClip sound;//�o�����̌��ʉ�
    public GameObject player;    
    public float start;//�n�߂Ƀt���O��ς���^�C�~���O
    public float interval;//�t���O���Ăѕς���^�C�~���O
    public int MaxSpawn;
    public int SpawnCount;

    void Start()
    {
        //�G�o���̊Ԋu�ƍŏ��̏o��
        InvokeRepeating("Count", start, interval);
    }
    public void Count()
    {
        if (SpawnCount < MaxSpawn)
        {
            //�G�̐��𐶐����邽�тɑ��₷
            SpawnCount++;
            //�G�𕡐�
            GameObject enemy = Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
        }
    }
}

