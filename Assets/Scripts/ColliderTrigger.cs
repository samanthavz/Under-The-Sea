using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    public UnityEvent FunctionToTrigger;
    void OnTriggerEnter(Collider other)
    {
       FunctionToTrigger.Invoke();
    }
}
