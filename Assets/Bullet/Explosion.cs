using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 5f;
    public float damage = 50f;

    void Start()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in colliders)
        {
            // Aplicar daño a los objetos afectados
            // Ejemplo: nearbyObject.GetComponent<Health>()?.TakeDamage(damage);
        }
        // Agregar efectos visuales o de sonido si es necesario
        Destroy(gameObject, 2f);
    }
}
