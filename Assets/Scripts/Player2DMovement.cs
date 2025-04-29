using UnityEngine;

public class Player2DMovement : BasePlayerController, IAimable, IMoveable, IAttackable
{
    [SerializeField] private float moveSpeed = 5f;

    public Vector2 Position
    {
        get => _aimPosition;
        set => _aimPosition = value;
    }

    public void Move(Vector2 direction)
    {
        // Movimiento en 2D (X e Y)
        Vector3 movement = new Vector3(direction.x, direction.y, 0f) * moveSpeed * Time.deltaTime;
        myRigidBody.MovePosition(transform.position + movement);

        Debug.Log($"Moving in 2D: X={direction.x}, Y={direction.y}");
    }

    public void Attack(Vector2 position)
    {
        Debug.Log("Attack from " + this.name);
    }
}
