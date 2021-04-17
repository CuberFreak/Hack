using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartOpenDialogue : MonoBehaviour
{
    public Animator startOpen;

    public void OnTriggerEnter2D(Collider2D other)
    {
        startOpen.SetBool("startOpen", true);
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        startOpen.SetBool("startOpen", false);
    }
}
