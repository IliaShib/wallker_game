using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timeToSpawn, minTime, maxTime = 3;
    public GameObject double_blockPref;
    public GameObject right_blockPref;
    public GameObject left_blockPref;
    public GameObject right_thorns;
    public GameObject left_thorns;
    public GameObject moneyPref;
    private float timer;
    private int numDanger;
    private int chance;
    public float rst;

    private void Start()
    {
        timer = timeToSpawn;
    }

    private void Update()
    {
        if (timer <= 0)
        {
            numDanger = Random.Range(0, 5);
            timer = timeToSpawn;
            chance = 2;
            if (numDanger == 0)
            {
                GameObject doub_block = Instantiate(double_blockPref, transform.position, Quaternion.identity);
                if (chance == 2)
                {
                    GameObject money = Instantiate(moneyPref, transform.position, Quaternion.identity);
                    money.transform.position = new Vector3(-1f, money.transform.position.y, 0);
                }
            }
            if (numDanger == 1)
            {
                GameObject doub_block = Instantiate(right_blockPref, transform.position, Quaternion.identity);
                if (chance == 2)
                {
                    GameObject money = Instantiate(moneyPref, transform.position, Quaternion.identity);
                    money.transform.position = new Vector3(-3.6f, money.transform.position.y, 0);
                }
            }
            if (numDanger == 2)
            {
                GameObject doub_block = Instantiate(left_blockPref, transform.position, Quaternion.identity);
                if (chance == 2)
                {
                    GameObject money = Instantiate(moneyPref, transform.position, Quaternion.identity);
                    money.transform.position = new Vector3(2f, money.transform.position.y, 0);
                }
            }
            if (numDanger == 3)
            {
                GameObject doub_block = Instantiate(right_thorns, transform.position, Quaternion.identity);
                if (chance == 2)
                {
                    GameObject money = Instantiate(moneyPref, transform.position, Quaternion.identity);
                    money.transform.position = new Vector3(-3.0f, money.transform.position.y + 0.5f, 0);
                }
            }
            if (numDanger == 4)
            {
                GameObject doub_block = Instantiate(left_thorns, transform.position, Quaternion.identity);
                if (chance == 2)
                {
                    GameObject money = Instantiate(moneyPref, transform.position, Quaternion.identity);
                    money.transform.position = new Vector3(2f, money.transform.position.y + 0.5f, 0);
                }
            }
            int del = ScoreManager.Instance.GetScore();
            if (del > 0)
            {
                maxTime = maxTime - 1 / del;
            }
            timeToSpawn = Random.Range(minTime, maxTime);

        }

        else
        {
            timer -= Time.deltaTime;
        }
    }
}
