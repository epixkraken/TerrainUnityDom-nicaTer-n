public class Rotador : MonoBehaviour
{
    [SerializeField] private Vector3 _rotationSpeed = new Vector3(0, 50, 0);

    void Update()
    {
        // Esto hace que el objeto rote un poquito cada frame
        transform.Rotate(_rotationSpeed * Time.deltaTime);
    }
}
