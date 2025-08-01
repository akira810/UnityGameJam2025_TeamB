using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{

    void Start()
    {
        Camera.main.ViewportToWorldPoint(new Vector3(0, 0.5, 10));
       transform.position = Vector2.(0,0);
        float EnemyHp = 100.0f;
        float EnemyAtk = 100.0f;
        transform.position = Vector2();
    }
    void Update()
    {

        MoveEnemy();
        ManageState();
    }  

    void MoveEnemy()
    {

    }

    void ManageState()
    {
        switch(EnemyState)
        {
            case 0:



        }
    }
}
