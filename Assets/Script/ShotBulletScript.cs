using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotBulletScript : MonoBehaviour
{
    [SerializeField] GameObject newBullet;

    [SerializeField] GameObject player;
    Player_Script playerScript;

    Vector3 firstPos;
    public GameObject bullet;
    public List<GameObject> bulletList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<Player_Script>();

        
    }

    // Update is called once per frame
    void Update()
    {
        firstPos = player.transform.position;

        if (Input.GetKeyDown(KeyCode.J))
        {
            bullet = Instantiate(newBullet , firstPos, transform.rotation);
            bulletList.Add(bullet);

        }
    }
}
