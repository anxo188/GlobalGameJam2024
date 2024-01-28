using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ReverseButtons : Event
{
    public UnityEngine.UI.Button left;
    public UnityEngine.UI.Button right;
    public override void startEvent()
    {
        (left.transform.position, right.transform.position) = (right.transform.position, left.transform.position);
    }
}
