using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float speed = 100f;

    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.position = Vector2.zero;
    }

    public void AddStartingForce()
    {   

        // 50-50 Chance of the ball going left or right
        float x = Random.value < 0.5f ? -1f : 1f;

        // 50-50 Chance of the ball moving up or down
        // Between 0.5 and 1.0 to ensure the ball does not move horizontally
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);

        //Apply initial Vector Force
        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * speed);
    }

    
}
