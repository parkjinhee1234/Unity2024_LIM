using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : MonoBehaviour
{
    // "������ ��" �÷��̾� ��ġ�� �����ؼ� �ش� �������� �Ѿ��� �ӵ��� �߻�ȴ�.
    // �� �Ѿ��� �ٸ� �繰�� �浹���� �� �̺�Ʈ�� �߻��ϰ� �� ���� ������Ʈ�� �����Ѵ�.

    // (1) �÷��̾� ��ġ �����ϴ� ��� 
    public Transform PlayerTransform;

    // (2) �Ѿ��� �̵� �ӵ� x �������� �Ѿ��� �������� �����ϱ�
    public float bulletSpeed;
    // (3) �浹 �̺�Ʈ�� ���� 

    // (4) �Ѿ��� ������ ���ؼ� ������ �ش��ϴ� �κ��� �����Ұ̴ϴ�. �Ѿ� ��

    // Start is called before the first frame update
    void Start()
    {
        // �÷��̾��� ��ġ�� �޾ƿ����� �׽�Ʈ �غ���. 
        Debug.Log($"���� �÷��̾��� ��ġ : {PlayerTransform}");

        PlayerTransform = GameObject.Find("Player").transform;

        Vector3 playerDirection = new Vector3(PlayerTransform.position.x, 0, PlayerTransform.position.z);
        caulateDirection = (playerDirection - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
    }

    Vector3 caulateDirection;

    private void BulletMove()
    {


        transform.position += bulletSpeed * caulateDirection * Time.deltaTime;
        //transform.Translate(bulletSpeed * playerDirection * Time.deltaTime);
    }

    public void Test()
    {
        Debug.Log("�Ѿ��� �߻�Ǿ���");
    }
    


}