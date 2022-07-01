using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;



public class Player : MonoBehaviour
{
    // 玩家設定
    public GameObject character;
    Vector3 moveDir = Vector3.zero;
    CharacterController characterController; // 宣告角色控制變數
    int speed = 10;  // 移動速度

    // 玩家血量設定 
    public const int maxHealth = 200;
    public int currentHealth = maxHealth;
    public RectTransform HealthBar, Hurt; //血量條

    //UI
    public GameObject GameOverWindow;  //結束視窗
    public Button RestartButton;

    // Start is called before the first frame update
    void Start()
    {
        // 取得元件
        characterController = GetComponent<CharacterController>();
        //UI
        GameOverWindow.gameObject.SetActive(false);
        RestartButton.onClick.AddListener(RestartGame);//重新鍵按下監聽事件
    }

    // Update is called once per frame
    void Update()
    {
        // 讀取方向鍵按下的時間, 值介於 -1~1
        float h = Input.GetAxis("Horizontal");  // 水平
        float v = Input.GetAxis("Vertical");  // 垂直

        // 更改方向
        moveDir = Vector3.right * h + Vector3.forward * v;

        // 使角色看向該座標
        transform.LookAt(transform.position + moveDir);

        // 控制角色移動
        characterController.Move(moveDir * Time.deltaTime * speed);

        // //將綠色血條同步到當前血量長度
        HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
        
    }
    
    // 當發生碰撞時，觸發OnTriggerEnter
    void OnTriggerEnter(Collider other)
    {
        // 碰到殭屍扣血
        if(other.gameObject.tag == "Zombie01")
        {
            currentHealth = currentHealth - 10;
            //呈現傷害量
            if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)
            {
                //讓傷害量(紅色血條)逐漸追上當前血量
                Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;
            }
        }
        else if(other.gameObject.tag == "Zombie02")
        {
            currentHealth = currentHealth - 30;
            //呈現傷害量
            if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)
            {
                //讓傷害量(紅色血條)逐漸追上當前血量
                Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;
            }
        }
        else if(other.gameObject.tag == "Zombie03")
        {
            currentHealth = currentHealth - 50;
            //呈現傷害量
            if (Hurt.sizeDelta.x > HealthBar.sizeDelta.x)
            {
                //讓傷害量(紅色血條)逐漸追上當前血量
                Hurt.sizeDelta += new Vector2(-1, 0)*Time.deltaTime*10;
            }
        }
        
        // 碰到橘盒子加血
        if(other.gameObject.tag == "GetBlood")
        {
            currentHealth = currentHealth + 10;
            if(currentHealth>=200)
            {
                currentHealth = 200;
                HealthBar.sizeDelta = new Vector2(currentHealth, HealthBar.sizeDelta.y);
            }
            else
            {
                HealthBar.sizeDelta += new Vector2(1, 0)*Time.deltaTime*10;
            }
        }

        if(currentHealth <= 0 ){
            Time.timeScale = 0; //遊戲時間停止
            GameOverWindow.gameObject.SetActive(true);
        }
    }
    //當按下重新鍵，開始執行RestartGame函式
    void RestartGame(){
        SceneManager.LoadScene (0);//重新開始遊戲
        Time.timeScale = 1;        //遊戲時間開始執行
    }
    
}
    

