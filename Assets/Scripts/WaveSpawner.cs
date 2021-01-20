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

    private void Update()
    {
        StartCoroutine(skipWaveWhenEnemyFinish());

        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            return;
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = "Next Wave in: " + Mathf.Round(countdown).ToString();
    }

    private IEnumerator skipWaveWhenEnemyFinish()
    {
        yield return new WaitForSeconds(3);
        if (EnemiesAlive == 0)
        {
            countdown = 0;
        }
    }

    private IEnumerator SpawnWave()
    {
        Wave wave = waves[waveIndex];
        PlayerStats.Rounds++;

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
        EnemiesAlive++;
    }
}
