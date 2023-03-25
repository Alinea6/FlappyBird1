using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public float repeatRate = 1;
    private float timer = 0;
    public float height = 5;
    public GameObject prefabPipe;
    public Sprite greenSprite;
    public Sprite redSprite;
    public SpriteRenderer upPipe;
    public SpriteRenderer downPipe;

    private void Start()
    {
        upPipe = prefabPipe.transform.GetChild(0).GetComponent<SpriteRenderer>();
        downPipe = prefabPipe.transform.GetChild(1).GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (timer > repeatRate)
        {
            timer = 0;
            SpawnPipe();
        }

        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        GameObject newPipe = Instantiate(prefabPipe);
        var random = Random.Range(0, 2);
        downPipe.sprite = random == 0 ? greenSprite : redSprite;
        upPipe.sprite = random == 0 ? greenSprite : redSprite;
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        Destroy(newPipe, 10f);
    }
}
