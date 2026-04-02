PlayerController
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 15f; // Sube esto si se siente lento
    [SerializeField] private float _jumpForce = 7f;
    [SerializeField] private Rigidbody _rb;

    private float _horizontal;
    private float _vertical;

    void Update()
    {
        // Leer teclado
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        // Salto con Impulso (solo una vez al presionar)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        Vector3 movement = new Vector3(_horizontal, 0, _vertical).normalized;

        if (movement.magnitude > 0.1f)
        {
            _rb.AddForce(movement * _speed, ForceMode.Force);
        }
        else
        {
            // SI NO ESTÁS PRESIONANDO NADA, FRENAMOS LA VELOCIDAD HORIZONTAL
            Vector3 currentVel = _rb.linearVelocity;
            // Mantener la gravedad (Y) pero reducir drásticamente X y Z
            _rb.linearVelocity = new Vector3(currentVel.x * 0.9f, currentVel.y, currentVel.z * 0.9f);
        }
    }
}
