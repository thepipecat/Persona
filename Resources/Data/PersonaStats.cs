namespace ThePipeCat
{
  [System.Serializable]
  public class PersonaStats {
    protected float m_life;
    protected float m_maxLife;
    protected float m_attack;
    protected float m_defense;

    public float Life
    {
      get { return m_life; }
      set { m_life = value; }
    }

    public float MaxLife
    {
      get { return m_maxLife; }
      set { m_maxLife = value; }
    }
  }
}