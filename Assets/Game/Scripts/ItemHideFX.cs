using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine;

namespace SortItems
{
    public class ItemHideFX : MonoBehaviour
    {
        [SerializeField] private VFXPoolProvider _vfxPoolProvider;

        public UnityEvent OnHide;

        public void Hide()
        {
            VFXPoolItem poolItem = _vfxPoolProvider.VFXPool.GetFromPool();
            poolItem.transform.position = transform.position;
            poolItem.ParticleSystem.Play();

            OnHide.Invoke();

            Destroy(this.gameObject,0.2f);
                        
        }
    }
}
