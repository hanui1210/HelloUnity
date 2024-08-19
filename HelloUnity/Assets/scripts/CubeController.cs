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
        // 큐브의 위치를 출력
        // 클래스의 현재 인스터스
        // cubecontroller 인스턴스
        //Transform transform = this.gameObject.GetComponent<Transform>();
       // this.transform;
        // cubecontroller 컴포넌트가 붙어있는
        // 게임오브젝트의 Transdrom 컴포넌트의
        // position 속성의 값을 출력
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
