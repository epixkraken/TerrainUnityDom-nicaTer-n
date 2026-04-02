Follow Player:
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Sphere;
    // Esta variable te permite alejar la cámara
    // X: a los lados, Y: altura, Z: atrás/adelante
    public Vector3 offset = new Vector3(0, 5, -10); 

    void LateUpdate() // Usamos LateUpdate para que la cámara siga a la bola después de que se mueva
    {
        if (Sphere != null)
        {
            // Posición de la bola + la distancia que queramos
            transform.position = Sphere.transform.position + offset;
            
            // Esto hace que la cámara siempre apunte a la bola
            transform.LookAt(Sphere.transform.position);
        }
    }
}
