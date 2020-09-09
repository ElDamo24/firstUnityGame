using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float speed;
    private playerScript playerScore;
    [SerializeField]
    private GameObject coinSound;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = FindObjectOfType<playerScript>();
        speed = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.down, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(coinSound);
            Destroy(this.gameObject);
            playerScore.score += 5;
        }
    }
}
