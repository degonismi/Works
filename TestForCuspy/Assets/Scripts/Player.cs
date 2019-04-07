using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;

    private float force = 3.0f;
    private bool startGame;

    public GameObject Blocks;
    public GameObject StartPanel;
    public GameObject LosePanel;


    public Text LoseScore;
    public Text LoseAttempts;

    GameManager game;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        game = FindObjectOfType<GameManager>();
    }

    private void Start()
    {
        force = game.Force;
        rb.mass = game.Mass;
        startGame = false;
        rb.gravityScale = 0;
    }
    

    public void Jump()
    {
        if (startGame)
        {
            rb.velocity = Vector3.zero;
            rb.AddForce(transform.up * force, ForceMode2D.Impulse);
        }
        else
        {
            StartPanel.SetActive(false);
            startGame = true;
            rb.gravityScale = 1;
            Blocks.SetActive(true);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        LosePanel.SetActive(true);
        GameManager.IfLose();
        LoseScore.text = GameManager.BestScore + "\n" + GameManager.Score;
        LoseAttempts.text = "ATTEMPTS\n" + GameManager.LoseCount;
    }
    

}
