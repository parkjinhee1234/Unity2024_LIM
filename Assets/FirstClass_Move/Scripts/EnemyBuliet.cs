using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBuliet : MonoBehaviour
{
    // "������ ��" �÷��̾� ��ġ�� �����ؼ� �ش� �������� �Ѿ��� �ӵ��� �߻�ȴ�.
    // �� �Ѿ��� �ٸ� �繰�� �浹���� �� �̺�Ʈ�� �߻��ϰ� �� ���� ������Ʈ�� �����Ѵ�.

    // (1) �÷��̾� ��ġ �����ϴ� ���
    public Transform PlayerTransform;
    // (2) �Ѿ��� �̵� �ӵ� x �������� �Ѿ��� �������� �����ϱ�
    public float bulletSpeed;
    // (3) �浹 �̺�Ʈ�� ����

    // (4) �Ѿ��� ������ ���ؼ� ������ �ش��ϴ� �κ��� �����Ұ̴ϴ�.
    void Start()
    {
        // �÷��̾��� ��ġ�� �޾ƾ����� �׽�Ʈ �غ���.
        Debug.Log("���� �÷��̾��� ��ġ : {PlayerTransform}");

        PlayerTransform = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
    }

    private void BulletMove()
    {
        Vector3 playerDirection = PlayerTransform.position;
        transform.position += bulletSpeed * playerDirection * Time.deltaTime;
    }

    

}
