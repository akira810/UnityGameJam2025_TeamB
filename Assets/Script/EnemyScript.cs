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
    public GameObject bullet;//�e�ۂ��߂�p�u���b�N
    public GameObject player;//�v���C���\��ݒ�
    public EnemyManager enemyManager;
    Vector2 targetPosition;//�ړI�n
    Vector2 Straight;//Enemy�̃|�W�V����    
    float duration = 0.3f;
    float t = 0.0f;
    Vector2 basePosition;  // ��̈ʒu��ێ�
    bool Moveflag = true;
   

    void Start()
    {
        player = GameObject.FindWithTag("Player");//�v���C���[��T��                                         
        basePosition = transform.position;  // �����ʒu���ʒu�ɐݒ�
    }
    void Update()
    {
        MoveEnemy();
        ManageState(); 
    }

    void OnCollisionEnter(Collision collision)
    {
        //�^�O����m���ăv���C���[�̍U���^�O��������
        if (collision.gameObject.CompareTag("ATK"))
        {
            //GetComponent<Player_Script>(Status);
            //EnemyHp = EnemyHp - playerATK;
            //�X�R�A���Z

            //�A�C�e����Q���̂P�̊m���Ő���

        //���g��폜,�����ɓG�̏o������1���炷
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
                                             //�����@�U��
        float yOffset = Mathf.Sin(Time.time * 3f) * 4.0f;
        Vector2 direction = (targetPosition - (Vector2)transform.position).normalized;//�^�[�Q�b�g�Ƃ̋�������o��
        t = Mathf.Min(t, 1f);//�n�_�ƏI�_�̐^��      
        float speed = 0.5f;
        t += Time.deltaTime / duration;

        switch (EnemyState)
        {
            case 0://�����ŖړI�n�Ɍ������B
               
                transform.Translate(direction * speed * Time.deltaTime);//�����I�ړ�
                break;

            case 1://�g��ɖړI�n�Ɍ������B
               
                transform.position = new Vector2(transform.position.x, basePosition.y + yOffset);//�g��ړ�
                transform.Translate(direction * speed * Time.deltaTime);//�����I�ړ�
                break;

            case 2://�Ȑ��ŖړI�n�Ɍ������B
                transform.position = Vector2.Lerp(transform.position, targetPosition, t);
                if (EnemyState == 2 && Vector2.Distance(transform.position, targetPosition) < 0.1f)
                {
                    Moveflag = true;
                    t = 0f;
                    basePosition = transform.position; // ���̔g��̊�_�ɂ�Ȃ�
                }

                break;
        }
       
    }
}
