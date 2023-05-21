using UnityEngine;

public class spawn : MonoBehaviour {
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(player, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
