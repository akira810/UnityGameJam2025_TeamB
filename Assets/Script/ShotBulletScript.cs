using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBulletScript : MonoBehaviour
{
    public GameObject playerbulletPrefab;//�e�ۂ��߂�p�u���b�N
    public GameObject enemy;
    public AudioClip sound;//�ˏo���̌��ʉ�
    public float BulletSpeed;
    public float desprn;//�e�ۂ�������^�C�~���O   
    void Start()
    {
        //�v���C���[��T�m����
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
        Quaternion rotation = Quaternion.Euler(0f, 0f, 90f);//�e�ێˏo���̊p�x���X�O�x�ɂ��Ă܂������o���Ă���悤�Ɍ�����
                                                            //bullet�͔��˕�
        GameObject bullet = Instantiate(playerbulletPrefab, transform.position, Quaternion.identity);
        Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();//Rigidbody��e�ۂ���擾���Ďˏo���������߂�
       
        // �e���͎��R�ɐݒ�Adirection�͔��˕���
        bulletRb.AddForce(Vector2.right * BulletSpeed);
        // ���ˉ����o��
        AudioSource.PlayClipAtPoint(sound, transform.position);

        // �T�b��ɖC�e��j�󂷂�
        Destroy(bullet, desprn);
    }  
}
