using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1.0f;

    Rigidbody rigidbodyPlayer;

    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Jump();
    }

    // ABSTRACTION
    private void Jump()
    {
        if (isGrounded && GameManager.Instance.isGameRunning)
        {
            rigidbodyPlayer.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
            isGrounded = true;
        else if (collision.gameObject.CompareTag("Projectile") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            GameManager.Instance.isGameRunning = false;
            FindObjectOfType<UIMain>().GameOver();
        }
    }
}
