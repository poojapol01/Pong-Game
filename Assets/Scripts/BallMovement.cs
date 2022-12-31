using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float movementSpeed;
    public float extraSpeedPerHit;
    public float maxExtraSpeed;

    int hitCounter = 0;

    void Start(){
        StartCoroutine(this.StartBall());
    }

    public IEnumerator StartBall(bool isStartingPlayer1 = true)
    {
        this.hitCounter = 0;
        yield return new WaitForSeconds(2);

        if(isStartingPlayer1){
            MoveBall(new Vector2(-1,0));
        }
        else
        {
            MoveBall(new Vector2(1,0));
        }
    }

    public void MoveBall(Vector2 dir){
        dir = dir.normalized;

        float speed = this.movementSpeed + this.hitCounter * this.extraSpeedPerHit;

        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed;
    }

    public void IncreaseHitCounter(){
        if(this.hitCounter * this.extraSpeedPerHit <= maxExtraSpeed){
            this.hitCounter++;
        }
    }

}