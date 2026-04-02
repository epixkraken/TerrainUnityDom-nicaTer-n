Rotador Bola Agua
using UnityEngine;

public class RotadorBolaAgua : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed = new Vector3(0, 50, 0);

    void Update()
    {
        // Esto hace que el objeto rote un poquito cada frame
        transform.Rotate(_rotationSpeed * Time.deltaTime);
        // Agrega esto dentro del Update para que flote
        float nuevaY = Mathf.Sin(Time.time * 2f) * 0.5f;
        transform.Translate(0, nuevaY * Time.deltaTime, 0);
    }
}
