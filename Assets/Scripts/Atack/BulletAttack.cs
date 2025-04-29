using UnityEngine;

public class BulletAttack : MonoBehaviour, IAttackable
{
    public GameObject bulletPrefab;

    public void Attack(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 direction = (hit.point - transform.position).normalized;
            Instantiate(bulletPrefab, transform.position + direction, Quaternion.LookRotation(direction));
        }
    }
}
