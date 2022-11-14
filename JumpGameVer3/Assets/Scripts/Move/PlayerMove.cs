using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float turnSpeed = 4.0f; // 마우스 회전 속도    
    private float xRotate = 0.0f; // 내부 사용할 X축 회전량은 별도 정의 ( 카메라 위 아래 방향 )
    public float moveSpeed = 4.0f; // 이동 속도

    public float dash = 5.0f; // 대쉬 거리

    private Rigidbody rigid;

    public int jumpPower = 5; //점프 높이
    private bool IsJumping; //점프를 하고있는지 판단

    public float speed = 5.0f; //player의 이동 속도
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>(); //Rigidbody 컴포넌트를 받아온다
        IsJumping = false; //점프중인지 판단하기위한 bool값 생성 후 초기화
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) //바닥에 닿으면
        {
            IsJumping = false; //점프가 가능한 상태로 만든다
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ----회전 및 이동----
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed; // 좌우로 움직인 마우스의 이동량 * 속도에 따라 카메라가 좌우로 회전할 양 계산
        float yRotate = transform.eulerAngles.y + yRotateSize; // 현재 y축 회전값에 더한 새로운 회전각도 계산
        xRotate = Mathf.Clamp(-xRotate, -45, 90); // Clamp 는 값의 범위를 제한하는 함수
        transform.eulerAngles = new Vector3(-xRotate, yRotate, 0); // 카메라 회전량을 카메라에 반영(X, Y축만 회전)
        Vector3 move = transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal"); //  키보드에 따른 이동량 측정
        transform.position += move * moveSpeed * Time.deltaTime; // 이동량을 좌표에 반영


        // ----점프----
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsJumping) //바닥에 있으면 점프를 실행
            {
                IsJumping = true; //점프를 더이상 하지 못하도록 만든다.
                rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            }
        }




        // ----대쉬----
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            rigid.AddForce(move * dash, ForceMode.Impulse);
        }
    }
}