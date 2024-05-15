using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportLevel1 : MonoBehaviour
{
    public static float score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider myCollision)
    {
        if (score == 4)
        {
            SceneManager.LoadScene("Level_1");
        }
        else
        {
            return;
        }
    }
}
