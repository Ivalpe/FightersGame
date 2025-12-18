using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject[] characters;

    void Start()
    {
        if (characters.Length > 0)
        {
            int randomIndex = Random.Range(0, characters.Length);

            // 1. Instanciar
            GameObject newCharacter = Instantiate(characters[randomIndex], transform);

            // 2. Obtener referencias
            var pc = newCharacter.GetComponent<PlayerController>();
            var mc = newCharacter.GetComponent<MovementController>();
            var inputScript = GetComponent<PlayerInput>();

            // 3. CONECTAR (Esta es la parte clave que te debe faltar)
            if (inputScript != null && pc != null && mc != null)
            {
                inputScript.Initialize(pc, mc);
            }
        }
    }
}