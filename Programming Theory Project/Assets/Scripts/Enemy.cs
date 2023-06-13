using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected GameObject projectilePrefab;
    [SerializeField] protected float speed = 2.5f;
    [SerializeField] protected float jumpForce = 10.0f;
    [SerializeField] protected float[] minMaxRepeatJump;
    [SerializeField] private float xLim = -20.0f;

    public float score = 1.0f;

    Rigidbody rbEnemy;

    protected bool isGrounded = true;
    protected bool doubleJump = false;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        rbEnemy = GetComponent<Rigidbody>();

        if (minMaxRepeatJump.Length <= 0)
            minMaxRepeatJump = new float[] { 1.0f, 5.0f };
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        if (GameManager.Instance.isGameRunning)
        {
            transform.Translate(-Camera.main.transform.right * speed * Time.deltaTime, Space.World);
            if (transform.position.x < xLim)
            {
                Destroy(gameObject);
                FindObjectOfType<UIMain>().SetScore(++GameManager.Instance.score);
            }
        }
    }

    protected virtual void Jump()
    {
        if ((isGrounded || doubleJump) && GameManager.Instance.isGameRunning)
        {
            rbEnemy.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    protected virtual void Shoot()
    {
        if (projectilePrefab != null && GameManager.Instance.isGameRunning)
            Instantiate(projectilePrefab, transform);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = true;
            doubleJump = true;
        }
    }
}
