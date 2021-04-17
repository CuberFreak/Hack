using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class Game1Score : MonoBehaviour
{
    public float timeStart = 0;
    public float score;
    public Text scoreDisplay;
    public Text timerText;

    void Start()
    {
        scoreDisplay.text = timeStart.ToString();
    }

    public void Update()
    {
        timeStart += Time.deltaTime;
        score = Mathf.Round(timeStart);
        scoreDisplay.text = "Ñ÷¸ò: " + score.ToString();
    }

    
}
