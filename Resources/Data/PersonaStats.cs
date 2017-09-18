namespace ThePipeCat
{
  [System.Serializable]
  public class PersonaStats {
    protected float m_Life;
    protected float m_LifeMax;
    protected float m_Attack;
    protected float m_Defense;

    public float Life
    {
      get { return m_Life; }
      set { m_Life = value; }
    }

    public float LifeMax
    {
      get { return m_LifeMax; }
      set { m_LifeMax = value; }
    }
  }
}