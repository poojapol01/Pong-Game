using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{
    public float movementSpeed;

    public void FixedUpdate(){
        float v = Input.GetAxisRaw("Vertical1");

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(0, v) * movementSpeed;
    }
}
