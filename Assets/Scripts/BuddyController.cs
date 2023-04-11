using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuddyController : MonoBehaviour
{
    private Transform player;
    private Vector3 offset;
   
    void Start()
    {
        offset = new Vector3(3, 1, 3);
        player = GameObject.FindWithTag("Player").transform;
        
    }

    void Update()
    {
        transform.LookAt(player.position);

        if((transform.position - player.position).magnitude > 2f)
        {
            transform.Translate(0.0f, 0.0f, Time.deltaTime * 3.0f);
        }
    }


//     void LateUpdate () {
//      transform.position = Vector3.Lerp(transform.position, player.position + offset, Time.deltaTime * 100);
//      transform.rotation = Quaternion.Lerp(transform.rotation, player.rotation, Time.deltaTime * 100);
//  }

}
