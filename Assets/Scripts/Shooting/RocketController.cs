using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
	public GameObject bulletPrefab;

	public Transform firePoint;

	Rigidbody2D playerRB;

	public float moveSpeed;

	//追加　XとYの上限
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

		//追加　現在のポジションを保持する
		Vector3 currentPos = transform.position;

		//追加　Mathf.ClampでX,Yの値それぞれが最小～最大の範囲内に収める。
		//範囲を超えていたら範囲内の値を代入する
		currentPos.x = Mathf.Clamp(currentPos.x, -xLimit, xLimit);
		currentPos.y = Mathf.Clamp(currentPos.y, -yLimit, -yLimit);

		//追加　positionをcurrentPosにする
		transform.position = currentPos;
	}
}
