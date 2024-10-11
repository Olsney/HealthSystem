using UI;

namespace World.Environment
{
    public class ButtonHeal : ButtonBase
    {
        protected override void ChangeValue() => 
            HealthController.TakeHeal(Value);
    }
}