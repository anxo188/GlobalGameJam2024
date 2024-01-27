using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class DrinkTrigger : MonoBehaviour
{
    public bool hasBeer = false;

    private GameObject myBeer;

    public Light light;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        hasBeer = true;
        myBeer = other.gameObject;
        StartCoroutine(blinkLight());
    }

    public void OnCollisionExit(Collision other)
    {
        hasBeer = false;
        myBeer = null;
    }

    public void destroyBeer()
    {
        GameObject.Destroy(myBeer);
        myBeer = null;
        hasBeer = false;
    }

    private IEnumerator blinkLight()
    {
        light.intensity = 7;
        yield return new WaitForSeconds(0.5f);
        light.intensity = 25;
        yield return null;
    }
}
