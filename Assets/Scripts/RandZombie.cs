using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandZombie : MonoBehaviour
{
    // 角色設定（殭屍）
    public GameObject zombie01; // 初階殭屍
    float timer01 = 5; // 每5秒生成一隻zombie01
    int zom01 = 0; // 計算生成zombie01的數量

    public GameObject zombie02; // 中階殭屍
    float timer02 = 10; // 每10秒生成一隻zombie02
    int zom02 = 0; // 計算生成zombie02的數量

    public GameObject zombie03; // 高階殭屍
    float timer03 = 15; // 每15秒生成一隻zombie03
    int zom03 = 0; // 計算生成zombie03的數量

    // 分數計算
    int score = 0;
    public GameObject ShowLevel; // 顯示關卡
    public GameObject ScoreText; // 顯示分數
    public GameObject ScoreText2; // 最終分數顯示
    public GameObject ShowMessage; // 顯示獲取的武器

    // Start is called before the first frame update
    void Start()
    {
        RandomZombie01();
    }

    // Update is called once per frame
    void Update()
    {
        // 顯示Level
        if(score < 500)
        {
            ShowLevel.GetComponent<Text>().text = "Level 1";
        }
        else if(score >= 500 && score <2000)
        {
            ShowLevel.GetComponent<Text>().text = "Level 2";
        }
        else if(score >=2000)
        {
            ShowLevel.GetComponent<Text>().text = "Level 3";
        }
        
        // 生成初階Zombie
        timer01 = timer01 - Time.deltaTime;
        if(timer01 <= 0)
        {
            timer01 = 5;
            RandomZombie01();
        }
        // 計算分數
        int count01 = 0; // 計算場上的Zombie01數量
        count01 = GameObject.FindGameObjectsWithTag("Zombie01").Length;
        if(count01 != zom01)//當場上的殭屍不等於生出的殭屍數量
        {
            score = score + 50;
            ScoreText.GetComponent<Text>().text = (score).ToString();
            ScoreText2.GetComponent<Text>().text = (score).ToString();
            zom01 = count01;
        }

        // 生成中階Zombie
        if(score >= 500)
        {  
            timer02 = timer02 - Time.deltaTime;
            if(timer02 <= 0)
            {
                timer02 = 10;
                RandomZombie02();
            }
            int count02 = 0; // 計算場上的Zombie02數量
            count02 = GameObject.FindGameObjectsWithTag("Zombie02").Length;
            if(count02 != zom02)//當場上的殭屍不等於生出的殭屍數量
            {
                score = score + 150;
                ScoreText.GetComponent<Text>().text = (score).ToString();
                ScoreText2.GetComponent<Text>().text = (score).ToString();
                zom02 = count02;
            }
        }

        // 生產高階Zombie
        if(score >= 2000)
        {
            timer03 = timer03 - Time.deltaTime;
            if(timer03 <= 0)
            {
                timer03 = 15;
                RandomZombie03();
            }
            int count03 = 0; // 計算場上的Zombie03數量
            count03 = GameObject.FindGameObjectsWithTag("Zombie03").Length;
            if(count03 != zom03)//當場上的殭屍不等於生出的殭屍數量
            {
                score = score + 500;
                ScoreText.GetComponent<Text>().text = (score).ToString();
                ScoreText2.GetComponent<Text>().text = (score).ToString();
                zom03 = count03;
            }
        }
    }

    void RandomZombie01()//Zombie01隨機三點出生地生出
    {
        int ZomPosRandom1 = Random.Range(1, 4); //隨機生成1～3數字，讓殭屍隨機點出生
        zom01 = zom01 + 1;
        // Debug.Log(ZomPosRandom);
        if(ZomPosRandom1 == 1)
        {
            GameObject zom1 = Instantiate(zombie01, new Vector3(39f, 0f, -41.5f), this.transform.rotation) as GameObject;
        }
        else if(ZomPosRandom1 == 2)
        {
            GameObject zom1 = Instantiate(zombie01, new Vector3(-15f, 0f, -41.5f), this.transform.rotation) as GameObject;
        }
        else
        {
            GameObject zom1 = Instantiate(zombie01, new Vector3(-40.1f, 0f, 40.1f), this.transform.rotation) as GameObject;
        }
    }

    void RandomZombie02()//Zombie02隨機三點出生地生出
    {
        int ZomPosRandom2 = Random.Range(1, 4); //隨機生成1～3數字，讓殭屍隨機點出生
        zom02 = zom02 + 1;
        // Debug.Log(ZomPosRandom);
        if(ZomPosRandom2 == 1)
        {
            GameObject zom2 = Instantiate(zombie02, new Vector3(39f, 0f, -41.5f), this.transform.rotation) as GameObject;
        }
        else if(ZomPosRandom2 == 2)
        {
            GameObject zom2 = Instantiate(zombie02, new Vector3(-15f, 0f, -41.5f), this.transform.rotation) as GameObject;
        }
        else
        {
            GameObject zom2 = Instantiate(zombie02, new Vector3(-40.1f, 0f, 40.1f), this.transform.rotation) as GameObject;
        }
    }

    void RandomZombie03()//Zombie03隨機三點出生地生出
    {
        int ZomPosRandom3 = Random.Range(1, 4); //隨機生成1～3數字，讓殭屍隨機點出生
        zom03 = zom03 + 1;
        if(ZomPosRandom3 == 1)
        {
            GameObject zom3 = Instantiate(zombie03, new Vector3(39f, 0f, -41.5f), this.transform.rotation) as GameObject;
        }
        else if(ZomPosRandom3 == 2)
        {
            GameObject zom3 = Instantiate(zombie03, new Vector3(-15f, 0f, -41.5f), this.transform.rotation) as GameObject;
        }
        else
        {
            GameObject zom3 = Instantiate(zombie03, new Vector3(-40.1f, 0f, 40.1f), this.transform.rotation) as GameObject;
        } 
    }
}
