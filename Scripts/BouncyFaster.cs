using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class BouncyFaster : MonoBehaviour
{
    public float bounceStrength = 1f;

    private void OnCollisonEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null) //The collision must be with the ball
        {
            Vector2 normal = collision.GetContact(0).normal;
            ball.rigidbody.AddForce(-normal * bounceStrength, ForceMode2D.Impulse);
        }
    }
}
