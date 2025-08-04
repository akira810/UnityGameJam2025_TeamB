using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    Player_Script playerScript;

    float moveSpeed = 0.0f;
    Vector3 firstPos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        playerScript = player.GetComponent<Player_Script>();

        float randomPos = Random.Range(6.0f , 6.0f);
        firstPos = new Vector3( 20.0f,randomPos,0.0f);
        transform.position = firstPos;

        moveSpeed = 3.0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
