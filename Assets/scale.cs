using UnityEngine;

public class ScalePulse : MonoBehaviour
{
    [Header("Scale Settings")]
    [SerializeField] private float targetScale = 1.5f; // target scale
    [SerializeField] private float scaleSpeed = 0.5f;  // scale speed

    private Vector3 originalScale; 

    void Awake()
    {
        // save original size
        originalScale = transform.localScale;
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time * scaleSpeed, 1f);

        Vector3 target = Vector3.Lerp(originalScale, originalScale * targetScale, t);

        transform.localScale = target;
    }
}
