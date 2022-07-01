using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;


public class GameManager : MonoBehaviour
{

    public Button PauseButton;      //暫停遊戲按鈕
    public Button RestartButton;    //重新開始按紐
    public Button OverButton;       //結束遊戲按鈕
    public GameObject PauseWindow;  //暫停視窗
    private bool isPause;           //判斷值

    void Start()
    {
        isPause = false; //還未按下暫停鍵
        PauseButton.onClick.AddListener(PauseGame);    //暫停鍵按下監聽事件
        RestartButton.onClick.AddListener(RestartGame);//重新鍵按下監聽事件
        OverButton.onClick.AddListener(OverGame);      //結束鍵按下監聽事件
        RestartButton.gameObject.SetActive(false);     //停用RestartButton
        OverButton.gameObject.SetActive(false);        //停用OverButton
    }

    void PauseGame()
    {
        isPause =! isPause;

        if (isPause == true) //按下暫停鍵判斷值 = true
        {
            PauseButton.image.sprite = Resources.Load<Sprite>("play"); //圖片樣式 = play
            PauseWindow.gameObject.SetActive(true);                    //開啟暫停視窗
            RestartButton.gameObject.SetActive(true);                  //開啟RestartButton
            OverButton.gameObject.SetActive(true);                     //開啟OverButton
            //遊戲時間停止
            Time.timeScale = 0; 
        }
        else
        {
            PauseButton.image.sprite = Resources.Load<Sprite>("pause");//圖片樣式 = pause
            PauseWindow.gameObject.SetActive(false);                   //停用暫停視窗
            RestartButton.gameObject.SetActive(false);                 //停用RestartButton
            OverButton.gameObject.SetActive(false);                    //停用OverButton
            //遊戲時間繼續
            Time.timeScale = 1;
        
        }
    }
    //當按下重新鍵，開始執行RestartGame函式
    void RestartGame(){
        SceneManager.LoadScene (0);//重新開始遊戲
        Time.timeScale = 1;        //遊戲時間開始執行
    }
    //當按下結束鍵，開始執行OverGame函式
    void OverGame(){
        Application.Quit(); //關閉遊戲
        EditorApplication.isPlaying = false; //關閉執行狀態
    }
    
}