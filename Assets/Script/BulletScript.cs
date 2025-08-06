using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BulletScript : MonoBehaviour
{
    public GameObject bulletPrefab;//�e�ۂ��߂�p�u���b�N
    public GameObject player;
    public AudioClip sound;//�ˏo���̌��ʉ�
    public float BulletSpeed;   
    public float start;//�n�߂ɑł^�C�~���O
    public float interval;//�ł��Ă���ĂёłԊu
    public float flagstart;//�n�߂Ƀt���O��ς���^�C�~���O
    public float flaginterval;//�t���O���Ăѕς���^�C�~���O
    public float desprn;//�e�ۂ�������^�C�~���O
    private int BulletState;//�����_���ɕ����̃X�e�[�g���߂�
    public Vector2 direction;//����        
    bool bulletflag;
    void Start()
    {
        // �w�肵�����\�b�h���A�w�肵�����ԁi�P�ʁG�b�j����A�w�肵���Ԋu�i�P�ʁG�b�j�ŌJ��Ԃ����s����B
        InvokeRepeating("bullet", start, interval);
        InvokeRepeating("Flag", flagstart, flaginterval);//x�b��Ƀt���O��ς�y�b���ƂɃt���O��ύX����
        //�v���C���[��T�m����
        player = GameObject.FindWithTag("Player");
    }
    void Flag()
    {
        bulletflag = true;
    }   
    void bullet()
    {
        BulletManager();
        if (bulletflag == true)
        {
            BulletState = Random.Range(0, 2);
            bulletflag = false;
        }
        Quaternion rotation = Quaternion.Euler(0f, 0f, 90f);//�e�ێˏo���̊p�x���X�O�x�ɂ��Ă܂������o���Ă���悤�Ɍ�����
       //bullet�͔��˕�
        GameObject bullet = Instantiate(bulletPrefab, transform.position, rotation);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();//Rigidbody��e�ۂ���擾���Ďˏo���������߂�
        bullet.GetComponent<Bullet>().SetDirection(direction);

        // �e���͎��R�ɐݒ�Adirection�͔��˕���
        bulletRb.AddForce(direction * BulletSpeed);
        // ���ˉ����o��
           AudioSource.PlayClipAtPoint(sound, transform.position);

        // �T�b��ɖC�e��j�󂷂�
        Destroy(bullet, desprn);
    }

    void BulletManager()
    {
        //�����������_���ɒ�߂�
        switch(BulletState)
        {
            case 0:
                //�v���C���[�Ɍ����ĕ������߂�
                direction =  (player.transform.position - transform.position).normalized;
                break;
            case 1:
                //���[���h���W���N�_�Ƃ��ĕ��������ɒ�߂�
                direction = Vector2.left;
                break;
        }
    }
}