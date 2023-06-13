using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumper : Enemy
{
    [SerializeField] private float probDoubleJump = 0.5f;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        doubleJump = true;
        Invoke("Jump", 0.5f);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    protected override void Jump()
    {
        base.Jump();

        float randomTimeDoubleJump = Random.Range(0.01f, 1.0f);
        if (!isGrounded && randomTimeDoubleJump > probDoubleJump && doubleJump)
        {
            Debug.Log("Double Jump");
            jumpForce /= 2;

            base.Jump();

            doubleJump = false;
            jumpForce *= 2;
        }

        float randomTime = Random.Range(minMaxRepeatJump[0], minMaxRepeatJump[1]);
        Invoke("Jump", randomTime);
    }
}
