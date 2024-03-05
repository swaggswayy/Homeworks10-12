namespace Assets.Homework11.Scripts
{
    public class Elf : Enemy
    {
        public override void AcceptVisit(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}
