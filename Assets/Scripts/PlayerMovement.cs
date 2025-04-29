using UnityEngine;
public enum MovementType
{
    Cardinal2D,    // Movimiento en X/Y (2D)
    Cardinal3D,    // Movimiento en X/Z (3D)
    RotationXY     // Rotaci�n en X/Y
}
public class PlayerMovement : BasePlayerController, IMoveable
{
    [SerializeField] private MovementType movementType = MovementType.Cardinal2D;

    public MovementType CurrentMovementType => movementType;

    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float rotationSpeed = 100f;

    public void Move(Vector2 direction)
    {
        switch (movementType)
        {
            case MovementType.Cardinal2D:
                Move2D(direction);
                break;
            case MovementType.Cardinal3D:
                Move3D(direction);
                break;
            case MovementType.RotationXY:
                Rotate(direction);
                break;
        }

        Debug.Log($"Move {movementType} from {this.name}");
    }

    private void Move2D(Vector2 direction)
    {
        Vector3 movement = new Vector3(direction.x, direction.y, 0f);
        myRigidBody.linearVelocity = movement * moveSpeed;
    }

    private void Move3D(Vector2 direction)
    {
        Vector3 movement = new Vector3(direction.x, 0f, direction.y);
        myRigidBody.linearVelocity = movement * moveSpeed;
    }

    private void Rotate(Vector2 rotation)
    {
        float rotationX = rotation.y * rotationSpeed * Time.deltaTime;
        float rotationY = rotation.x * rotationSpeed * Time.deltaTime;

        transform.Rotate(rotationX, rotationY, 0f, Space.World);
    }
}
