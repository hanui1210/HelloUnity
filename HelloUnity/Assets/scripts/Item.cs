using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // �������
    public string itemName;
    public int damage;
    public float attackSpeed;
    public bool isBroken;

    //�̺�Ʈ�Լ� => ������� �ۼ�
    private void Awake()
    {
        Debug.Log("Awake�޼��� ȣ���!");
        // ���ݷ� : damage ==0
        Debug.Log($"�����۸�: {this.itemName}");
        Debug.Log($"���ݷ�: {this.damage}");
        Debug.Log($"���ݼӵ�: {this.attackSpeed}");
        Debug.Log($"�ı�����: {this.isBroken}");
        

       // Debug.Log("���ݷ�: {0}", this.damage);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start�޼��� ȣ���");
    }

    // Update is called once per frame
    void Update()
    {
        //�ּ� : ctrl + k + c / ���� : ctrl + k + u
        //Debug.Log("");
    }
}
