using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMover : MonoBehaviour
{
    
    private float speed = 2;

    private Vector3 startPos = new Vector3(24.0f, 0, 0);

    private void Update()
    {
        if (!GameManager.Lose)
        {
            if (transform.position.x > -14)
            {
                transform.position -= (transform.right * Time.deltaTime * speed);
            }
            else
            {
                RePos();
            }
        }
        
    }

    private void RePos()
    {
        transform.position = startPos;
    }
}
