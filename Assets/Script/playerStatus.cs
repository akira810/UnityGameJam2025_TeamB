using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerStatus : MonoBehaviour
{
    public struct Status
    {
        public float atk;
        public float hp;
    }

    public enum EnPlayers
    {
        enPlayer_1P,
        enPlayer_2P,
        enPlayer_3P,
        enPlayer_4P,
        enPlayer_Num
    }

    Status[] player = new Status[(int)EnPlayers.enPlayer_Num];

    // Start is called before the first frame update
    void Start()
    {
        InitStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitStatus()
    {
        player[(int)EnPlayers.enPlayer_1P].hp = 100.0f;
        player[(int)EnPlayers.enPlayer_1P].atk = 10.0f;
    }


}
