using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float movingSpeed = 2.5f;
    [SerializeField] private float xLim = -2.5f;

    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector3.left * movingSpeed * Time.deltaTime);
        if (transform.position.x <= xLim)
            transform.position = startPos;
    }
}
