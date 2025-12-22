using UnityEngine;

public class RotateSphere : MonoBehaviour
{
    [Header("Rotate Settings")]
    [SerializeField] private float rotationSpeed = 30f; // 30 degrees per second

    void Update() =>
        // rotate around Y axis
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f);
}
