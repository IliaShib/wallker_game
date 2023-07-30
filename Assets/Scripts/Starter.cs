using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{
    public GameObject PlayerMenu;
    public GameObject Player;
    public GameObject Spawner;

    void Start()
    {
        PlayerMenu.SetActive(true);
        Player.SetActive(true);
        Spawner.SetActive(true);
    }
}
