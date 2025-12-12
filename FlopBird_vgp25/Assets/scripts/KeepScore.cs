using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeepScore : MonoBehaviour
{
    public int score = 0;
    public object_impact spawn_objects;
    public TMP_Text score_track;



    //public Object_impact spawner;        
    public GameObject NextLevelText;
    public GameObject Birdhouse;

    private int nextThreshold = 200;

    void Start()
    {

        UpdateUI();
        NextLevelText.SetActive(false);
        Birdhouse.SetActive(false);

    }

    public void AddScore(int amount)

    {
        score += amount;
        UpdateUI();

        if (score >= nextThreshold)

        {
            TriggerNextLevel();
            nextThreshold += 200;

        }

    }
    void HideNextLevelUI()
    {
        NextLevelText.SetActive(false);
        Birdhouse.SetActive(false);
    }

    void TriggerNextLevel()

    {
        //changing spawn difficulty
        spawn_objects.stickInterval = 1.5f;
        spawn_objects.waterInterval = 6.5f;

         NextLevelText.SetActive(true);
         Birdhouse.SetActive(true);

        LevelGuard levelGuard = FindObjectOfType<LevelGuard>();
        levelGuard.ChangeBackground();

        CancelInvoke(nameof(HideNextLevelUI));
        Invoke(nameof(HideNextLevelUI), 5f);

    }

    //called after background changes
    public void OnBackgroundChanged()
    {
        NextLevelText.SetActive(false);
        Birdhouse.SetActive(false);

    }

    void UpdateUI()
    {
       score_track.text = "Score: " + score;

    }
}