﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScr : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.Score++;
    }
}
