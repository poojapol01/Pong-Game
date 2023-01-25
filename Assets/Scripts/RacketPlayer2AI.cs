using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2AI : MonoBehaviour
{
    public float movmentSpeed;
    public GameObject Ball;

    private void FixedUpdate()
    {
        if(Mathf.Abs(this.transform.position.y - Ball.transform.position.y)> 50)
        {
            if(transform.position.y > Ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * movmentSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * movmentSpeed;
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }
}
