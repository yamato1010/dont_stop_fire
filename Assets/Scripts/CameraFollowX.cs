using UnityEngine;

public class CameraFollowX : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float offsetX = 3f;
    [SerializeField] private float fixedY = 0f;

    private float fixedZ;

    private void Awake()
    {
        fixedZ = transform.position.z;
    }

    private void LateUpdate()
    {
        if (target == null) return;

        transform.position = new Vector3(
            target.position.x + offsetX,
            fixedY,
            fixedZ
        );
    }
}