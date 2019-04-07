using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScr : MonoBehaviour
{
    public GameObject StartPanel;
    public void OnMouseDown()
    {
        Debug.Log("sad");
        Time.timeScale = 1.0f;
        gameObject.SetActive(false);
        
    }
}
