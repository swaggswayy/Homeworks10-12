namespace Assets.Homework11.Scripts
{
    public class Ork : Enemy
    {
        public override void AcceptVisit(IEnemyVisitor visitor) => visitor.Visit(this);
    }
}
