using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastPoke : MonoBehaviour
{

    // Apply a force to a rigidbody in the Scene at the point
    // where it is clicked.

    // The force with which the target is "poked" when hit.
    public float pokeForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.rigidbody != null)
                {
                    hit.rigidbody.AddForceAtPosition(ray.direction * pokeForce, hit.point);
                }
            }
        }
    }

}
