using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15;
    private float turnSpeed = 80;
    private float horizontalInput;
    private float forwardInput;
    private float turnBackSpeed = 40;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // transform.Translate(Vector3.forward * Time.deltaTime * 5 * (forwardInput + 2));

        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        if(transform.localRotation.y <= 0)
        {
            transform.Rotate(Vector3.up, turnBackSpeed * Time.deltaTime);
        }
        if (transform.localRotation.y >= 0)
        {
            transform.Rotate(Vector3.down, turnBackSpeed * Time.deltaTime);
        }

        if (transform.position.x >= 10.1)
        {
            gameOver();
        }
        if (transform.position.x <= -9.8)
        {
            gameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gameOver();
    }

    private void gameOver()
    {
        this.gameObject.SetActive(false);
        Application.LoadLevel(Application.loadedLevel);
    }
}
