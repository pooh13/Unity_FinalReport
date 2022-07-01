using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootBullet : MonoBehaviour
{
    public GameObject firePoint; // 子彈發射點
    public Rigidbody bulletPrefab; //子彈Prefab

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 按空白鍵後發射
        if (this.gameObject.tag == "HandGun" && Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bullets;
            bullets = Instantiate(bulletPrefab, transform.position, transform.rotation) as Rigidbody; //子彈實體化處理
            bullets.velocity = transform.TransformDirection(Vector3.forward*50); // velocity速度； TransformDirection變換方向
        }
        else if (this.gameObject.tag == "Rifle" && Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bullets;
            bullets = Instantiate(bulletPrefab, transform.position, transform.rotation) as Rigidbody; //子彈實體化處理
            bullets.velocity = transform.TransformDirection(Vector3.forward*50); // velocity速度； TransformDirection變換方向
        }
        else if (this.gameObject.tag == "Kar98" && Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody bullets;
            bullets = Instantiate(bulletPrefab, transform.position, transform.rotation) as Rigidbody; //子彈實體化處理
            bullets.velocity = transform.TransformDirection(Vector3.forward*50); // velocity速度； TransformDirection變換方向
        }
    }
}
