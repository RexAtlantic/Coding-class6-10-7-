using TMPro;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //variables

    public static GameManager instance;

    public int score = 0;

    //Make an Array use []

    private string newgamename = "Metroid";

    public string[] gamelist = new string[10] {"Fortnite","Street Fighter","Skate","Lethal League","Silksong","Yakuza","Blue Prince","Ghost of Yotei","God of War","Mario"};

    public TextMeshProUGUI text;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(GameManager.instance);
        }

        else
        {
            Destroy(GameManager.instance);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamelist[0] = newgamename;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = gamelist[score];
    }
}
