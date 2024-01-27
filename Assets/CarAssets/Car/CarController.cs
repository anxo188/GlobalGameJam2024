using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Vector3 leftPosition;
    public Vector3 rightPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveRight()
    {
        this.transform.position = rightPosition;
    }

    public void moveLeft()
    {
        
        this.transform.position = leftPosition;
    }
}
