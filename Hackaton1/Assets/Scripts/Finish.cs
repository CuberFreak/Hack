using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    public Text score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
             score.text = "Ñ÷¸ò: 100";
        }
    }
}
