using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick_collider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject healthObj = GameObject.FindGameObjectWithTag("BirdHealth");
            Bird_health health = healthObj.GetComponent<Bird_health>();

            health.TakeDamage(10);
            Destroy(gameObject);
        }
    }
}
