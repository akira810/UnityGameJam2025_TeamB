using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveBulletScript : MonoBehaviour
{
    [Serialize] public GameObject bullet;
    ShotBulletScript shotScript;

    GameObject newBullet;

    public float moveSpeed;
    public float destroyBulletSeconds;

    // Start is called before the first frame update
    void Start()
    {
        shotScript = bullet.GetComponent<ShotBulletScript>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBullet();
    }



    public void MoveBullet()
    {
        foreach (GameObject bullet in shotScript.bulletList)
        {
            if (bullet != null)
            {
                bullet.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                Destroy(bullet, destroyBulletSeconds);
            }
        }        
    }
}