using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {
        Debug.Log($"<color=yellow>{itemGos.Count}</color>");
      // itemgos�� ��ȸ �ϸ鼭 �����۵��� �̸��� ����ϰ� �ʹ�

        //���
        //�ܰ�
        //Ȱ
        //1.for
        //2.foreach(�б�����)

        for(int i = 0; i < itemGos.Count; i++)
        {
            //����Ʈ�� �ε����� �ش��ϴ� ����� �� ���
          // Debug.Log($"{i} => {this.itemGos[i]");
           GameObject itemGo = this.itemGos[i];
          Item item= itemGo.GetComponent<Item>();
        //   Debug.Log($"{this.itemName}");
        }


    }
        

}
