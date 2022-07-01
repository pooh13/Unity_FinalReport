using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    // 玩家設定
    private Transform player;

    // 角色設定（殭屍）
    int blood01 = 50; // 初階殭屍
    int blood02 = 150; // 中階殭屍
    int blood03 = 500; // 高階殭屍
    float MoveSpeed = 2; // 移動速度
    private NavMeshAgent navMeshAgent; // 控制角色朝目標移動（玩家），避免與牆相撞

    // 粒子特效
    public GameObject bloodEffect; //濺血特效
    public GameObject bulletEffect;//子彈打到殭屍特效

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        navMeshAgent = GetComponent<NavMeshAgent>();
        navMeshAgent.speed = MoveSpeed; // 移動速度
        if(navMeshAgent == null)
        {
            navMeshAgent = gameObject.AddComponent<NavMeshAgent>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(player.transform.position);
    }

    // 當發生碰撞時，觸發OnTriggerEnter
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "BulletGun") //使用手槍子彈，傷害10
        {
            GameObject bulletObj=Instantiate(bulletEffect,transform.position,transform.rotation);
            Destroy(bulletObj,5f);
            if(this.gameObject.tag == "Zombie01")
            {
                blood01 = blood01 - 10;
                if(blood01 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }else if(this.gameObject.tag == "Zombie02")
            {
                blood02 = blood02 - 10;
                if(blood02 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }else if(this.gameObject.tag == "Zombie03")
            {
                blood03 = blood03 - 10;
                if(blood03 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }
        }else if(other.gameObject.tag == "BulletRifle")//使用步槍子彈，傷害50
        {
            GameObject bulletObj=Instantiate(bulletEffect,transform.position,transform.rotation);
            Destroy(bulletObj,5f);
            if(this.gameObject.tag == "Zombie01")
            {
                blood01 = blood01 - 50;
                if(blood01 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }else if(this.gameObject.tag == "Zombie02")
            {
                blood02 = blood02 - 50;
                if(blood02 == 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }else if(this.gameObject.tag == "Zombie03")
            {
                blood03 = blood03 - 50;
                if(blood03 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }
        }else if(other.gameObject.tag == "BulletKar98")//使用狙擊槍子彈，傷害100
        {
            GameObject bulletObj=Instantiate(bulletEffect,transform.position,transform.rotation);
            Destroy(bulletObj,5f);
            if(this.gameObject.tag == "Zombie01")
            {
                blood01 = blood01 - 100;
                if(blood01 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }else if(this.gameObject.tag == "Zombie02")
            {
                blood02 = blood02 - 100;
                if(blood02 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }else if(this.gameObject.tag == "Zombie03")
            {
                blood03 = blood03 - 100;
                if(blood03 <= 0)
                {
                    GameObject obj = Instantiate(bloodEffect, transform.position, transform.rotation);
                    Destroy(obj, 3f);
                    Destroy(this.gameObject);
                }
            }
        }
    }
}
