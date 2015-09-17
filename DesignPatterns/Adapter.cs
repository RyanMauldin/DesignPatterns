namespace DesignPatterns
{
    // Intent - Convert an initial interface and adapt
    // it into a result interface that a client expects.
    public abstract class Adapter<TI, TR>
        where TI : class
        where TR : class
    {
        public abstract TR Adapt(TI value);
    }
}
