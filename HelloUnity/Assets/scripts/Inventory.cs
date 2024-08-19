using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemGos;

    private void Awake()
    {
        Debug.Log($"<color=yellow>{itemGos.Count}</color>");
      // itemgos를 순회 하면서 아이템들의 이름을 출력하고 싶다

        //장검
        //단검
        //활
        //1.for
        //2.foreach(읽기전용)

        for(int i = 0; i < itemGos.Count; i++)
        {
            //리스트의 인덱스에 해당하는 요소의 값 출력
          // Debug.Log($"{i} => {this.itemGos[i]");
           GameObject itemGo = this.itemGos[i];
          Item item= itemGo.GetComponent<Item>();
        //   Debug.Log($"{this.itemName}");
        }


    }
        

}
