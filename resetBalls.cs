using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetBalls : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
            Destroy(collision.gameObject);
    }
}
