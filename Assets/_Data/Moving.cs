using UnityEngine;
using System.Collections;

public class Moving : MonoBehaviour
{
    public PlayerCtrl playerCtrl;
    public float jumpHeight = 0f;
    public float jumpSpeed = 0.15f;
    public float jumpMax = 0.16f;
    public float thrust = 7f;
    public Transform cameraTransform;

    private void Start()
    {
        this.playerCtrl = transform.parent.GetComponent<PlayerCtrl>();
        cameraTransform = Camera.main.transform;
    }

    protected void Update()
    {
        this.Jumping();
    }

    private void FixedUpdate()
    {
        this.MoveByRigidbody();
    }

    protected virtual void MoveByRigidbody()
    {
        if (GameManager.instance.gameOver) return;

        float x = InputManager.instance.horizontal; // Horizontal input
        float z = InputManager.instance.vertical; // Vertical input

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        Vector3 direction = forward * z + right * x;
        direction.y = jumpHeight;

        this.playerCtrl._rigidbody.AddForce(direction * this.thrust);
    }

    protected virtual void Jumping()
    {
        if (InputManager.instance.jump == 0) return;
        this.jumpHeight += this.jumpSpeed;
        Invoke("ResetJump", this.jumpMax);
    }

    protected virtual void ResetJump()
    {
        this.jumpHeight = 0f;
    }
}
