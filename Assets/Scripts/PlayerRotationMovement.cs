using UnityEngine;

public class PlayerRotationMovement : BasePlayerController, IAimable, IMoveable, IAttackable
{
    [SerializeField] private float rotationSpeed = 100f;

    public Vector2 Position
    {
        get => _aimPosition;
        set => _aimPosition = value;
    }

    public void Move(Vector2 direction)
    {
        // Rotación en X e Y
        float rotationX = direction.y * rotationSpeed * Time.deltaTime;
        float rotationY = direction.x * rotationSpeed * Time.deltaTime;

        transform.Rotate(rotationX, rotationY, 0f, Space.World);

        Debug.Log($"Rotating: X={direction.x}, Y={direction.y}");
    }

    public void Attack(Vector2 position)
    {
        Debug.Log("Attack from " + this.name);
    }
}