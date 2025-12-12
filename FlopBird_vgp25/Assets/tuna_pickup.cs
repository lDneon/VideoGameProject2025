using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuna_pickup : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
        {
            GameObject scoreObj = GameObject.FindGameObjectWithTag("Score");
            KeepScore score = scoreObj.GetComponent<KeepScore>();

            score.AddScore(10);
            Destroy(gameObject);

        }
    }
}
