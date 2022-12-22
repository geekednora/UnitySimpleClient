using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new GameManager();
            
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

public class SceneController: MonoBehaviour
{
    // Singleton instance... //
    private static SceneController _instance;
    public static SceneController Instance
    {
        get
        {
            if(_instance == null)
                _instance = new SceneController();

            return _instance;
        }
    }

    private void Awake()
    {
        _instance= this;
    }
    // End of Singleton Instance. //
}
