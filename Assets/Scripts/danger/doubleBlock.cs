using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class doubleBlock : MonoBehaviour
{
    private AudioSource audioSource;
    public float speed = 6f;
    private GameObject player;
    public AudioClip audioClip;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        audioSource = player.GetComponent<AudioSource>();
        double r = PlayerPrefs.GetInt("soundValue") * 0.01;
        float r2 = (float)r;
        audioSource.volume = r2;
    }

    private void Update()
    {
        int del = ScoreManager.Instance.GetScore();
        if (del > 0)
        {
            speed = speed + 0.01f / del;
        }
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<Player>(out Player player))
        {
            ScoreManager.Instance.SetScore(1);
            audioSource.PlayOneShot(audioClip);
            Destroy(gameObject);
        }
    }
}
