using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimator : MonoBehaviour
{
    public Animator start;

    public void OnTriggerEnter2D(Collider2D other)
    {
        start.SetBool("start", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        start.SetBool("start", false);
    }
}
