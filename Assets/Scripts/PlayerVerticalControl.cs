using UnityEngine;

public class PlayerVerticalControl : MonoBehaviour
{
    [SerializeField] private float forwardSpeed = 3f;
    [SerializeField] private float verticalSpeed = 5f;
    [SerializeField] private float minY = -4f;
    [SerializeField] private float maxY = 4f;

    private Rigidbody2D rb;
    private float verticalInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 move = new Vector2(forwardSpeed, verticalInput * verticalSpeed) * Time.fixedDeltaTime;
        Vector2 nextPosition = rb.position + move;
        nextPosition.y = Mathf.Clamp(nextPosition.y, minY, maxY);

        rb.MovePosition(nextPosition);
    }
}
