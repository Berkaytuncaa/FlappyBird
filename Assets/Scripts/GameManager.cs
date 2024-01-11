using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    public GameObject pause;
    public GameObject start;
    public GameObject continueText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        continueText.SetActive(true);
        pause.SetActive(false);
        start.SetActive(true);
    }

    public void ContuniueGame()
    {
        Time.timeScale = 1;
        pause.SetActive(true);
        start.SetActive(false);
        continueText.SetActive(false);
    }

    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }
}
