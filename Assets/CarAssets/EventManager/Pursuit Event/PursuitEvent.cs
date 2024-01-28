using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PursuitEvent : Event
{
    public GameObject dinoPrefab;

    public GameObject poliPrefab;
    public Vector3 leftRoad;
    public Vector3 rightRoad;
    
    
    // Start is called before the first frame update
    public override void startEvent()
    {
        int drinkedBeersCount = PlayerPrefs.GetInt("drinkedBeersCount");
        if (drinkedBeersCount >= 0 && drinkedBeersCount < 25)
        {
            //POLI VA

            if (Random.Range(0, 2) == 0)
            {

                GameObject.Instantiate(poliPrefab, leftRoad, transform.rotation);
            }
            else
            {

                GameObject.Instantiate(poliPrefab, rightRoad, transform.rotation);
            }
        }
        else
        {
            //DINOTIME
            if (Random.Range(0, 2) == 0)
            {

                GameObject.Instantiate(dinoPrefab, leftRoad, transform.rotation);
            }else{
                
                GameObject.Instantiate(dinoPrefab, rightRoad, transform.rotation);
            }
        }
    } 
}
