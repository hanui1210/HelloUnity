using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // 멤버변수
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    //이벤트함수 => 순서대로 작성
    private void Awake()
    {
        Debug.Log("Awake메서드 호출됨!");
        // 공격력 : damage ==0
        Debug.Log($"아이템명: {this.itemName}");
        Debug.Log($"공격력: {this.damage}");
        Debug.Log($"공격속도: {this.attackSpeed}");
        Debug.Log($"파괴여부: {this.isBroken}");
        

       // Debug.Log("공격력: {0}", this.damage);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start메서드 호출됨");
    }

    // Update is called once per frame
    void Update()
    {
        //주석 : ctrl + k + c / 해제 : ctrl + k + u
        //Debug.Log("");
    }
}
