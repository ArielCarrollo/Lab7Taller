using System.Collections;
using UnityEngine;

public class DashAttack : MonoBehaviour, IAttackable
{
    public float dashSpeed = 10f;
    public float dashDuration = 0.2f;
    private bool isDashing = false;

    public void Attack(Vector2 position)
    {
        if (isDashing) return;

        Ray ray = Camera.main.ScreenPointToRay(position);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 direction = (hit.point - transform.position).normalized;
            StartCoroutine(Dash(direction));
        }
    }

    private IEnumerator Dash(Vector3 direction)
    {
        isDashing = true;
        float elapsed = 0f;

        while (elapsed < dashDuration)
        {
            transform.Translate(direction * dashSpeed * Time.deltaTime, Space.World);
            elapsed += Time.deltaTime;
            yield return null;
        }

        isDashing = false;
    }
}
