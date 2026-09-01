using UnityEngine;

public class Gelo : MonoBehaviour
{
    // criar um boolean que define se o chão é gelo ou água
    // se o player passa pelo trigger do chao, o boolean troca
    

    public bool estadoChao = true;
    [SerializeField] GameObject breakingPrefab;

    void OnTriggerExit2D(Collider2D collision)
    {
        GameObject breaking = Instantiate(breakingPrefab, transform.position, Quaternion.identity);
        Destroy(breaking, 1f);
        estadoChao = false;
    }

    void Update()
    {
        if (estadoChao == false)
        {
            print("O chão é água");
            Destroy(gameObject);
        }
        else
        {
            print("O chão é gelo");
        }
    }
}
