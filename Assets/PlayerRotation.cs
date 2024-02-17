using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // ȸ�� �ϴ� ����� �����غ��̴ϴ�.

    public float rotateSpeed = 200f;
   
    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
    }

    private void RotatePlayer()
    {
        // A��  DŰ�� �Է����� �� �ش� �������� ȸ���ϴ� ����� �����մϴ�

        // �Է� ����
        float horizontal = Input.GetAxis("Horizontal"); // -1~1���� ��ȯ���ִ� ���
        // ȸ�� ���� -> ��� �������� ȸ���� ���Ѿ� ����?
        
        float yew = horizontal * rotateSpeed * Time .deltaTime;
        transform.Rotate(Vector3.up ,yew,Space.World); // ���� ��ǥ�� ��� ��ǥ
    }
}
