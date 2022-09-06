using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    //JoyStick
    [SerializeField] FixedJoystick playerVariableJoystick;
    //移動スピード
    [SerializeField] float speed;
    //CharacterController型の変数
    private CharacterController playerController;
    //playerの位置
    private Vector3 playerDirection;

    void Start()
    {
        //CharacterControllerの取得
        playerController = GetComponent<CharacterController>();
    }
    void Update()
    {
        //playerの移動
        playerController.Move(playerDirection * speed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        //JoyStickで動かした位置
        playerDirection = Vector3.forward * playerVariableJoystick.Vertical + Vector3.right * playerVariableJoystick.Horizontal;
    }

    void PlayerRotation()
    {
        if (Input.touchCount > 0)  
        {
            var touch = Input.GetTouch(0);  
            if (touch.phase == TouchPhase.Began)  
            {
                var pos = touch.position;  
            }
        }
    }
}
