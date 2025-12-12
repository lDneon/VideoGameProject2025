using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;

    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
        UpdateBar();

    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateBar();
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateBar();
    }

    void UpdateBar()
    {
        float healthPercent = (float)currentHealth / maxHealth;
        transform.localScale = new Vector3(
            originalScale.x * healthPercent,
            originalScale.y,
            originalScale.z
        );

    }
}
