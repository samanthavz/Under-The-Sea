using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Interactable focus;

    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
       cam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                // Interactable interactable = hit.collider.GetComponent<Interactable>;
                // if (interactable != null)
                // {
                //     SetFocus(interactable);
                // }
            }
        }
    }

    void SetFocus (Interactable newFocus)
    {
        
    }
}
