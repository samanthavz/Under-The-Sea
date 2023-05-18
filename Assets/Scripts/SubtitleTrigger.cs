using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SubtitleTrigger : MonoBehaviour
{
    public UnityEvent FunctionToTrigger;
    void OnTriggerEnter(Collider other)
    {
        FunctionToTrigger.Invoke();
        
        if (gameObject.GetComponent<SetActive>() != null)
        {
            gameObject.GetComponent<SetActive>().Active();
        }
        Destroy(this);
    }
}
