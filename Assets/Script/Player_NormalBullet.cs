using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_NormalBullet : MonoBehaviour
{
    [SerializeField] GameObject newBullet;

    Vector3 moveSpeed = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InitPNormalBullet()
    {
        moveSpeed.x = 10.0f;
        moveSpeed.y = 10.0f;
    }

    public void MovePNormalBullet()
    {

    }
}
