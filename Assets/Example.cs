using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    void Update()
    {
        //マウスをクリックした場合
        if (Input.GetMouseButtonDown(0))
        {
            //カメラの位置からマウスの位置に向けてレイを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            //レイがヒットした場合
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                //ヒットしたオブジェクトのタグ名がCubeの場合
                if (hit.collider.gameObject.CompareTag("Cube"))
                {
                    print("クリックされました");
                }
            }
        }
    }
}
