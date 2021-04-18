using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wintext : MonoBehaviour
{
    [SerializeField]
    private GameObject winText;
    public Text score;
    void Start()
    {
        winText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (blockShema.locked && bl1.locked && bl2.locked && bl3.locked && bl4.locked)
        {
            winText.SetActive(true);
            score.text = ("Ñ÷¸ò: 200");
        }
    }
}
