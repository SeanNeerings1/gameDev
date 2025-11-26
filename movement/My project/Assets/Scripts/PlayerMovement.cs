using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _horizontalInput;
    [SerializeField]private float _moveSpeed = 5f;
    [SerializeField] private float _jumpforce = 8;

    private bool _isFacingRight = false;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");

        if (_horizontalInput != 0f)
        {
            Debug.Log("Input ontvangen: " + _horizontalInput);
        }

        FlipSprite();
  
    {
        rb.linearVelocity = new Vector3(_horizontalInput * _moveSpeed, rb.linearVelocity.y);

        if (Mathf.Abs(rb.linearVelocity.x) > 0.01f)
        {
            Debug.Log("Speler beweegt. Velocity = " + rb.linearVelocity);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, _jumpforce);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, _jumpforce);
        }
    }
}

    void FlipSprite()
    {
        if (_isFacingRight && _horizontalInput < 0f || !_isFacingRight && _horizontalInput > 0f)
        {
            _isFacingRight = !_isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
}
