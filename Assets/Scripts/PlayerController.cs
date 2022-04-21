using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerActionControls playerActionControls;
    private Animator animator;

    [SerializeField]
    private float speed;

    public int room;

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();
        animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }

    private void Move()
    {
        // Read movement value
        float horizontalMovementInput = playerActionControls.Land.MoveHorizontal.ReadValue<float>();
        float verticalMovementInput = playerActionControls.Land.MoveVertical.ReadValue<float>();
        // move player
        Vector3 currentPosition = transform.position;
        currentPosition.x += horizontalMovementInput * speed * Time.deltaTime;
        currentPosition.y += verticalMovementInput * speed * Time.deltaTime;
        transform.position = currentPosition;

        // Animation
        if (horizontalMovementInput != 0) animator.SetBool("walking", true);
        else if (horizontalMovementInput != 0) animator.SetBool("walking", true);
        else animator.SetBool("walking", false);
    }

    void Start()
    {
        room = 0;
    }

    void Update()
    {
        Move();
    }

    public void NextRoom()
    {
        room += 1;
    }

    public void PreviousRoom()
    {
        room -= 1;
    }
}
