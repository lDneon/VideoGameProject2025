using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_collide : MonoBehaviour
{

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
