using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explode : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 10.0F;
    public GameObject explosionRadius;

    void Start()
    {
        explosionRadius = GameObject.FindObjectOfType<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 explosionRadiusScale = new Vector3(radius, radius, radius);
        explosionRadius.transform.localScale = explosionRadiusScale;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Detonate();
        }

    }

    private void Detonate()
    {
        //dynamically changes the radius indicator of the explosion
        Vector3 explosionPos = transform.position;

        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
        }
    }
}
