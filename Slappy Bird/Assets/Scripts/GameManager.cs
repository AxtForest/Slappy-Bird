using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    private int score;
    public Player player;
    public Text scoreText;
    public GameObject button;
    public GameObject gameOver;
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        gameOver.SetActive(true);
        button.SetActive(true);
        Pause();
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();
        button.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Borular[] borular = FindObjectsOfType<Borular>();

        for (int i = 0; i<borular.Length; i++)
        {
            Destroy(borular[i].gameObject);
        }
    }
    public void Pause()
    {
        //Time.timeScale = 0f;
        player.enabled = false;
    }
}
