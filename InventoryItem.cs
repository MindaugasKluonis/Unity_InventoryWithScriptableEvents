using UnityEngine;
using UnityEngine.UI;
using ScriptableEvents;

namespace GameInventory
{
    public class InventoryItem : MonoBehaviour
    {
        public int ID;
        [SerializeField]
        private IntGameEvent onClickEvent;
        [SerializeField]
        private IntGameEvent onHoverEvent;

        [SerializeField]
        private Image itemImage;
        private Sprite defaultSprite;

        private void Awake()
        {
            defaultSprite = itemImage.sprite;
        }

        public void UpdateSlotSprite(Sprite sprite)
        {
            itemImage.sprite = sprite;
        }

        public void ClearSlot()
        {
            itemImage.sprite = defaultSprite;
        }

        public void Enable()
        {
            gameObject.SetActive(true);
        }

        public void Disable()
        {
            gameObject.SetActive(false);
        }

        public void OnInventoryItemClicked()
        {
            onClickEvent.Raise(ID);
        }

        public void OnInventoryItemHovered()
        {
            onHoverEvent.Raise(ID);
        }
    }
}
