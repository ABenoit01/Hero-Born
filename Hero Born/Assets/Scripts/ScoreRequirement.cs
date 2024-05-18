using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRequirement : MonoBehaviour
{
    public TMP_Text messageText;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(Camera.main.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (TeleportLevel1.score == 0)
        {
            messageText.SetText("0/4");
        }
        if (TeleportLevel1.score == 1)
        {
            messageText.SetText("1/4");
        }
        if (TeleportLevel1.score == 2)
        {
            messageText.SetText("2/4");
        }
        if (TeleportLevel1.score == 3)
        {
            messageText.SetText("3/4");
        }
        if (TeleportLevel1.score == 4)
        {
            messageText.SetText("return to the middle");
        }
    }
    
       
}
