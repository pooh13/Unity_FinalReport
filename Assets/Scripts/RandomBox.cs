using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomBox : MonoBehaviour
{
    // 玩家設定
    public GameObject player;

    // 武器設定
    float x;
    public GameObject BoxCube; // 橘色道具盒子
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        // 玩家
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;

        float x = Random.Range(player.transform.position.x-7f, player.transform.position.x+7f); // 隨機產生x座標
        float z = Random.Range(player.transform.position.z-2f, player.transform.position.z+20f); // 隨機產生z座標

        if(timer >= 10) // 每10秒生成一個道具盒子
        {
            timer = 0;
            Instantiate(BoxCube, new Vector3(x, 0.25f, z), Quaternion.identity); // Quaternion.identity 不變動角度
        }
    }
}
