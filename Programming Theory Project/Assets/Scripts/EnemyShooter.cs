using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class EnemyShooter : Enemy
{
    [SerializeField] private float[] minMaxRepeatShoot;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        if (minMaxRepeatShoot.Length <= 0)
            minMaxRepeatShoot = new float[] { 1.0f, 5.0f };

        Invoke("Shoot", 3.0f);
        Invoke("Jump", 1.0f);
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    // POLYMORPHISM
    protected override void Shoot()
    {
        base.Shoot();

        float randomTime = Random.Range(minMaxRepeatShoot[0], minMaxRepeatShoot[1]);
        Invoke("Shoot", randomTime);
    }

    protected override void Jump()
    {
        base.Jump();

        float randomTime = Random.Range(minMaxRepeatJump[0], minMaxRepeatJump[1]);
        Invoke("Jump", randomTime);
    }
}
