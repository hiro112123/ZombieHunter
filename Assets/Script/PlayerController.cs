using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] FixedJoystick playerVariableJoystick;
    [SerializeField] float speed  = 1;
    private CharacterController playerController;
    private Vector3 playerDirection;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        playerController.Move(playerDirection * speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        playerDirection = Vector3.forward * playerVariableJoystick.Vertical + Vector3.right * playerVariableJoystick.Horizontal;
    }
}
