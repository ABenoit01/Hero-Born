using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    int activeScene;
    // Start is called before the first frame update
    void Start()
    {
          int activeScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //just to reset scene "as in die" or falling out of bounds
    void OnTriggerEnter(UnityEngine.Collider other)
    {
        
        
            SceneManager.LoadScene("Level_6");
        
    }



}
