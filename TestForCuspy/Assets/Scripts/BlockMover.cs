using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMover : MonoBehaviour
{
    public static float Speed;

    GameManager game;

    private void Awake()
    {
        game = FindObjectOfType<GameManager>();
    }
    private void Start()
    {
        Speed = game.Speed;
    }

    void Update()
    {
        if (!GameManager.Lose)
        {
            if (transform.position.x > -10)
            {
                transform.position -= (transform.right * Time.deltaTime * Speed);
            }
            else
            {
                RePos();
            }
        }
        
    }

    private void OnEnable()
    {
        float rand = Random.Range(-1.0f, 4.0f);
        transform.position = new Vector3(transform.position.x, rand);
    }

    private void RePos()
    {
        float rand = Random.Range(-1.0f, 4.0f);
        transform.position = new Vector3(10.0f, rand);
    }

}
