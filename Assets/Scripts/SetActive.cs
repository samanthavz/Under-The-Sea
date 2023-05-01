using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    [SerializeField]
    GameObject ActivateObject;

    [SerializeField]
    GameObject DisableObject;

    public void Active()
    {
        if (ActivateObject != null)
        {
            ActivateObject.SetActive(true);
        }
    }

    public void Disable()
    {
        if (DisableObject != null)
        {
            DisableObject.SetActive(false);
        }
    }
}
