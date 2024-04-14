using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    int RotationSPeed = 100;
    private Transform itemTransform;

    // Start is called before the first frame update
    void Start()
    {
        itemTransform = this.GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        itemTransform.Rotate(RotationSPeed * Time.deltaTime, 0, 0);
    }
}
