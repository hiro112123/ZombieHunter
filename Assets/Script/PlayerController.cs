using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    //移動用JoyStick
    [SerializeField] FixedJoystick moveJoystick;
    //視点用JoyStick
    [SerializeField] FloatingJoystick rotateJoystick;
    //移動スピード
    [SerializeField] float moveSpeed;
    //回転スピード
     [SerializeField] float rotateSpeed;
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
        playerController.Move(playerDirection * moveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, rotateSpeed * rotateJoystick.Horizontal, 0));
    }

    void FixedUpdate()
    {
        //JoyStickで動かした位置
        playerDirection = Vector3.forward * moveJoystick.Vertical + Vector3.right * moveJoystick.Horizontal;
    }
}
