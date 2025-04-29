using UnityEngine;

public class ExplosionAttack : MonoBehaviour, IAttackable
{
    public GameObject explosionPrefab;

    public void Attack(Vector2 position)
    {
        Ray ray = Camera.main.ScreenPointToRay(position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Instantiate(explosionPrefab, hit.point, Quaternion.identity);
        }
    }
}
