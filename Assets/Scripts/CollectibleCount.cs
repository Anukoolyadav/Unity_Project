using UnityEngine;

public class CollectibleCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count ;
    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
        
    }
    void start()=>updateCount();
    private void OnEnable() => Collectible.OnCollected += onCollectibleCollected;
    void OnDisable() => Collectible.OnCollected -= onCollectibleCollected;
    void onCollectibleCollected()
    {
        count++;
        updateCount();

    }
    void updateCount()
    {
        text.text =$"{count}/{Collectible.total}";
    }
}

