using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 2;
    public GameObject prefabCoin;

    // Update is called once per frame
    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnCoin();
        }

        timer += Time.deltaTime;
    }
    
    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(prefabCoin);
        newCoin.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newCoin, 10f);
    }
}
