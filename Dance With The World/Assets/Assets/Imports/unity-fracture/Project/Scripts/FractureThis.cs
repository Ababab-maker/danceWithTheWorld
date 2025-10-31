using UnityEngine;
using Random = System.Random;

namespace Project.Scripts.Fractures
{
    public class FractureThis : MonoBehaviour
    {
        [SerializeField] private Anchor anchor = Anchor.Bottom;
        [SerializeField] private int chunks = 500;
        [SerializeField] private float density = 50;
        [SerializeField] private float internalStrength = 20;
            
        [SerializeField] private Material insideMaterial;
        [SerializeField] private Material outsideMaterial;

        private Random rng = new Random();

        private void Start()
        {
            ChunkGraphManager chunkGraphManager = FractureGameobject();
            
            SelfBrokener selfBrokener = chunkGraphManager.gameObject.AddComponent<SelfBrokener>();
            selfBrokener.MoverName = "hawaii_shake";
            
            chunkGraphManager.transform.position =  transform.position;
            chunkGraphManager.transform.SetParent(this.transform.parent);
            
            gameObject.SetActive(false);
        }

        public ChunkGraphManager FractureGameobject()
        {
            var seed = rng.Next();
            return Fracture.FractureGameObject(
                gameObject,
                anchor,
                seed,
                chunks,
                insideMaterial,
                outsideMaterial,
                internalStrength,
                density
            );
        }
    }
}