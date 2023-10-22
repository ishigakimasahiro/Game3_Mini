using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
	public GameObject bulletPrefab;

	public Transform firePoint;

	Rigidbody2D playerRB;

	public float moveSpeed;

	//�ǉ��@X��Y�̏��
	float xLimit = 2f;
	float yLimit = 4f;

	private void Start()
    {
		playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
	{
		float x2 = Input.GetAxisRaw("Horizontal");

		transform.position += new Vector3(x2, -4f, 0) * Time.deltaTime * 4f;

		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(bulletPrefab, firePoint.transform.position, Quaternion.identity);
		}

		//�ǉ��@���݂̃|�W�V������ێ�����
		Vector3 currentPos = transform.position;

		//�ǉ��@Mathf.Clamp��X,Y�̒l���ꂼ�ꂪ�ŏ��`�ő�͈͓̔��Ɏ��߂�B
		//�͈͂𒴂��Ă�����͈͓��̒l��������
		currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
		currentPos.y = Mathf.Clamp(currentPos.y, -yLimit, -yLimit);

		//�ǉ��@position��currentPos�ɂ���
		transform.position = currentPos;
	}
}
