using UnityEngine;

public class PersistanceManager : MonoBehaviour
{
    public static PersistanceManager Instance;
    public string PlayerName;
    void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
    }
}
