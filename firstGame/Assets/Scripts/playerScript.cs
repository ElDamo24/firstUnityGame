using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class playerScript : MonoBehaviour
{
    private float horizontalMovement;
    private float verticalMovement;
    [SerializeField]
    private GameObject jumpSound;
    [SerializeField]
    private Text lifeText;
    [SerializeField]
    private Text scoreText;
    public int life;
    private float speedMovement;
    private float speedRotation;
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
        scoreText.text = "SCORE: " + score.ToString();
        speedRotation = 100f;
        life = 100;
        lifeText.text = "LIFE: " + life.ToString();
}

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(0, 0, verticalMovement) * speedMovement * Time.deltaTime);
        transform.Rotate(new Vector3(0, horizontalMovement, 0) * speedRotation * Time.deltaTime);
        

        if (Input.GetKeyDown(KeyCode.Space) && onTheFloor)
        {
            Instantiate(jumpSound);
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

        scoreText.text = "Score: " + score.ToString();
        lifeText.text = "LIFE: " + life.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        onTheFloor = true;
    }
}
