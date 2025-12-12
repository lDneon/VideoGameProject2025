using UnityEngine;
using System.Collections;

public class LevelGuard : MonoBehaviour
{
    [Header("Background Settings")]
    public Transform backgroundContainer;   
    public float backgroundHeight = 20.8f;   

    [Header("Player Settings")]
    public Transform player;                 
    public Transform playerSpawnPoint;     

    private int currentLevel = 0;
    private bool isTransitioning = false;    // prevent spamming triggers during move

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isTransitioning)
        {
            isTransitioning = true;
            currentLevel++;

            //loop game after level 5
            //if (currentLevel > 5)
                //currentLevel = 0;

            //calculating target positions
            float bgTargetY = (currentLevel - 1) * -backgroundHeight;
            Vector3 bgTargetPos = new Vector3(0, bgTargetY, 0);

            Vector3 playerTargetPos;
            if (playerSpawnPoint != null)
                playerTargetPos = playerSpawnPoint.position;
            else
                playerTargetPos = new Vector3(0, 0, 0); //adjust X/Y as needed)

            StartCoroutine(SmoothTransition(bgTargetPos, playerTargetPos, 0.6f));

            Debug.Log($"Moved to Level {currentLevel} Bird reset to start!");
        }

    }
    public void ChangeBackground()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            currentLevel++;

            if (currentLevel > 5)
                currentLevel = 1;

            //calculate target positions
            float bgTargetY = (currentLevel - 1) * -backgroundHeight;
            Vector3 bgTargetPos = new Vector3(0, bgTargetY, 0);

            Vector3 playerTargetPos = playerSpawnPoint.position;

            StartCoroutine(SmoothTransition(bgTargetPos, playerTargetPos, 0.6f));

            Debug.Log($"Changed to Level {currentLevel} (Score Trigger)");
        }
    }

    private IEnumerator SmoothTransition(Vector3 bgTargetPos, Vector3 playerTargetPos, float duration)
    {
        Vector3 bgStartPos = backgroundContainer.position;
        Vector3 playerStartPos = player.position;
        float time = 0;

        while (time < duration)
        {
            time += Time.deltaTime;
            float t = time / duration;
            t = t * t * (3f - 2f * t); // Smooth easing

           // Move background DOWN
           // backgroundContainer.position = Vector3.Lerp(bgStartPos, bgTargetPos, t);

            // Move player UP to start
            player.position = Vector3.Lerp(playerStartPos, playerTargetPos, t);

            yield return null;
        }

        // Snap to exact positions
        backgroundContainer.position = bgTargetPos;
        player.position = playerTargetPos;

        isTransitioning = false;
    }
}