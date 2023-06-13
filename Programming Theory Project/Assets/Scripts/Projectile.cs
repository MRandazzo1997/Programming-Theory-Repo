using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float shootingForce = 10.0f;

    Rigidbody rbProjectile;

    // Start is called before the first frame update
    void Start()
    {
        rbProjectile = GetComponent<Rigidbody>();
        rbProjectile.AddForce(-Camera.main.transform.right * shootingForce, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
            Destroy(gameObject);
    }
}
