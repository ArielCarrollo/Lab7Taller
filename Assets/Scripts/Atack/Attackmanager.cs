using UnityEngine;

public class AttackManager : MonoBehaviour
{
    public PlayerExample player;
    public BulletAttack bulletAttack;
    public ExplosionAttack explosionAttack;
    public DashAttack dashAttack;

    void Start()
    {
        // Establece una estrategia de ataque predeterminada
        player.SetAttackStrategy(bulletAttack);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            player.SetAttackStrategy(bulletAttack);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            player.SetAttackStrategy(explosionAttack);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            player.SetAttackStrategy(dashAttack);
        }
    }
}
