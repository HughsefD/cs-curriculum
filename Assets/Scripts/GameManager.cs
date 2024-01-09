using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager Gm;
    [Header("Coins")] 
    public TextMeshProUGUI coinText;
    public int coins;
    [Header("Hp")] public TextMeshProUGUI healthText;
    public int health;
    public int maxHealth;
    [Header("Iframes")] public bool iframes;
    private float _timer;
    private float _originalTimer;


    private void Awake()
    {
        if (Gm != null && Gm != this)
        {
        }

        {
            Destroy(gameObject);
        }
        
        {
            Gm = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        _originalTimer = 1.5f;
        _timer = _originalTimer;
        coins = 0;
        maxHealth = 50;
        health = maxHealth;  
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins " + coins;
        healthText.text = "Health " + health;
        if (iframes)
        {
            _timer -= Time.deltaTime;
            if (_timer < 0)
            {
                iframes = false;
                _timer = _originalTimer;
            }    
                
        }
    }
}
