using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private Vector3 move = new Vector3(0, 0, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > -5)
        {
            transform.Translate(move);
        }


        if (transform.position.z <= -24.99001)
        {
            Destroy(gameObject);
        }
    }
}
