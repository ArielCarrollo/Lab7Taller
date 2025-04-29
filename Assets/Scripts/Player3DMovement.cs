using UnityEngine;

public class Player3DMovement : BasePlayerController, IAimable, IMoveable, IAttackable
{
    [SerializeField] private float moveSpeed = 5f;

    public Vector2 Position
    {
        get => _aimPosition;
        set => _aimPosition = value;
    }

    public void Move(Vector2 direction)
    {
        // Movimiento en 3D (X y Z, ignorando Y)
        Vector3 movement = new Vector3(direction.x, 0f, direction.y) * moveSpeed * Time.deltaTime;
        myRigidBody.MovePosition(transform.position + movement);

        Debug.Log($"Moving in 3D: X={direction.x}, Z={direction.y}");
    }

    public void Attack(Vector2 position)
    {
        Debug.Log("Attack from " + this.name);
    }
}
