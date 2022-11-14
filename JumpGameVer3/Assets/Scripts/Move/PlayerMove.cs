using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float turnSpeed = 4.0f; // ���콺 ȸ�� �ӵ�    
    private float xRotate = 0.0f; // ���� ����� X�� ȸ������ ���� ���� ( ī�޶� �� �Ʒ� ���� )
    public float moveSpeed = 4.0f; // �̵� �ӵ�

    public float dash = 5.0f; // �뽬 �Ÿ�

    private Rigidbody rigid;

    public int jumpPower = 5; //���� ����
    private bool IsJumping; //������ �ϰ��ִ��� �Ǵ�

    public float speed = 5.0f; //player�� �̵� �ӵ�
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); //Rigidbody ������Ʈ�� �޾ƿ´�
        IsJumping = false; //���������� �Ǵ��ϱ����� bool�� ���� �� �ʱ�ȭ
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) //�ٴڿ� ������
        {
            IsJumping = false; //������ ������ ���·� �����
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ----ȸ�� �� �̵�----
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed; // �¿�� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� �¿�� ȸ���� �� ���
        float yRotate = transform.eulerAngles.y + yRotateSize; // ���� y�� ȸ������ ���� ���ο� ȸ������ ���
        xRotate = Mathf.Clamp(-xRotate, -45, 90); // Clamp �� ���� ������ �����ϴ� �Լ�
        transform.eulerAngles = new Vector3(-xRotate, yRotate, 0); // ī�޶� ȸ������ ī�޶� �ݿ�(X, Y�ุ ȸ��)
        Vector3 move = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal"); //  Ű���忡 ���� �̵��� ����
        transform.position += move * moveSpeed * Time.deltaTime; // �̵����� ��ǥ�� �ݿ�


        // ----����----
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsJumping) //�ٴڿ� ������ ������ ����
            {
                IsJumping = true; //������ ���̻� ���� ���ϵ��� �����.
                rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
        }




        // ----�뽬----
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            rigid.AddForce(move * dash, ForceMode.Impulse);
        }
    }
}