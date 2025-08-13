using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    Rigidbody m_Rigidbody;
    float power = 50.0f;

    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void AddForceTest()
    {
        // �Է��� ��(����)���� �ؼ��ϰ�, �ӵ��� '�� * DT / ����'�� ������ ����.        // ȿ���� �ùķ��̼� �ܰ� ���̿� ��ü�� ������ ���� �޶����ϴ�.
        m_Rigidbody.AddForce(transform.up * power);

        // �Ű������� ��ݷ�(����-��)���� �ؼ��ϰ�, ��/���� ������ �ӵ��� ����.
        // ȿ���� ��ü�� ������ ���� �޶�������, �ùķ��̼� �ܰ� ���̿��� ���� X
        m_Rigidbody.AddForce(transform.up * power, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
    }

    void OnCollisionStay(Collision collision)
    {
    }

    void OnCollisionExit(Collision collision)
    {
    }

    private void OnTriggerEnter(Collider other)
    {
    }

    private void OnTriggerStay(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
    }
}
