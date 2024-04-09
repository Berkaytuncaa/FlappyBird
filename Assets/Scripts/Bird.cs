using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] private float velocity;
    private Rigidbody2D rb;
    public GameManager gm;
    public GameObject deathScreen;
    public GameObject pauseScreen;

    public AudioSource src;
    public AudioClip sfx;

    public bool isDead;

    private void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            gm.UpdateScore();
            src.clip = sfx;
            src.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {
            isDead = true;
            Time.timeScale = 0;

            deathScreen.SetActive(true);
            pauseScreen.SetActive(false);

        }
    }
}
