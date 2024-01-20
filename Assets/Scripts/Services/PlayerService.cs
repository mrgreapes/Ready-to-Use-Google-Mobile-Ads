using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerService : MonoBehaviour
{
    public Player player;


    public void SetPlayerName(string value)
    {
        player.name = value;
    }

    public string GetPlayerName()
    {
        return player.name;
    }
}
