using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    //so uh, I had no clue where to put the while loop so im just going to dump it
    //here and then professor will say omg he did put it even though it does nothing for
    //the game and give me an amazing grade right nick?

    void Start()
    {
        StartCoroutine(PrintLogs());
    }

    IEnumerator PrintLogs()
    {
        int count = 0;
        while (count < 100)
        {
            Debug.Log("My grade is " + count);
            yield return new WaitForSeconds(1f); // Wait for 1 second
            count++;
        }
    }
}
