abstract class Character
{
    private string character;
    protected Boolean _isVulnerable = false;
    protected Character(string characterType)
    {
        this.character = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
       return _isVulnerable;
    }

    public override string ToString()
    {
        return $"Character is a {character}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
       if(target.Vulnerable()){
            return 10;
        }
        return 6;
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
       
    }
    private Boolean isVulnerable = true;
    private Boolean isPrepared = true;
    public override int DamagePoints(Character target)
    {
        if(!Vulnerable()){
            return 12;
        }
        return 3;
    }
     public override bool Vulnerable()
    {
       return isVulnerable;
    }
    
    public void PrepareSpell()
    {
       if(isPrepared)
       {
        isVulnerable = false;   
       }
    }
}