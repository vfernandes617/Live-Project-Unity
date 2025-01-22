using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public Player player;
    public Spawn spawner;
    public TextMeshProUGUI scoreText;
    public Scene gameOver;
    private Vector3 initialPosition;
    public int score { get; private set; } = 0;

    void Start()
    {
        // Save the player's initial state
        initialPosition = transform.position;

    }

    void Update()
    {
        // For demonstration, pressing "R" will reset the player
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetPlayer();
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }


    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();




        Time.timeScale = 1f;
        player.enabled = true;
        Moutain[] moutains = FindObjectsOfType<Moutain>();

        for (int i = 0; i < moutains.Length; i++)
        {
            Destroy(moutains[i].gameObject);
        }
    }

    public void GameOver()
    {


        SceneManager.LoadScene("EndScene", LoadSceneMode.Single);
        ResetPlayer(); // Reset the player after game over
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
    void ResetPlayer()
    {
        // Reset position
        transform.position = initialPosition;
    }
}