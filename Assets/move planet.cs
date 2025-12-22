using UnityEngine;

public class OrbitalRevolution : MonoBehaviour
{
    [Header("Revolution Settings")]
    [SerializeField] public Transform centerObject; // center sphere

    [SerializeField] public float revolutionRadius = 5f; // revolution radius
    [SerializeField] public float revolutionSpeed = 30f; // revolution speed

    public Vector3 revolutionAxis = Vector3.up;

    [Header("Spin Settings")]
    [SerializeField] public float rotationSpeed = 30f; // spin speed

    void Awake()
    {
        // initialize
        if (centerObject != null)
        {
            // locate start position of revolution
            transform.position = centerObject.position + Vector3.right * revolutionRadius;
        }
    }

    void Update()
    {
        if (centerObject == null) return;

        // ratate around sun
        transform.RotateAround(
            centerObject.position,
            revolutionAxis,
            revolutionSpeed * Time.deltaTime
        );

        // rotate around Y axis
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
    }

}
