using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TankGame.Tank;
using TankGame.Event;

public class CamFollow : MonoBehaviour
{

    private TankView player;
    private Vector3 posDifference;

    void Start()
    {
        EventService.Instance.PlayerSpawn += GetPLayer;

    }

    private void GetPLayer()
    {
        player = TankService.Instance.GetCurrentPlayer();
        if (player != null)
        {
            player = TankService.Instance.GetCurrentPlayer();
            posDifference = player.transform.position - transform.position;
        }
        else
        {
            Debug.Log("player is null");
        }
    }


    private void LateUpdate()
    {
        if (player != null)
        {
            transform.position = player.transform.position;
        }
    }
}

