using UnityEngine;

namespace ThePipeCat.Persona
{
    /// <summary>
    /// Persona inventory.
    /// </summary>
    [CreateAssetMenu(fileName = "New Inventory Profile", menuName = "Persona/Inventory")]
    public class PersonaInventory : ScriptableObject
    {
        [SerializeField]
        InventorySlotInfo[] m_Slots;
        [System.NonSerialized]
        int m_Coins;

        public InventorySlotInfo[] Slots
        {
            get { return m_Slots; }
        }

        public int Coins
        {
            get { return m_Coins; }
            set { m_Coins = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ThePipeCat.Persona.PersonaInventory"/> class.
        /// </summary>
        /// <param name="limit">Limit.</param>
        public PersonaInventory(int limit)
        {
            m_Slots = new InventorySlotInfo[limit];
        }

        /// <summary>
        /// Add the specified item and count.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="item">Item.</param>
        /// <param name="count">Count.</param>
        public InventorySlotInfo Add(ItemProfile item, int count = 1)
        {
            InventorySlotInfo slotInfo = null;

            int limit = m_Slots.Length;

            for (int i = 0; i < limit; i++)
            {
                if (m_Slots[i].Item == item)
                {
                    slotInfo = m_Slots[i];
                    break;
                }
            }

            if (slotInfo == null)
            {
                for (int i = 0; i < limit; i++)
                {
                    if (m_Slots[i] == null)
                    {
                        m_Slots[i] = new InventorySlotInfo(item, count);
                        break;
                    }
                }
            }
            else
            {
                slotInfo.Count += count;
            }

            return slotInfo;
        }

        /// <summary>
        /// Remove the specified item.
        /// </summary>
        /// <returns>The remove.</returns>
        /// <param name="item">Item.</param>
        public bool Remove(ItemProfile item)
        {
            bool removed = false;
            int limit = m_Slots.Length;

            for (int i = 0; i < limit; i++)
            {
                if (m_Slots[i].Item == item)
                {
                    m_Slots[i] = null;
                    removed = true;

                    break;
                }
            }

            return removed;
        }

        /// <summary>
        /// Drop an ammount of the item.
        /// </summary>
        public bool Drop(ItemProfile item, int ammount = 0)
        {
            bool droped = false;
            int limit = m_Slots.Length;

            for (int i = 0; i < limit; i++)
            {
                if (m_Slots[i].Item == item)
                {
                    m_Slots[i].Count -= ammount;
                    droped = true;

                    break;
                }
            }

            return droped;
        }

        /// <summary>
        /// Sets the limit.
        /// </summary>
        /// <param name="newLimit">New limit.</param>
        public void SetLimit(int newLimit)
        {
            int limit = m_Slots.Length;
            InventorySlotInfo[] tmpSlots = new InventorySlotInfo[limit];

            for (int i = 0; i < limit; i++)
            {
                tmpSlots[i] = m_Slots[i];
            }

            m_Slots = new InventorySlotInfo[newLimit];

            for (int i = 0; i < limit; i++)
            {
                m_Slots[i] = tmpSlots[i];
            }
        }
    }
}
