using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockEvent : Event
{
   public Vector3 rightLine;
   public Vector3 leftLine;
   public GameObject rock;
   public override void startEvent()
   {
      if (Random.Range(0, 2) == 0)
      {
         Debug.Log("Spawn Rock");
         GameObject.Instantiate(rock, rightLine, this.transform.rotation);
      }
      else
      {
         GameObject.Instantiate(rock, leftLine, this.transform.rotation);
      }
      
   }
}
