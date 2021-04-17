using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerG1 : MonoBehaviour
{
    public GameObject InputeField;
    public GameObject Player;
    Vector3 temp1 = new Vector3(0.5f, 0, 0);
    Vector3 temp2 = new Vector3(-0.5f, 0, 0);
    Vector3 temp3 = new Vector3(0, 0.5f, 0);
    Vector3 temp4 = new Vector3(0, -0.5f, 0);
    Vector3 temp5 = new Vector3(0,0,0);
    Vector3 temp6 = new Vector3(0,0,0);

    private string text;
    void Start()
    {

    }
    public void Update()
    {
        Player.transform.position += temp5;
        temp5 = temp6;
    }
    public void walk()
    {
        string text = InputeField.GetComponent<Text>().text;
        string[] key1 = text.Split(' ');
        foreach (string k in key1)
        {
            temp5 = temp6;
            string switchcase = k;
            switch (switchcase)
            {
                case "1":
                    temp5 = temp1;
                    break;
                case "2":
                    temp5 = temp2;
                    break;
                case "3":
                    temp5 = temp3;
                    break;
                case "4":
                    temp5 = temp4;
                    break;
            }
        }
    }
}
