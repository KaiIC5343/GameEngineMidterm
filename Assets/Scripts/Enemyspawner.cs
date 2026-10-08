using UnityEngine;

public abstract class Enemyspawner : MonoBehaviour
{
    public abstract Enemy SpawnEnemy(Vector2 position);
}
