using UnityEngine;

namespace ThePipeCat.Persona
{
  class ItemProfile : ScriptableObject
  {
    [SerializeField]
    private string m_Name;
    [SerializeField]
    private string m_Description;
    [SerializeField]
    private float m_Cost;
    [SerializeField]
    private int m_Quantity;

    public string Name
    {
      get { return m_Name; }
    }

    public string Description
    {
      get { return m_Description; }
    }

    public float Cost
    {
      get { return m_Cost; }
    }

    public int Quantity
    {
      get { return m_Quantity; }
    }

    public ItemProfile (string name, float cost = 0f)
    {
      m_Name = name;
      m_Cost = cost;
    }
  }
}
