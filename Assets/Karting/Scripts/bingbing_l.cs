using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bingbing_l : MonoBehaviour
{
    float rotSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, this.rotSpeed, 0);
    }
}
