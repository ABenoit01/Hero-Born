using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

   //did animation for movement instead lool


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision Platform)
    {
        gameObject.transform.parent = Platform.transform;
    }
    void OnCollisionExit()
    {
        gameObject.transform.parent = null;
    }


}


