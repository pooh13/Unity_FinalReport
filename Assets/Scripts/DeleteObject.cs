using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteObject : MonoBehaviour
{
    float ObjectPositionX;
    float ObjectPositionZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // 當發生碰撞時，觸發
    void OnTriggerEnter(Collider other)
    {   
        // 刪除物件
        Destroy(gameObject);
    }
}
