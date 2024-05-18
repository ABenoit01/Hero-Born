using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MoveLevel1 : MonoBehaviour
{

    public static int levelCounter = 1;

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
        levelCounter++;
        SceneManager.LoadScene(getCurrentLevelName());
        
    }
    private static string getCurrentLevelName()
    {
        return $"Level_{levelCounter}";
    }

}
