using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBullet_Script : MonoBehaviour
{
    [SerializeField] GameObject newBullet;

    [SerializeField] GameObject player;
    Player_Script playerScript;

    Vector3 firstPos;

    // Start is called before the first frame update
    void Start()
    {
        playerScript = GetComponent<Player_Script>();

        
    }

    // Update is called once per frame
    void Update()
    {
        firstPos = player.transform.position;

        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(newBullet , firstPos, transform.rotation);


        }
    }
}
