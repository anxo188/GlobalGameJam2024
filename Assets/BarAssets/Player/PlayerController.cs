using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject drinkTriggerObject;
    public HUDBehaviour hud;
    public GameObject codo;
    public GameObject holdBeer;
    
    private DrinkTrigger drinkTrigger;
    private bool canDrink = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        drinkTrigger = drinkTriggerObject.GetComponent<DrinkTrigger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (drinkTrigger.hasBeer && canDrink)
            {
                canDrink = false;
                drinkTrigger.destroyBeer();
                hud.fillBar();
                StartCoroutine(moveArm());
            }
        }
    }

    private IEnumerator moveArm()
    {
        
        // 22º -> -60ª
        int animationDuration = 1000;//In miliseconds
        Vector3 initialRotation = new Vector3(22 ,codo.transform.localRotation.y,codo.transform.localRotation.z);
        Vector3 finalRotation = new Vector3(-60 ,codo.transform.localRotation.y,codo.transform.localRotation.z);

        
       /* for (int i = 0; i < animationDuration; i++)
        {
            if (i < (animationDuration / 2))
            {
                codo.transform.localRotation = Quaternion.Euler(Vector3.Lerp(initialRotation, finalRotation, i*2/100));
            }
            else
            {
                codo.transform.localRotation = Quaternion.Euler(Vector3.Lerp(finalRotation,initialRotation, i));
            }

            yield return new WaitForSeconds(0.001f);
        }*/
       holdBeer.SetActive(true);
       codo.transform.localRotation = Quaternion.Euler(finalRotation);
       yield return new WaitForSeconds(0.5f);
       codo.transform.localRotation = Quaternion.Euler(initialRotation);
       holdBeer.SetActive(false);
       
        canDrink = true;
        yield return null;
    }
}
