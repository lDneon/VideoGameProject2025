using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_level : MonoBehaviour
{
    public GameObject[] backgrounds;
    private int levels = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateBackground();
    }
    public void NextBackground()
    {
        levels++;
        if (levels >= backgrounds.Length)
            levels = backgrounds.Length - 1;

        UpdateBackground();
    }
    void UpdateBackground()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            backgrounds[i].SetActive(i == levels);
        }
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
