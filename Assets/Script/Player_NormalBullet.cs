using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_NormalBullet : MonoBehaviour
{
    [SerializeField] GameObject newBullet;

    Vector3 moveSpeed = Vector3.zero;
    bool move = false;
    // Start is called before the first frame update
    void Start()
    {
        InitPNormalBullet();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            move = true;
        }

        if (move == true)
        {
            MovePNormalBullet();
        }
    }
    public void InitPNormalBullet()
    {
        moveSpeed.x = 10.0f;
    }

    public void MovePNormalBullet()
    {        
        transform.position += moveSpeed;
        if (transform.position.x > 680.0f)
        {
            transform.Translate(Vector3.zero);
        }
    }
}
