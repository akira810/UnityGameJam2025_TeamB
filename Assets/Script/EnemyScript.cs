using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0))

    float EnemyHp = 100.0f;
    float EnemyAtk = 100.0f;
    void Start()
    {
        transform.position = Vector2();
    }
    void Update()
    {
   


    }  

    //Cube‚ª“™‘¬ˆÚ“®‚·‚é
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
