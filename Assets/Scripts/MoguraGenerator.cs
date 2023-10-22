using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoguraGenerator : MonoBehaviour
{
    public GameObject MoguraPrefab;

    [SerializeField] Transform MoguraRoot;

    void Start()
    {
        Generator();
    }


    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit2D =
            Physics2D.Raycast((Vector2)ray.origin,(Vector2)ray.direction,10f);

        if(Input.GetMouseButtonDown(0))
        {
            if(hit2D.collider)
            {
                Score.Instance.AddScore(10);
                Destroy(hit2D.collider.gameObject);
                Generator();
            }
        }
    }

    private void Generator()
    {
        Vector3 randomMogura = new Vector3(Random.Range(-4,4), Random.Range(-4,4), transform.position.x);

        Instantiate(MoguraPrefab, randomMogura, Quaternion.identity,MoguraRoot);
    }
}
