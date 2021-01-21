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
    private float countdown = 3f;
    public Text waveCountdownText;
    private int waveIndex = 0;

    public GameManager gameManager;

    private void Update()
    {
        StartCoroutine(SkipWaveWhenEnemyFinish());

        if (waveIndex == waves.Length && EnemiesAlive == 0)
        {
            gameManager.WinLevel();
            FindObjectOfType<AudioManager>().Play("PlayerWin");
            this.enabled = false;
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
        else
        {
            countdown -= Time.deltaTime;
        }
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
