using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water_collide : MonoBehaviour
{
    public healed_text HealedText;
    private bool collected = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;

            GameObject healthObj = GameObject.FindGameObjectWithTag("BirdHealth");
            Bird_health health = healthObj.GetComponent<Bird_health>();
            health.Heal(5);


            HealedText.Show();
            Destroy(gameObject);

 
        }
    }
}
