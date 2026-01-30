using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed;
    private float direction = 1f;
    public Camera gameCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * direction * Time.deltaTime;

        Vector3 screenPacerPos = gameCamera.WorldToScreenPoint(transform.position);
    }
}
