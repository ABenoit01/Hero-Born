using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using JetBrains.Annotations;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    
    // 1
    void OnCollisionEnter(Collision collision)
    {
      
        // 2
        if (collision.gameObject.name == "Player")
        {
            // 3
            Destroy(this.transform.gameObject);
            // 4
            Debug.Log("Item collected!");
            TeleportLevel1.score += 1;
            Debug.Log(TeleportLevel1.score);
        }
    }
}
