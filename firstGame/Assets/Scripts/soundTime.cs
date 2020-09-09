using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTime : MonoBehaviour
{
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0.9f;
        Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
