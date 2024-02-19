using UnityEngine;

public class InputMovement : MonoBehaviour
{
    [SerializeField] private Transform plane;
    [SerializeField] private Camera cameraMain;
    [SerializeField] private float moveSpeed;
    [Header("Max Recomended")]
    [Range(0,60)][SerializeField] private float intervalBorders;

    private Vector3 _startPosition;

    private void Start() => _startPosition = transform.position;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = cameraMain.nearClipPlane;
            Vector3 objectPosition = cameraMain.ScreenToWorldPoint(mousePosition);
            objectPosition.z = _startPosition.z;
            _startPosition = objectPosition;
        }

        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = cameraMain.nearClipPlane;
            Vector3 objectPosition = cameraMain.ScreenToWorldPoint(mousePosition);
            objectPosition.z = _startPosition.z;
            Vector3 movement = objectPosition - plane.position;
            movement.y = 0;
            movement = movement.normalized;
            Vector3 newPosition = plane.position + movement * moveSpeed * Time.deltaTime;

            if (newPosition.x < intervalBorders && newPosition.x > -intervalBorders)
                plane.position = newPosition;
        }
    }
}