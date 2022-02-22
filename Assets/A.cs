using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour
{
    private Behaviour behavior; // ĳ������ �ൿ ��ũ��Ʈ
    private Camera mainCamera; // ���� ī�޶�
    private Vector3 targetPos; // ĳ������ �̵� Ÿ�� ��ġ

    void Start()
    {
        behavior = GetComponent<Behaviour>();
        mainCamera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    void Update()
    {
        // ���콺 �Է��� �޾� �� ��
        if (Input.GetMouseButtonUp(0))
        {
            // ���콺�� ���� ��ġ�� ��ǥ ���� �����´�
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 10000f))
            {
                targetPos = hit.point;
            }
        }

        // ĳ���Ͱ� �����̰� �ִٸ�
        if (behavior.run(targetPos))
        {
            // ȸ���� ���� �����ش�
            behavior.Turn(targetPos);
        }

    }
}





