using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        // ť���� ��ġ�� ���
        // Ŭ������ ���� �ν��ͽ�
        // cubecontroller �ν��Ͻ�
        //Transform transform = this.gameObject.GetComponent<Transform>();
       // this.transform;
        // cubecontroller ������Ʈ�� �پ��ִ�
        // ���ӿ�����Ʈ�� Transdrom ������Ʈ��
        // position �Ӽ��� ���� ���
        //Debug.Log(transform.position.x);
        //Debug.Log(transform.position.y);
        //Debug.Log(transform.position.z);

       // transform.position = new Vector3(0, 0, 0);


    }

    // Update is called once per frame
    void Update()
    {
     Debug.Log(this.transform.position);
        this.transform.transform.position += new Vector3(0, 0, 0.01f);

    }
}
