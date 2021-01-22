using System.Collections;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour
{
    public static int EnemiesAlive = 0;

    [SerializeField]
    private Wave[] waves;

    [SerializeField]
    private Transform spawnPoint;

    [SerializeField]
    public float timeBetweenWaves = 5f;
    private float countdown;
    public Text waveCountdownText;
    private int waveIndex;

    public GameManager gameManager;

    public void Start()
    {
        waveIndex = 0;
        countdown = 3f;
        this.enabled = true;
        EnemiesAlive = 0;
    }

    private void Update()
    {
        //StartCoroutine(SkipWaveWhenEnemyFinish());
        if (EnemiesAlive > 0)
        {
            return;
        }


        if (waveIndex == waves.Length && EnemiesAlive == 0)
        {
            if(gameManager.isOver == false)
            {
                FindObjectOfType<AudioManager>().Play("PlayerWin");
                gameManager.WinLevel();
            }
        }

        if (countdown <= 0f && waveIndex < waves.Length)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }

        if (waveIndex == waves.Length)
        {
            countdown = 0;
        }

        countdown -= Time.deltaTime;

        waveCountdownText.text = "Next Wave in: " + Mathf.Round(countdown).ToString();

    }

    private IEnumerator SkipWaveWhenEnemyFinish()
    {
        yield return new WaitForSeconds(3);
        if (EnemiesAlive <= 0 && waveIndex < waves.Length)
        {
            countdown = 0;
        }
    }

    private IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
        PlayerStats.Rounds++;

        EnemiesAlive = wave.count;

        for (int i = 0; i < wave.count; i++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(1f / wave.rate);
        }
        waveIndex++;
    }

    private void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }
}
