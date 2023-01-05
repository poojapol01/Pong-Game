using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    float x;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        if (c.gameObject.name == "RacketPlayer1")
        {
            x = 1;
        }
        if (c.gameObject.name == "RacketPlayer2")
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;
        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.BounceFromRacket(collision);
        }
        else if(collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Collision with WallLeft");
            this.scoreController.GoalPlayer2();
        }

        else if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Collision with WallRight");
            this.scoreController.GoalPlayer1();
        }
    }

}
