using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public uint playerIndex;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ball ball = collision.GetComponent<Ball>();
        if(ball)
        {
            ball.ResetPosition();

            int currentScore = GameManager.instance.GetIndexPuntuacion((int)playerIndex);
            GameManager.instance.
                SetIndexPuntuacion((int)playerIndex, currentScore + 1);

            AdManager.instance.ShowAd();
        }
    }
}
