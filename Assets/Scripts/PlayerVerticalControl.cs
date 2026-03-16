using UnityEngine;

public class PlayerVerticalControl : MonoBehaviour
{

    [SerializeField] private float verticalSpeed = 5f;
    [SerializeField] private float minY = -4f;
    [SerializeField] private float maxY = 4f;

    private Rigidbody2D rb;
    private float verticalInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 nextPosition = rb.position + Vector2.up * verticalInput * verticalSpeed * Time.fixedDeltaTime;
        nextPosition.y = Mathf.Clamp(nextPosition.y, minY, maxY);
        rb.MovePosition(nextPosition);
    }
}
