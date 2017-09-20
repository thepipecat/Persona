using UnityEngine;
using System.Collections.Generic;

namespace ThePipeCat
{
  /// <summary>
  /// Inventory slot info.
  /// </summary>
  public class InventorySlotInfo
  {
    public GameObject Item = null;
    public int Index = -1;
    public int Count = 0;
  }

  /// <summary>
  /// Persona inventory.
  /// </summary>
  public class PersonaInventory : ScriptableObject
  {
    private int m_limit = 10;
    private Dictionary<GameObject, InventorySlotInfo> m_slots;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:ThePipeCat.PersonaInventory"/> class.
    /// </summary>
    /// <param name="limit">Limit.</param>
    PersonaInventory(int limit)
    {
      m_limit = limit;
      m_slots = new Dictionary<GameObject, InventorySlotInfo>();
    }

    /// <summary>
    /// Add the specified item and count.
    /// </summary>
    /// <returns>The add.</returns>
    /// <param name="item">Item.</param>
    /// <param name="count">Count.</param>
    public InventorySlotInfo Add(GameObject item, int count = 1)
    {
      InventorySlotInfo slotInfo = new InventorySlotInfo();

      if (m_slots.TryGetValue(item, out slotInfo))
      {
        slotInfo.Count += count;
      }
      else
      {
        if (m_slots.Count < m_limit)
        {
          slotInfo.Item = item;
          slotInfo.Index = m_slots.Count;
          slotInfo.Count = 1;

          m_slots.Add(item, slotInfo);
        }
      }

      return slotInfo;
    }

    /// <summary>
    /// Remove the specified item.
    /// </summary>
    /// <returns>The remove.</returns>
    /// <param name="item">Item.</param>
    public bool Remove(GameObject item)
    {
      return m_slots.Remove(item);
    }

    public bool Drop (GameObject item, int ammount = 0) {
      InventorySlotInfo slotInfo;

      if (m_slots.TryGetValue(item, out slotInfo)) {
        slotInfo.Count -= ammount;
      }

      return (slotInfo != null);
    }

    /// <summary>
    /// Items this instance.
    /// </summary>
    /// <returns>The items.</returns>
    public InventorySlotInfo[] Items()
    {
      InventorySlotInfo[] list = new InventorySlotInfo[m_limit];

      int i = 0;

      foreach (KeyValuePair<GameObject, InventorySlotInfo> slotInfo in m_slots)
      {
        list.SetValue(slotInfo.Value, i++);
      }

      return list;
    }

    /// <summary>
    /// Sets the limit.
    /// </summary>
    /// <param name="newLimit">New limit.</param>
    public void SetLimit(int newLimit)
    {
      m_limit = newLimit;
    }
  }
}
