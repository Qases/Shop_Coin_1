using UnityEngine.EventSystems;
using UnityEngine;

namespace SortItems
{
    public class ItemHideFX : MonoBehaviour
    {
        [SerializeField] private VFXPoolProvider _vfxPoolProvider;

        public void Hide()
        {
            VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();

            Destroy(this.gameObject);
                        
        }
    }
}
