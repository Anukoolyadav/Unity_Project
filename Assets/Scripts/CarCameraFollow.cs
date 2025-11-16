using UnityEngine;

public class CarCameraFollow : MonoBehaviour
{
    public Transform target;        // The car
    public Vector3 offset = new Vector3(0, 5, -12);
    public float smoothSpeed = 5f;

    private void FixedUpdate()
    {
        if (target == null) return;

        Vector3 desiredPos = target.position + target.transform.TransformDirection(offset);
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed * Time.fixedDeltaTime);

        transform.position = smoothedPos;

        transform.LookAt(target);
    }
}

