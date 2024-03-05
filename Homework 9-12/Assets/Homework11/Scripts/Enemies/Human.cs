namespace Assets.Homework11.Scripts
{
    public class Human : Enemy
    {
        public override void AcceptVisit(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}
