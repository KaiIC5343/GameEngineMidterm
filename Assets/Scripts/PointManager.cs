using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    public static PointManager Instance { get; private set; }
    public int Score { get; private set; }
    public TextMeshPro scoreText;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddPoints(int points)
    {
        Score += points;
        scoreText.SetText("Score: " + Score);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            AddPoints(10);
        }
    }
}
