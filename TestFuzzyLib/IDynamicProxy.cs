namespace TestFuzzyLib
{
    // This interface is supported directly by the Interposer class itself. 
    // This interface allows a caller to retrieve the object instance on 
    // which the Interposer performs method invocation through reflection. 
    public interface IDynamicProxy<out T> { T Target { get; } }
}