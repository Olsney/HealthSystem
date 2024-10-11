using UI;

public class ButtonAttack : ButtonBase
{
    protected override void ChangeValue() => 
        HealthController.TakeDamage(Value);
}