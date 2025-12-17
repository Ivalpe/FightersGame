using UnityEngine;

using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    // En el inspector verás una flechita. Pon Size = 3 y arrastra tus prefabs ahí.
    public GameObject[] characters;

    void Start()
    {
        if (characters.Length > 0)
        {
            int randomIndex = Random.Range(0, characters.Length);

            Instantiate(characters[randomIndex], transform);
        }
    }
}