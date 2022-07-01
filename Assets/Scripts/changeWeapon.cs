using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeWeapon : MonoBehaviour
{
    public GameObject handgun;
    public GameObject kar98;
    public GameObject rifle;

    public GameObject ShowLevel; // 顯示關卡
    public GameObject ShowMessage; // 顯示獲得武器

    private bool level02 = false;
    private bool level03 = false;

    // Start is called before the first frame update
    void Start()
    {
        kar98.SetActive(false);
        rifle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {   
        if(!level02)
        {
            if(ShowLevel.GetComponent<Text>().text == "Level 2")
            {
                level02 = true;
                ShowMessage.GetComponent<Text>().text = "You get a " + rifle.name;
                Invoke("TextDisappear", 2f); // 定時重複執行
            }
        }
        else if(level02)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                handgun.SetActive(true);
                rifle.SetActive(false);
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                handgun.SetActive(false);
                rifle.SetActive(true);
            }
        }

        if(!level03)
        {
            if(ShowLevel.GetComponent<Text>().text == "Level 3")
            {
                level03 = true;
                ShowMessage.GetComponent<Text>().text = "You get a " + kar98.name;
                Invoke("TextDisappear", 2f); // 定時重複執行
            }
        }
        else if(level03)
        {
            if(Input.GetKeyDown(KeyCode.Alpha1))
            {
                handgun.SetActive(true);
                rifle.SetActive(false);
                kar98.SetActive(false);
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {
                handgun.SetActive(false);
                rifle.SetActive(true);
                kar98.SetActive(false);
            }
            else if(Input.GetKeyDown(KeyCode.Alpha3))
            {
                handgun.SetActive(false);
                rifle.SetActive(false);
                kar98.SetActive(true);
            }
        }

    }

    void TextDisappear()
    {
        ShowMessage.GetComponent<Text>().text = "";
    }
}
