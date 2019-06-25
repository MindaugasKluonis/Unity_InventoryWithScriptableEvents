using UnityEngine;
using GameEntity.Item;

namespace GameInventory
{
    public class InventoryController : MonoBehaviour
    {
        private Inventory currentInventory;
        [SerializeField]
        private InventoryView currentInventoryView;

        private void Awake()
        {
            currentInventory = new Inventory();
        }

        private void Start()
        {
            UpdateSlotCount(currentInventory.GetInventorySize());
        }

        public void UpdateSlotCount(int count)
        {
            int totalCount = currentInventoryView.GetTotalSlotCount();
            InventoryItem currentSlot;

            for (int i = 0; i < totalCount; i++)
            {
                currentSlot = currentInventoryView.GetInventoryItem(i);

                if (i < count)
                {
                    currentSlot.Enable();
                    continue;
                }

                currentSlot.Disable();
            }
        }

        public void SetInventory(Inventory inventory)
        {
            currentInventory = inventory;
        }

        public Inventory GetInventory()
        {
            return currentInventory;
        }

        public void SetInventoryView(InventoryView view)
        {
            currentInventoryView = view;
            //OnEnable <-
        }

        public bool AddItem(Item item)
        {
            int count = currentInventory.GetInventorySize();

            for (int i = 0; i < count; i++)
            {
                if (currentInventory.IsEmptyAt(i))
                {
                    currentInventory.AddItem(item, i);
                    currentInventoryView.SetItemImage(item.itemSprite, i);
                    return true;
                }
            }

            return false;
        }

        public Item RemoveItem(int index)
        {
            Item temp = null;

            if (!currentInventory.IsEmptyAt(index))
            {
                temp = currentInventory.GetItem(index);
                currentInventory.RemoveItem(index);
            }

            return temp;
        }

        public void OnItemClicked(int index)
        {
            Debug.Log("Clicked at: " + index);
        }

        public void OnItemHovered(int index)
        {
            Debug.Log("Hovered at: " + index);
        }
    }
}