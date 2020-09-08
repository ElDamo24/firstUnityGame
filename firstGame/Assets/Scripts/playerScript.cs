using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private float horizontalMovement;
    private float verticalMovement;
    [SerializeField]
    private float speedMovement;
    private float jumpVelocity;
    private bool onTheFloor;
    private Rigidbody rb;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        onTheFloor = true;
        speedMovement = 7f;
        jumpVelocity = 100f;
        score = 0;
}

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalMovement, 0, verticalMovement) * speedMovement * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && onTheFloor)
        {
            rb.velocity = new Vector3(0, jumpVelocity * Time.deltaTime, 0);
            onTheFloor = false;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speedMovement = 10f;
        }
        else
        {
            speedMovement = 7f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onTheFloor = true;
    }
}
