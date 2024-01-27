using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCarBehaviour : MonoBehaviour
{
    public Light redLight;
    public Light blueLight;
    
    // Start is called before the first frame update
    void Start()
    {
        redLight.intensity = 0;
        StartCoroutine(switchLight());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * (0.9f * Time.deltaTime);
    }

    private IEnumerator switchLight()
    {
        while (true)
        {
            if (redLight.intensity == 0)
            {
                redLight.intensity = 10;
                blueLight.intensity = 0;
            }
            else
            {
                redLight.intensity = 0;
                blueLight.intensity = 10;
            }
            yield return new WaitForSeconds(1);
        }
    }
    
    
    
}
