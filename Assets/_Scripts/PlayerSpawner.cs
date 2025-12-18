using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] characters;

    void Start()
    {
        if (characters.Length > 0)
        {
            int randomIndex = Random.Range(0, characters.Length);

            GameObject characterInstance = Instantiate(characters[randomIndex], transform);

            var movement = characterInstance.GetComponent<MovementController>();
            var controller = characterInstance.GetComponent<PlayerController>();

            var input = GetComponent<PlayerInput>();

            if (input != null && movement != null && controller != null)
            {
                input.Initialize(controller, movement);
            }
        }
    }
}