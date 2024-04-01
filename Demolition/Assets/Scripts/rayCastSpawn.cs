using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastSpawn : MonoBehaviour
{

    // Apply a force to a rigidbody in the Scene at the point
    // where it is clicked.

    // The force with which the target is "poked" when hit.
    public  float pokeForce;
    CharacterController charCtrl;
    public GameObject rayIndicator;
    public GameObject Dynamite;

    private bool mouseLock;

    private void Start()
    {
        mouseLock = true;
    }
    void Update()
    {   
        

        RaycastHit hit;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        Screen.lockCursor = mouseLock;

        if (Input.GetMouseButtonDown(2))
        {
            mouseLock = !mouseLock;
        }


       

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.rigidbody != null)
            {
                //hit.rigidbody.AddForceAtPosition(ray.direction * pokeForce, hit.point);

                //dynamite spawn on click
                if (Input.GetMouseButtonDown(0))
                {
                    Instantiate(Dynamite, hit.point, Quaternion.identity);
                }
                    
                rayIndicator.transform.position = hit.point;
            }
        }

    }

}
