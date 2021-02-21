using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private UIManager _uiManager;
    [SerializeField] private GameObject _menu;
    [SerializeField] private Text _playText;
    [SerializeField] private GameObject _menuCamera;
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _controlsMenu;
    public PlayerInputController playerControls;
    [SerializeField] private GameObject _endGameEffect;
    [SerializeField] private GameObject _thankYou;

    private bool inPlay = false;
    private bool gameOver = false;

    void Start()
    {
        //Application.targetFrameRate = 144;
        playerControls.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && inPlay)
        {
            Pause();
        }
    }


    public void Play()
    {
        if (gameOver)
        {
            Restart();
            return;
        }
        _menu.SetActive(false);
        _menuCamera.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerControls.enabled = true;
        inPlay = true;
    }

    public void Pause()
    {
        playerControls.enabled = false;
        _playText.text = "RESUME";
        _menu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void EndGameMenu()
    {
        playerControls.enabled = false;
        _thankYou.SetActive(true);
        _playText.text = "Main Menu";
        _menu.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        gameOver = true;
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Controls()
    {
        _mainMenu.SetActive(false);
        _controlsMenu.SetActive(true);
    }

    public void Back()
    {
        _controlsMenu.SetActive(false);
        _mainMenu.SetActive(true);
    }

    public void EndGame()
    {
        _endGameEffect.SetActive(true);
        StartCoroutine(EndGameTimer());
    }

    IEnumerator EndGameTimer()
    {
        yield return new WaitForSeconds(1);
        EndGameMenu();
    }


    public void Restart()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene(0);
    }
}
