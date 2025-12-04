using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 //code not deleted for future reference (study)
public class LevelGuard : MonoBehaviour
{
    public int level = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        level++;
        Debug.Log("collision");
        GameObject background1 = GameObject.Find("L1_background");
      
        GameObject background2 = GameObject.Find("L2_background");
   
        GameObject background3 = GameObject.Find("L3_background");
 
        GameObject background4 = GameObject.Find("L4_background");
   
        GameObject background5 = GameObject.Find("L5_background");
        if (level > 5)
        {
            level = 1;
        }
            switch (level)
            {
                case 1:
                
                background1.SetActive(true);
               
                background2.SetActive(false);
                
                background3.SetActive(false);
                
                background4.SetActive(false);
           ;
                background5.SetActive(false);
                break;
            
            case 2:
              
                background1.SetActive(false);
            
                background2.SetActive(true);
              
                background3.SetActive(false);
     
                background4.SetActive(false);
           
                background5.SetActive(false);
                break;

            case 3:
                // Code to execute if expression matches value2
                break;
            case 4:
                // Code to execute if expression matches value2
                break;
            case 5:
                // Code to execute if expression matches value2
                break;
            // ... more cases
            default:

                    break;
            }


        }
}
*/



//private readonly SpriteRenderer LevelGuard.sr;  

public class LevelGuard : MonoBehaviour
{
    public int level = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))


        {


            Debug.Log(level);
            level++;
            GameObject background1 = GameObject.Find("L1_background");
            Debug.Log(background1);
            GameObject background2 = GameObject.Find("L2_background");

            GameObject background3 = GameObject.Find("L3_background");

            GameObject background4 = GameObject.Find("L4_background");

            GameObject background5 = GameObject.Find("L5_background");
            if (level > 5)
            {
                level = 1;
            }
            switch (level)
            {
                case 1:
                    background1.SetActive(false);

                    background2.SetActive(true);

                    background3.SetActive(false);

                    background4.SetActive(false);
                    ;
                    background5.SetActive(false);
                    break;

                case 2:
                    background1.SetActive(false);

                    background2.SetActive(false);

                    background3.SetActive(false);

                    background4.SetActive(true);

                    background5.SetActive(false);
                    break;

                case 3:
                    background1.SetActive(false);

                    background2.SetActive(false);

                    background3.SetActive(false);

                    background4.SetActive(true);

                    background5.SetActive(false);
                    break;

                case 4:
                    background1.SetActive(false);

                    background2.SetActive(false);

                    background3.SetActive(false);

                    background4.SetActive(false);

                    background5.SetActive(true);

                    break;
                case 5:
                    background1.SetActive(true);

                    background2.SetActive(false);

                    background3.SetActive(false);

                    background4.SetActive(false);

                    background5.SetActive(false);
                    break;
                default:

                    break;

            }
        }
    }
}
    

    
    
    
