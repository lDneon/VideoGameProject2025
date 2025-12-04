using UnityEngine;

public class GoalColorChange : MonoBehaviour
{
    public Color hitColor = Color.green;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            sr.color = hitColor;
        }
    }
}
